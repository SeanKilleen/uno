#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateAudioFileOutputNodeResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioFileOutputNode FileOutputNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioFileOutputNode CreateAudioFileOutputNodeResult.FileOutputNode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioFileOutputNode%20CreateAudioFileOutputNodeResult.FileOutputNode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioFileNodeCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioFileNodeCreationStatus CreateAudioFileOutputNodeResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioFileNodeCreationStatus%20CreateAudioFileOutputNodeResult.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception CreateAudioFileOutputNodeResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20CreateAudioFileOutputNodeResult.ExtendedError");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.Status.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.FileOutputNode.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioFileOutputNodeResult.ExtendedError.get
	}
}
