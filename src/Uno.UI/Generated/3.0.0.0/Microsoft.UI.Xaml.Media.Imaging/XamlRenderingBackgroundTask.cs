#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XamlRenderingBackgroundTask 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected XamlRenderingBackgroundTask() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask", "XamlRenderingBackgroundTask.XamlRenderingBackgroundTask()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask.XamlRenderingBackgroundTask()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnRun( global::Windows.ApplicationModel.Background.IBackgroundTaskInstance taskInstance)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.Imaging.XamlRenderingBackgroundTask", "void XamlRenderingBackgroundTask.OnRun(IBackgroundTaskInstance taskInstance)");
		}
		#endif
	}
}
