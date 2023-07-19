#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HttpContentCodingHeaderValue : global::Windows.Foundation.IStringable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ContentCoding
		{
			get
			{
				throw new global::System.NotImplementedException("The member string HttpContentCodingHeaderValue.ContentCoding is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpContentCodingHeaderValue.ContentCoding");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public HttpContentCodingHeaderValue( string contentCoding) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Web.Http.Headers.HttpContentCodingHeaderValue", "HttpContentCodingHeaderValue.HttpContentCodingHeaderValue(string contentCoding)");
		}
		#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpContentCodingHeaderValue.HttpContentCodingHeaderValue(string)
		// Forced skipping of method Windows.Web.Http.Headers.HttpContentCodingHeaderValue.ContentCoding.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpContentCodingHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20HttpContentCodingHeaderValue.ToString%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpContentCodingHeaderValue Parse( string input)
		{
			throw new global::System.NotImplementedException("The member HttpContentCodingHeaderValue HttpContentCodingHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HttpContentCodingHeaderValue%20HttpContentCodingHeaderValue.Parse%28string%20input%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( string input, out global::Windows.Web.Http.Headers.HttpContentCodingHeaderValue contentCodingHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpContentCodingHeaderValue.TryParse(string input, out HttpContentCodingHeaderValue contentCodingHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HttpContentCodingHeaderValue.TryParse%28string%20input%2C%20out%20HttpContentCodingHeaderValue%20contentCodingHeaderValue%29");
		}
		#endif
	}
}
