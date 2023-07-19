#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PopInThemeAnimation : global::Microsoft.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double FromVerticalOffset
		{
			get
			{
				return (double)this.GetValue(FromVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(FromVerticalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double FromHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(FromHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(FromHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty FromHorizontalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FromHorizontalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty FromVerticalOffsetProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(FromVerticalOffset), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TargetName), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PopInThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation", "PopInThemeAnimation.PopInThemeAnimation()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.PopInThemeAnimation()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.TargetName.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.TargetName.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromHorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromHorizontalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromVerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromVerticalOffset.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.TargetNameProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromHorizontalOffsetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.PopInThemeAnimation.FromVerticalOffsetProperty.get
	}
}
