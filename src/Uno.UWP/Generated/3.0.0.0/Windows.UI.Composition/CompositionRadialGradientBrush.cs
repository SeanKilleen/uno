#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionRadialGradientBrush : global::Windows.UI.Composition.CompositionGradientBrush
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 GradientOriginOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRadialGradientBrush.GradientOriginOffset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRadialGradientBrush", "Vector2 CompositionRadialGradientBrush.GradientOriginOffset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 EllipseRadius
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRadialGradientBrush.EllipseRadius is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRadialGradientBrush", "Vector2 CompositionRadialGradientBrush.EllipseRadius");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Numerics.Vector2 EllipseCenter
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionRadialGradientBrush.EllipseCenter is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionRadialGradientBrush", "Vector2 CompositionRadialGradientBrush.EllipseCenter");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.EllipseCenter.get
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.EllipseCenter.set
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.EllipseRadius.get
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.EllipseRadius.set
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.GradientOriginOffset.get
		// Forced skipping of method Windows.UI.Composition.CompositionRadialGradientBrush.GradientOriginOffset.set
	}
}
