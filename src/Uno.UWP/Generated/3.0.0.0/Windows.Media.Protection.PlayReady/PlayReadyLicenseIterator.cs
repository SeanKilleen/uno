#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection.PlayReady
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PlayReadyLicenseIterator : global::Windows.Foundation.Collections.IIterator<global::Windows.Media.Protection.PlayReady.IPlayReadyLicense>
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Protection.PlayReady.IPlayReadyLicense Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member IPlayReadyLicense PlayReadyLicenseIterator.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IPlayReadyLicense%20PlayReadyLicenseIterator.Current");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool HasCurrent
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PlayReadyLicenseIterator.HasCurrent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PlayReadyLicenseIterator.HasCurrent");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Protection.PlayReady.PlayReadyLicenseIterator.Current.get
		// Forced skipping of method Windows.Media.Protection.PlayReady.PlayReadyLicenseIterator.HasCurrent.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool MoveNext()
		{
			throw new global::System.NotImplementedException("The member bool PlayReadyLicenseIterator.MoveNext() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PlayReadyLicenseIterator.MoveNext%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint GetMany( global::Windows.Media.Protection.PlayReady.IPlayReadyLicense[] items)
		{
			throw new global::System.NotImplementedException("The member uint PlayReadyLicenseIterator.GetMany(IPlayReadyLicense[] items) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20PlayReadyLicenseIterator.GetMany%28IPlayReadyLicense%5B%5D%20items%29");
		}
		#endif
		// Processing: Windows.Foundation.Collections.IIterator<Windows.Media.Protection.PlayReady.IPlayReadyLicense>
	}
}
