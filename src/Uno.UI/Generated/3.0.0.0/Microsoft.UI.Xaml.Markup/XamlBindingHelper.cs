#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Markup
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlBindingHelper 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty DataTemplateComponentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
			"DataTemplateComponent", typeof(global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent), 
			typeof(global::Microsoft.UI.Xaml.Markup.XamlBindingHelper), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent)));
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Markup.XamlBindingHelper.DataTemplateComponentProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent GetDataTemplateComponent( global::Microsoft.UI.Xaml.DependencyObject element)
		{
			return (global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent)element.GetValue(DataTemplateComponentProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetDataTemplateComponent( global::Microsoft.UI.Xaml.DependencyObject element,  global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent value)
		{
			element.SetValue(DataTemplateComponentProperty, value);
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SuspendRendering(Microsoft.UI.Xaml.UIElement)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.ResumeRendering(Microsoft.UI.Xaml.UIElement)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(System.Type, object)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromString(object, Microsoft.UI.Xaml.DependencyProperty, string)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromBoolean(object, Microsoft.UI.Xaml.DependencyProperty, bool)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromChar16(object, Microsoft.UI.Xaml.DependencyProperty, char)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromDateTime(object, Microsoft.UI.Xaml.DependencyProperty, System.DateTimeOffset)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromDouble(object, Microsoft.UI.Xaml.DependencyProperty, double)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromInt32(object, Microsoft.UI.Xaml.DependencyProperty, int)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUInt32(object, Microsoft.UI.Xaml.DependencyProperty, uint)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromInt64(object, Microsoft.UI.Xaml.DependencyProperty, long)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUInt64(object, Microsoft.UI.Xaml.DependencyProperty, ulong)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromSingle(object, Microsoft.UI.Xaml.DependencyProperty, float)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromPoint(object, Microsoft.UI.Xaml.DependencyProperty, Windows.Foundation.Point)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromRect(object, Microsoft.UI.Xaml.DependencyProperty, Windows.Foundation.Rect)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromSize(object, Microsoft.UI.Xaml.DependencyProperty, Windows.Foundation.Size)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromTimeSpan(object, Microsoft.UI.Xaml.DependencyProperty, System.TimeSpan)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromByte(object, Microsoft.UI.Xaml.DependencyProperty, byte)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromUri(object, Microsoft.UI.Xaml.DependencyProperty, System.Uri)
		// Skipping already declared method Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetPropertyFromObject(object, Microsoft.UI.Xaml.DependencyProperty, object)
	}
}
