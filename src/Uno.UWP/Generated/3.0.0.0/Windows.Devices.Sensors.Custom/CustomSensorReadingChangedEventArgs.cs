#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors.Custom
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CustomSensorReadingChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.Custom.CustomSensorReading Reading
		{
			get
			{
				throw new global::System.NotImplementedException("The member CustomSensorReading CustomSensorReadingChangedEventArgs.Reading is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CustomSensorReading%20CustomSensorReadingChangedEventArgs.Reading");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs.Reading.get
	}
}
