#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Dispatching
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DispatcherQueueShutdownStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral DispatcherQueueShutdownStartingEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20DispatcherQueueShutdownStartingEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
