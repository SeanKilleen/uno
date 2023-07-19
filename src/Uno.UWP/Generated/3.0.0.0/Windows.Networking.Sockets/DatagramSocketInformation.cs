#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DatagramSocketInformation 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.HostName LocalAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member HostName DatagramSocketInformation.LocalAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HostName%20DatagramSocketInformation.LocalAddress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string LocalPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DatagramSocketInformation.LocalPort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20DatagramSocketInformation.LocalPort");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.HostName RemoteAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member HostName DatagramSocketInformation.RemoteAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HostName%20DatagramSocketInformation.RemoteAddress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string RemotePort
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DatagramSocketInformation.RemotePort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20DatagramSocketInformation.RemotePort");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketInformation.LocalAddress.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketInformation.LocalPort.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketInformation.RemoteAddress.get
		// Forced skipping of method Windows.Networking.Sockets.DatagramSocketInformation.RemotePort.get
	}
}
