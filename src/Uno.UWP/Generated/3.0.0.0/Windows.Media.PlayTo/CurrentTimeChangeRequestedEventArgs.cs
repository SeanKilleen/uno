#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.PlayTo
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CurrentTimeChangeRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Time
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan CurrentTimeChangeRequestedEventArgs.Time is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20CurrentTimeChangeRequestedEventArgs.Time");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs.Time.get
	}
}
