﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.RuntimeTests.Extensions;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using static Private.Infrastructure.TestServices;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Media_Animation
{
	[TestClass]
	public class Given_DoubleAnimation
	{
		[TestMethod]
		[RunsOnUIThread]
		public void When_SeekAlignedToLastTick()
		{
			var target = new Border();
			var doubleAnimation = new DoubleAnimation()
			{
				From = 50d,
				To = 100d,
				EnableDependentAnimation = true
			};
			Storyboard.SetTarget(doubleAnimation, target);
			Storyboard.SetTargetProperty(doubleAnimation, "Height");
			var sb = new Storyboard()
			{
				Children =
				{
					doubleAnimation
				}
			};

			sb.Begin();
			sb.SeekAlignedToLastTick(TimeSpan.FromMilliseconds(50));
		}

		[TestMethod]
		[RunsOnUIThread]
#if __ANDROID__
		[Ignore("In this scenario, droid doesnt ReportEachFrame(), so we won't be able to read the animated values to evaluate this test.")]
#endif
		public async Task When_RepeatForever_WithoutFrom()
		{
			// droid: The fix is still valid for android, because it will now be reading from non-animated value as well.
			// However, that doesnt change anything (it worked before), because the animated was never commited into the property details.

			// note: Without an actual rendered target, playing the storyboard will not
			// affect the actual value effectively voiding this test.
			var target = new TextBlock() { Text = "asdasd" };
			WindowHelper.WindowContent = target;
			await WindowHelper.WaitForIdle();
			await WindowHelper.WaitForLoaded(target);

			var transform = new TranslateTransform();
			target.RenderTransform = transform;

			var animation = new DoubleAnimation()
			{
				// From = ..., // left out for this test
				To = 312,
				Duration = TimeSpan.FromMilliseconds(500),
				FillBehavior = FillBehavior.HoldEnd,
				RepeatBehavior = RepeatBehavior.Forever,
			};
			Storyboard.SetTarget(animation, transform);
			Storyboard.SetTargetProperty(animation, nameof(TranslateTransform.X));

			var storyboard = new Storyboard();
			storyboard.Children.Add(animation);
			storyboard.Begin();

			var values = new List<double>();
			// The delay below are more of a suggestion. We cant realistically expected
			// to land exactly on the end of loop at 500ms. But the idea here is to measure
			// that the animated value doesn't freeze/stuck at DoubleAnimation.To of 312
			// after certain iterations. So the lack of precision is actually desired here.
			await WaitAndSnapshotValue(100); // 0
			await WaitAndSnapshotValue(400); // 1 iteration 1 done
			await WaitAndSnapshotValue(500); // 2 iteration 2 done
			await WaitAndSnapshotValue(500); // 3 iteration 3 done
			await WaitAndSnapshotValue(500); // 4 iteration 4 done
			await WaitAndSnapshotValue(100); // 5
			await WaitAndSnapshotValue(100); // 6
			await WaitAndSnapshotValue(100); // 7
			await WaitAndSnapshotValue(100); // 8
			await WaitAndSnapshotValue(100); // 9 iteration 5 done

			const double SignificantChangePer100MS = 312 / 5 * 0.5; // 0.5 is margin of error
			var last5Recorded = values.Skip(values.Count - 5).ToArray();
			var deltas = last5Recorded.Zip(last5Recorded.Skip(1), (a, b) => Math.Abs(a - b));
			var closeEnough = Comparer<double>.Create((x, y) => // allows for +-1 to be equal
				Math.Abs(x - y) < 1 ? 0 : (x > y ? 1 : -1)
			);

			Assert.IsTrue(deltas.Any(x => x > SignificantChangePer100MS), "animated values (last half) should be changing: " + string.Join(", ", last5Recorded));
			CollectionAssert.AreNotEqual(
				Enumerable.Repeat(312d, 5).ToArray(),
				last5Recorded,
				closeEnough,
				"animated values should not freeze/stuck at end value (312) or near that value: " + string.Join(", ", values)
			);

			async Task WaitAndSnapshotValue(int millisecondsDelay)
			{
				await Task.Delay(millisecondsDelay);
				values.Add(transform.X);
			}
		}

		[TestMethod]
		[RunsOnUIThread]
		public async Task When_RepeatForever_ShouldLoop()
		{
			var target = new Windows.UI.Xaml.Shapes.Rectangle
			{
				Stretch = Stretch.Fill,
				Fill = new SolidColorBrush(Colors.SkyBlue),
				Height = 50,
			};
			WindowHelper.WindowContent = target;
			await WindowHelper.WaitForLoaded(target);
			await WindowHelper.WaitForIdle();

			var animation = new DoubleAnimation
			{
				EnableDependentAnimation = true,
				From = 0,
				To = 50,
				RepeatBehavior = RepeatBehavior.Forever,
				Duration = TimeSpan.FromMilliseconds(500),
			};
			Storyboard.SetTarget(animation, target);
			Storyboard.SetTargetProperty(animation, nameof(Rectangle.Width));

			var storyboard = new Storyboard { Children = { animation } };
			storyboard.Begin();

			var list = new List<double>();
			for (int i = 0; i < 50; i++)
			{
				list.Add(target.Width);
				await Task.Delay(100);
			}

			var delta = list.Zip(list.Skip(1), (a, b) => b - a).ToArray();
			var averageIncrement = delta.Where(x => x > 0).Average();
			var drops = delta.Select((x, i) => new { Delta = x, Index = i })
				.Where(x => x.Delta < 0)
				.Select(x => x.Index)
				.ToArray();
			var incrementSizes = drops.Zip(drops.Skip(1), (a, b) => b - a - 1).ToArray(); // -1 to exclude the drop itself

			// This 500ms animation is expected to climb from 0 to 50, reset to 0 instantly, and repeat forever.
			// Given that we are taking 5measurements per cycle, we can expect the followings:
			Assert.AreEqual(10d, averageIncrement, 1.5, "an rough average of increment (exluding the drop) of 10 (+-15% error margin)");
			Assert.IsTrue(incrementSizes.Count(x => x > 3) > 8, $"at least 10 (-2 error margin: might miss first and/or last) sets of continuous increments that size of 4 (+-1 error margin: sliding slot): {string.Join(",", incrementSizes)}");
		}

		[TestMethod]
		[RunsOnUIThread]
		public async Task When_StartingFrom_AnimatedValue()
		{
			var translate = new TranslateTransform();
			var border = new Border()
			{
				Background = new SolidColorBrush(Colors.Pink),
				Margin = new Thickness(0, 50, 0, 0),
				Width = 50,
				Height = 50,
				RenderTransform = translate,
			};
			WindowHelper.WindowContent = border;
			await WindowHelper.WaitForLoaded(border);
			await WindowHelper.WaitForIdle();

			// Start an animation. Its final value will serve as
			// the inferred starting value for the next animation.
			var animation0 = new DoubleAnimation
			{
				// From = should be 0
				To = 50,
				Duration = new Duration(TimeSpan.FromSeconds(2)),
			}.BindTo(translate, nameof(translate.Y));
			await animation0.RunAsync(timeout: animation0.Duration.TimeSpan + TimeSpan.FromSeconds(1));
			await Task.Delay(1000);

			// Start an second animation which should pick up from current animated value.
			var animation1 = new DoubleAnimation
			{
				// From = should be 50 from animation #0
				To = -50,
				Duration = new Duration(TimeSpan.FromSeconds(5)),
			}.BindTo(translate, nameof(translate.Y));
			animation1.Begin();
			await Task.Delay(125);

			// ~125ms into a 5s animation where the value is animating from 50 to -50,
			// the value should be still positive.
			// note: On android, the value will be scaled by ViewHelper.Scale, but the assertion will still hold true.
			var y = GetTranslateY(translate, isStillAnimating: true);
			Assert.IsTrue(y > 0, $"Expecting Translate.Y to be still positive: {y}");
		}

		private double GetTranslateY(TranslateTransform translate, bool isStillAnimating = false) =>
#if !__ANDROID__
			translate.Y;
#else
			isStillAnimating
				// On android, animation may target a native property implementing the behavior instead of the specified dependency property.
				// We need to retrieve the value of that native property, as reading the dp value will just give the final value.
				? (double)translate.View.TranslationY
				// And, when the animation is completed, this native value is reset even for HoldEnd animation.
				: translate.Y;
#endif
	}
}
