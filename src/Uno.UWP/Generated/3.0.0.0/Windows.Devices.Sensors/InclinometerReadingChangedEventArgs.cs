#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InclinometerReadingChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.InclinometerReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member InclinometerReading InclinometerReadingChangedEventArgs.Reading is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InclinometerReading%20InclinometerReadingChangedEventArgs.Reading");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.InclinometerReadingChangedEventArgs.Reading.get
	}
}
