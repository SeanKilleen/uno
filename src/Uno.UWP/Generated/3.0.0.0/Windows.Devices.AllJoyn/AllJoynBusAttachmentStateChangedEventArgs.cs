#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynBusAttachmentStateChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.AllJoyn.AllJoynBusAttachmentState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member AllJoynBusAttachmentState AllJoynBusAttachmentStateChangedEventArgs.State is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AllJoynBusAttachmentState%20AllJoynBusAttachmentStateChangedEventArgs.State");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member int AllJoynBusAttachmentStateChangedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20AllJoynBusAttachmentStateChangedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs.State.get
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs.Status.get
	}
}
