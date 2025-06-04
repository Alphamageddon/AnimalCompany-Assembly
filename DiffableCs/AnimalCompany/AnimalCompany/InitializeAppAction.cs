namespace AnimalCompany;

public class InitializeAppAction : BaseAction
{
	private AppPlatform _platform; //Field offset: 0x14
	private string _clientVersion; //Field offset: 0x18
	private string _clientVersionSHA; //Field offset: 0x20
	private string _apiOrigin; //Field offset: 0x28
	private string _apiToken; //Field offset: 0x30

	public InitializeAppAction(AppPlatform platform, string clientVersion, string clientVersionSHA, string apiOrigin, string apiToken) { }

	public virtual void Execute(AppState state) { }

}

