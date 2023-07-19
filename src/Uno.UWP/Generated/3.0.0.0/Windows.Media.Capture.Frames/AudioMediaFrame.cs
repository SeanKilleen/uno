#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Frames
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioMediaFrame 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.MediaProperties.AudioEncodingProperties AudioEncodingProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioEncodingProperties AudioMediaFrame.AudioEncodingProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioEncodingProperties%20AudioMediaFrame.AudioEncodingProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Capture.Frames.MediaFrameReference FrameReference
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaFrameReference AudioMediaFrame.FrameReference is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaFrameReference%20AudioMediaFrame.FrameReference");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.Frames.AudioMediaFrame.FrameReference.get
		// Forced skipping of method Windows.Media.Capture.Frames.AudioMediaFrame.AudioEncodingProperties.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.AudioFrame GetAudioFrame()
		{
			throw new global::System.NotImplementedException("The member AudioFrame AudioMediaFrame.GetAudioFrame() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioFrame%20AudioMediaFrame.GetAudioFrame%28%29");
		}
		#endif
	}
}
