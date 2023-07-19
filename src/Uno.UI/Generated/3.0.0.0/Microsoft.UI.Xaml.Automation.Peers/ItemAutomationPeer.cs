#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.AutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object ItemAutomationPeer.Item is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20ItemAutomationPeer.Item");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer ItemsControlAutomationPeer
		{
			get
			{
				throw new global::System.NotImplementedException("The member ItemsControlAutomationPeer ItemAutomationPeer.ItemsControlAutomationPeer is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ItemsControlAutomationPeer%20ItemAutomationPeer.ItemsControlAutomationPeer");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ItemAutomationPeer( object item,  global::Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer parent) : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer", "ItemAutomationPeer.ItemAutomationPeer(object item, ItemsControlAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer.ItemAutomationPeer(object, Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer)
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer.Item.get
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer.ItemsControlAutomationPeer.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Realize()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.ItemAutomationPeer", "void ItemAutomationPeer.Realize()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
	}
}
