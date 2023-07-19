#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ApplicationSettings
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CredentialCommand 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ApplicationSettings.CredentialCommandCredentialDeletedHandler CredentialDeleted
		{
			get
			{
				throw new global::System.NotImplementedException("The member CredentialCommandCredentialDeletedHandler CredentialCommand.CredentialDeleted is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CredentialCommandCredentialDeletedHandler%20CredentialCommand.CredentialDeleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Credentials.PasswordCredential PasswordCredential
		{
			get
			{
				throw new global::System.NotImplementedException("The member PasswordCredential CredentialCommand.PasswordCredential is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PasswordCredential%20CredentialCommand.PasswordCredential");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CredentialCommand( global::Windows.Security.Credentials.PasswordCredential passwordCredential) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ApplicationSettings.CredentialCommand", "CredentialCommand.CredentialCommand(PasswordCredential passwordCredential)");
		}
		#endif
		// Forced skipping of method Windows.UI.ApplicationSettings.CredentialCommand.CredentialCommand(Windows.Security.Credentials.PasswordCredential)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CredentialCommand( global::Windows.Security.Credentials.PasswordCredential passwordCredential,  global::Windows.UI.ApplicationSettings.CredentialCommandCredentialDeletedHandler deleted) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ApplicationSettings.CredentialCommand", "CredentialCommand.CredentialCommand(PasswordCredential passwordCredential, CredentialCommandCredentialDeletedHandler deleted)");
		}
		#endif
		// Forced skipping of method Windows.UI.ApplicationSettings.CredentialCommand.CredentialCommand(Windows.Security.Credentials.PasswordCredential, Windows.UI.ApplicationSettings.CredentialCommandCredentialDeletedHandler)
		// Forced skipping of method Windows.UI.ApplicationSettings.CredentialCommand.PasswordCredential.get
		// Forced skipping of method Windows.UI.ApplicationSettings.CredentialCommand.CredentialDeleted.get
	}
}
