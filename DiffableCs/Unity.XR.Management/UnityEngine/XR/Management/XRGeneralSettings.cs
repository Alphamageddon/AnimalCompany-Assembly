namespace UnityEngine.XR.Management;

public class XRGeneralSettings : ScriptableObject
{
	public static string k_SettingsKey; //Field offset: 0x0
	internal static XRGeneralSettings s_RuntimeSettingsInstance; //Field offset: 0x8
	[SerializeField]
	internal XRManagerSettings m_LoaderManagerInstance; //Field offset: 0x18
	[SerializeField]
	[Tooltip("Toggling this on/off will enable/disable the automatic startup of XR at run time.")]
	internal bool m_InitManagerOnStart; //Field offset: 0x20
	private XRManagerSettings m_XRManager; //Field offset: 0x28
	private bool m_ProviderIntialized; //Field offset: 0x30
	private bool m_ProviderStarted; //Field offset: 0x31

	public XRManagerSettings AssignedSettings
	{
		 get { } //Length: 8
	}

	public bool InitManagerOnStart
	{
		 get { } //Length: 8
	}

	public static XRGeneralSettings Instance
	{
		 get { } //Length: 88
	}

	public XRManagerSettings Manager
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRGeneralSettings() { }

	public XRGeneralSettings() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterAssembliesLoaded (2))]
	internal static void AttemptInitializeXRSDKOnLoad() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSplashScreen (3))]
	internal static void AttemptStartXRSDKOnBeforeSplashScreen() { }

	private void Awake() { }

	private void DeInitXRSDK() { }

	public XRManagerSettings get_AssignedSettings() { }

	public bool get_InitManagerOnStart() { }

	public static XRGeneralSettings get_Instance() { }

	public XRManagerSettings get_Manager() { }

	private void InitXRSDK() { }

	private void OnDestroy() { }

	private static void Quit() { }

	public void set_Manager(XRManagerSettings value) { }

	private void Start() { }

	private void StartXRSDK() { }

	private void StopXRSDK() { }

}

