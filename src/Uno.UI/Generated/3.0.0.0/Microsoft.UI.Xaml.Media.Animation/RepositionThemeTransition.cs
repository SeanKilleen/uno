#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RepositionThemeTransition : global::Microsoft.UI.Xaml.Media.Animation.Transition
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsStaggeringEnabled
		{
			get
			{
				return (bool)this.GetValue(IsStaggeringEnabledProperty);
			}
			set
			{
				this.SetValue(IsStaggeringEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IsStaggeringEnabledProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IsStaggeringEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition.RepositionThemeTransition()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition.RepositionThemeTransition()
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabledProperty.get
	}
}
