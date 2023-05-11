﻿using System.Net.Http;
using Microsoft.Identity.Client;

namespace Uno.UI.MSAL
{
	internal class WasmHttpFactory : IMsalHttpClientFactory
	{
		public static readonly WasmHttpFactory Instance = new WasmHttpFactory();

		public HttpClient GetHttpClient() => new HttpClient();
	}
}
