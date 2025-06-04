namespace mixpanel;

public class MixpanelSettings : ScriptableObject
{
	private const string TrackUrlTemplate = "{0}track/?ip={1}"; //Field offset: 0x0
	private const string EngageUrlTemplate = "{0}engage/?ip={1}"; //Field offset: 0x0
	private static MixpanelSettings _instance; //Field offset: 0x0
	[Tooltip("If true will print helpful debugging messages")]
	public bool ShowDebug; //Field offset: 0x18
	[Tooltip("If true, you need to manually initialize the library")]
	public bool ManualInitialization; //Field offset: 0x19
	[Tooltip("The api host of where to send the requests to. Useful when you need to proxy all the request to somewhere else.'")]
	public string APIHostAddress; //Field offset: 0x20
	[Tooltip("The token of the Mixpanel project.")]
	public string RuntimeToken; //Field offset: 0x28
	[Tooltip("Used when the DEBUG compile flag is set or when in the editor. Useful if you want to use different tokens for test builds.")]
	public string DebugToken; //Field offset: 0x30
	[Tooltip("Seconds (in realtime) between sending data to the API Host.")]
	public float FlushInterval; //Field offset: 0x38
	[Tooltip("If true, the library will use the IP address of the client for geolocation. If false, the library will use the IP address of the Mixpanel server for geolocation.")]
	public bool UseIpAddressForGeolocation; //Field offset: 0x3C

	public static MixpanelSettings Instance
	{
		 get { } //Length: 76
	}

	internal string Token
	{
		internal get { } //Length: 8
	}

	public MixpanelSettings() { }

	public void ApplyToConfig() { }

	private static T CreateAndSave() { }

	private static MixpanelSettings FindOrCreateInstance() { }

	public static MixpanelSettings get_Instance() { }

	internal string get_Token() { }

	public static void LoadSettings() { }

}

