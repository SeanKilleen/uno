#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UsbInterruptInEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer InterruptData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer UsbInterruptInEventArgs.InterruptData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20UsbInterruptInEventArgs.InterruptData");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptInEventArgs.InterruptData.get
	}
}
