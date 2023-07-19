#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemAuthorizationKindFilter : global::Windows.System.RemoteSystems.IRemoteSystemFilter
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.RemoteSystems.RemoteSystemAuthorizationKind RemoteSystemAuthorizationKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemAuthorizationKind RemoteSystemAuthorizationKindFilter.RemoteSystemAuthorizationKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemAuthorizationKind%20RemoteSystemAuthorizationKindFilter.RemoteSystemAuthorizationKind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public RemoteSystemAuthorizationKindFilter( global::Windows.System.RemoteSystems.RemoteSystemAuthorizationKind remoteSystemAuthorizationKind) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter", "RemoteSystemAuthorizationKindFilter.RemoteSystemAuthorizationKindFilter(RemoteSystemAuthorizationKind remoteSystemAuthorizationKind)");
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter.RemoteSystemAuthorizationKindFilter(Windows.System.RemoteSystems.RemoteSystemAuthorizationKind)
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemAuthorizationKindFilter.RemoteSystemAuthorizationKind.get
		// Processing: Windows.System.RemoteSystems.IRemoteSystemFilter
	}
}
