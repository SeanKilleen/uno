#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandUiccAppReadRecordResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer MobileBroadbandUiccAppReadRecordResult.Data is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20MobileBroadbandUiccAppReadRecordResult.Data");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.MobileBroadbandUiccAppOperationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member MobileBroadbandUiccAppOperationStatus MobileBroadbandUiccAppReadRecordResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MobileBroadbandUiccAppOperationStatus%20MobileBroadbandUiccAppReadRecordResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandUiccAppReadRecordResult.Status.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandUiccAppReadRecordResult.Data.get
	}
}
