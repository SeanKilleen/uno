#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GridViewHeaderItemAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public GridViewHeaderItemAutomationPeer( global::Microsoft.UI.Xaml.Controls.GridViewHeaderItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.GridViewHeaderItemAutomationPeer", "GridViewHeaderItemAutomationPeer.GridViewHeaderItemAutomationPeer(GridViewHeaderItem owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.GridViewHeaderItemAutomationPeer.GridViewHeaderItemAutomationPeer(Microsoft.UI.Xaml.Controls.GridViewHeaderItem)
	}
}
