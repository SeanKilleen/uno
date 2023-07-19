#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public static partial class PhoneCallManager 
	{
		#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsCallActive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PhoneCallManager.IsCallActive is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PhoneCallManager.IsCallActive");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsCallIncoming
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PhoneCallManager.IsCallIncoming is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PhoneCallManager.IsCallIncoming");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallManager.CallStateChanged.add
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallManager.CallStateChanged.remove
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallManager.IsCallActive.get
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneCallManager.IsCallIncoming.get
		#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ShowPhoneCallSettingsUI()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallManager", "void PhoneCallManager.ShowPhoneCallSettingsUI()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Calls.PhoneCallStore> RequestStoreAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PhoneCallStore> PhoneCallManager.RequestStoreAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CPhoneCallStore%3E%20PhoneCallManager.RequestStoreAsync%28%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static void ShowPhoneCallUI( string phoneNumber,  string displayName)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallManager", "void PhoneCallManager.ShowPhoneCallUI(string phoneNumber, string displayName)");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<object> CallStateChanged
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallManager", "event EventHandler<object> PhoneCallManager.CallStateChanged");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Calls.PhoneCallManager", "event EventHandler<object> PhoneCallManager.CallStateChanged");
			}
		}
		#endif
	}
}
