#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SlideNavigationTransitionInfo : global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionEffect Effect
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionEffect)this.GetValue(EffectProperty);
			}
			set
			{
				this.SetValue(EffectProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EffectProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Effect), typeof(global::Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionEffect), 
			typeof(global::Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionEffect)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo.SlideNavigationTransitionInfo()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo.SlideNavigationTransitionInfo()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo.Effect.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo.Effect.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo.EffectProperty.get
	}
}
