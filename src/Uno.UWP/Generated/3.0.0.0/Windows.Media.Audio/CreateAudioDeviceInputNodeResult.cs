#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateAudioDeviceInputNodeResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioDeviceInputNode DeviceInputNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceInputNode CreateAudioDeviceInputNodeResult.DeviceInputNode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioDeviceInputNode%20CreateAudioDeviceInputNodeResult.DeviceInputNode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioDeviceNodeCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceNodeCreationStatus CreateAudioDeviceInputNodeResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioDeviceNodeCreationStatus%20CreateAudioDeviceInputNodeResult.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception CreateAudioDeviceInputNodeResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20CreateAudioDeviceInputNodeResult.ExtendedError");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceInputNodeResult.Status.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceInputNodeResult.DeviceInputNode.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceInputNodeResult.ExtendedError.get
	}
}
