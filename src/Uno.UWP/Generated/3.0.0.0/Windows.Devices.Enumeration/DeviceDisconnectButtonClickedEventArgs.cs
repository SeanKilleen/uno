#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DeviceDisconnectButtonClickedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.DeviceInformation Device
		{
			get
			{
				throw new global::System.NotImplementedException("The member DeviceInformation DeviceDisconnectButtonClickedEventArgs.Device is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DeviceInformation%20DeviceDisconnectButtonClickedEventArgs.Device");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.DeviceDisconnectButtonClickedEventArgs.Device.get
	}
}
