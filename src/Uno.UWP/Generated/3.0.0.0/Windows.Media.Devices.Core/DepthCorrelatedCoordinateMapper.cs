#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DepthCorrelatedCoordinateMapper : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 UnprojectPoint( global::Windows.Foundation.Point sourcePoint,  global::Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem)
		{
			throw new global::System.NotImplementedException("The member Vector3 DepthCorrelatedCoordinateMapper.UnprojectPoint(Point sourcePoint, SpatialCoordinateSystem targetCoordinateSystem) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Vector3%20DepthCorrelatedCoordinateMapper.UnprojectPoint%28Point%20sourcePoint%2C%20SpatialCoordinateSystem%20targetCoordinateSystem%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void UnprojectPoints( global::Windows.Foundation.Point[] sourcePoints,  global::Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem,  global::System.Numerics.Vector3[] results)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper", "void DepthCorrelatedCoordinateMapper.UnprojectPoints(Point[] sourcePoints, SpatialCoordinateSystem targetCoordinateSystem, Vector3[] results)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Point MapPoint( global::Windows.Foundation.Point sourcePoint,  global::Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem,  global::Windows.Media.Devices.Core.CameraIntrinsics targetCameraIntrinsics)
		{
			throw new global::System.NotImplementedException("The member Point DepthCorrelatedCoordinateMapper.MapPoint(Point sourcePoint, SpatialCoordinateSystem targetCoordinateSystem, CameraIntrinsics targetCameraIntrinsics) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Point%20DepthCorrelatedCoordinateMapper.MapPoint%28Point%20sourcePoint%2C%20SpatialCoordinateSystem%20targetCoordinateSystem%2C%20CameraIntrinsics%20targetCameraIntrinsics%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MapPoints( global::Windows.Foundation.Point[] sourcePoints,  global::Windows.Perception.Spatial.SpatialCoordinateSystem targetCoordinateSystem,  global::Windows.Media.Devices.Core.CameraIntrinsics targetCameraIntrinsics,  global::Windows.Foundation.Point[] results)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper", "void DepthCorrelatedCoordinateMapper.MapPoints(Point[] sourcePoints, SpatialCoordinateSystem targetCoordinateSystem, CameraIntrinsics targetCameraIntrinsics, Point[] results)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper", "void DepthCorrelatedCoordinateMapper.Dispose()");
		}
		#endif
		// Processing: System.IDisposable
	}
}
