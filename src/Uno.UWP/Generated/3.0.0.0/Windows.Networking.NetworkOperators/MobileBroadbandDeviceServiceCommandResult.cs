#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandDeviceServiceCommandResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer ResponseData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer MobileBroadbandDeviceServiceCommandResult.ResponseData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20MobileBroadbandDeviceServiceCommandResult.ResponseData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint StatusCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint MobileBroadbandDeviceServiceCommandResult.StatusCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20MobileBroadbandDeviceServiceCommandResult.StatusCode");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult.StatusCode.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult.ResponseData.get
	}
}
