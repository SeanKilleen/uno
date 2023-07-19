#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if false || false || IS_UNIT_TESTS || false || false || false || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS")]
	#endif
	public  partial class ConnectionProfile 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter
		{
			get
			{
				throw new global::System.NotImplementedException("The member NetworkAdapter ConnectionProfile.NetworkAdapter is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=NetworkAdapter%20ConnectionProfile.NetworkAdapter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.NetworkSecuritySettings NetworkSecuritySettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member NetworkSecuritySettings ConnectionProfile.NetworkSecuritySettings is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=NetworkSecuritySettings%20ConnectionProfile.NetworkSecuritySettings");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ProfileName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ConnectionProfile.ProfileName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ConnectionProfile.ProfileName");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__")]
		public  bool IsWlanConnectionProfile
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ConnectionProfile.IsWlanConnectionProfile is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ConnectionProfile.IsWlanConnectionProfile");
			}
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__")]
		public  bool IsWwanConnectionProfile
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ConnectionProfile.IsWwanConnectionProfile is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ConnectionProfile.IsWwanConnectionProfile");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid? ServiceProviderGuid
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid? ConnectionProfile.ServiceProviderGuid is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%3F%20ConnectionProfile.ServiceProviderGuid");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.WlanConnectionProfileDetails WlanConnectionProfileDetails
		{
			get
			{
				throw new global::System.NotImplementedException("The member WlanConnectionProfileDetails ConnectionProfile.WlanConnectionProfileDetails is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WlanConnectionProfileDetails%20ConnectionProfile.WlanConnectionProfileDetails");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.WwanConnectionProfileDetails WwanConnectionProfileDetails
		{
			get
			{
				throw new global::System.NotImplementedException("The member WwanConnectionProfileDetails ConnectionProfile.WwanConnectionProfileDetails is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WwanConnectionProfileDetails%20ConnectionProfile.WwanConnectionProfileDetails");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanDelete
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ConnectionProfile.CanDelete is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ConnectionProfile.CanDelete");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.ProfileName.get
		#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public  global::Windows.Networking.Connectivity.NetworkConnectivityLevel GetNetworkConnectivityLevel()
		{
			throw new global::System.NotImplementedException("The member NetworkConnectivityLevel ConnectionProfile.GetNetworkConnectivityLevel() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=NetworkConnectivityLevel%20ConnectionProfile.GetNetworkConnectivityLevel%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> GetNetworkNames()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<string> ConnectionProfile.GetNetworkNames() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20ConnectionProfile.GetNetworkNames%28%29");
		}
		#endif
		#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.ConnectionCost GetConnectionCost()
		{
			throw new global::System.NotImplementedException("The member ConnectionCost ConnectionProfile.GetConnectionCost() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ConnectionCost%20ConnectionProfile.GetConnectionCost%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.DataPlanStatus GetDataPlanStatus()
		{
			throw new global::System.NotImplementedException("The member DataPlanStatus ConnectionProfile.GetDataPlanStatus() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DataPlanStatus%20ConnectionProfile.GetDataPlanStatus%28%29");
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.NetworkAdapter.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.DataUsage GetLocalUsage( global::System.DateTimeOffset StartTime,  global::System.DateTimeOffset EndTime)
		{
			throw new global::System.NotImplementedException("The member DataUsage ConnectionProfile.GetLocalUsage(DateTimeOffset StartTime, DateTimeOffset EndTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DataUsage%20ConnectionProfile.GetLocalUsage%28DateTimeOffset%20StartTime%2C%20DateTimeOffset%20EndTime%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.DataUsage GetLocalUsage( global::System.DateTimeOffset StartTime,  global::System.DateTimeOffset EndTime,  global::Windows.Networking.Connectivity.RoamingStates States)
		{
			throw new global::System.NotImplementedException("The member DataUsage ConnectionProfile.GetLocalUsage(DateTimeOffset StartTime, DateTimeOffset EndTime, RoamingStates States) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DataUsage%20ConnectionProfile.GetLocalUsage%28DateTimeOffset%20StartTime%2C%20DateTimeOffset%20EndTime%2C%20RoamingStates%20States%29");
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.NetworkSecuritySettings.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.IsWwanConnectionProfile.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.IsWlanConnectionProfile.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.WwanConnectionProfileDetails.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.WlanConnectionProfileDetails.get
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.ServiceProviderGuid.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte? GetSignalBars()
		{
			throw new global::System.NotImplementedException("The member byte? ConnectionProfile.GetSignalBars() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%3F%20ConnectionProfile.GetSignalBars%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Connectivity.DomainConnectivityLevel GetDomainConnectivityLevel()
		{
			throw new global::System.NotImplementedException("The member DomainConnectivityLevel ConnectionProfile.GetDomainConnectivityLevel() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DomainConnectivityLevel%20ConnectionProfile.GetDomainConnectivityLevel%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.NetworkUsage>> GetNetworkUsageAsync( global::System.DateTimeOffset startTime,  global::System.DateTimeOffset endTime,  global::Windows.Networking.Connectivity.DataUsageGranularity granularity,  global::Windows.Networking.Connectivity.NetworkUsageStates states)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<NetworkUsage>> ConnectionProfile.GetNetworkUsageAsync(DateTimeOffset startTime, DateTimeOffset endTime, DataUsageGranularity granularity, NetworkUsageStates states) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CNetworkUsage%3E%3E%20ConnectionProfile.GetNetworkUsageAsync%28DateTimeOffset%20startTime%2C%20DateTimeOffset%20endTime%2C%20DataUsageGranularity%20granularity%2C%20NetworkUsageStates%20states%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.ConnectivityInterval>> GetConnectivityIntervalsAsync( global::System.DateTimeOffset startTime,  global::System.DateTimeOffset endTime,  global::Windows.Networking.Connectivity.NetworkUsageStates states)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ConnectivityInterval>> ConnectionProfile.GetConnectivityIntervalsAsync(DateTimeOffset startTime, DateTimeOffset endTime, NetworkUsageStates states) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CConnectivityInterval%3E%3E%20ConnectionProfile.GetConnectivityIntervalsAsync%28DateTimeOffset%20startTime%2C%20DateTimeOffset%20endTime%2C%20NetworkUsageStates%20states%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.AttributedNetworkUsage>> GetAttributedNetworkUsageAsync( global::System.DateTimeOffset startTime,  global::System.DateTimeOffset endTime,  global::Windows.Networking.Connectivity.NetworkUsageStates states)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<AttributedNetworkUsage>> ConnectionProfile.GetAttributedNetworkUsageAsync(DateTimeOffset startTime, DateTimeOffset endTime, NetworkUsageStates states) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CAttributedNetworkUsage%3E%3E%20ConnectionProfile.GetAttributedNetworkUsageAsync%28DateTimeOffset%20startTime%2C%20DateTimeOffset%20endTime%2C%20NetworkUsageStates%20states%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Connectivity.ProviderNetworkUsage>> GetProviderNetworkUsageAsync( global::System.DateTimeOffset startTime,  global::System.DateTimeOffset endTime,  global::Windows.Networking.Connectivity.NetworkUsageStates states)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ProviderNetworkUsage>> ConnectionProfile.GetProviderNetworkUsageAsync(DateTimeOffset startTime, DateTimeOffset endTime, NetworkUsageStates states) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CProviderNetworkUsage%3E%3E%20ConnectionProfile.GetProviderNetworkUsageAsync%28DateTimeOffset%20startTime%2C%20DateTimeOffset%20endTime%2C%20NetworkUsageStates%20states%29");
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.ConnectionProfile.CanDelete.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Connectivity.ConnectionProfileDeleteStatus> TryDeleteAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ConnectionProfileDeleteStatus> ConnectionProfile.TryDeleteAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CConnectionProfileDeleteStatus%3E%20ConnectionProfile.TryDeleteAsync%28%29");
		}
		#endif
	}
}
