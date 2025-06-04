namespace Fusion.XR.Host.Desktop;

public class RigSelection : MonoBehaviour
{
	internal enum Mode
	{
		SelectedByUI = 0,
		SelectedByUserPref = 1,
		ForceVR = 2,
		ForceDesktop = 3,
	}

	public const string RIGMODE_VR = "VR"; //Field offset: 0x0
	public const string RIGMODE_DESKTOP = "Desktop"; //Field offset: 0x0
	public const string SETTING_RIGMODE = "RigMode"; //Field offset: 0x0
	public UnityEvent OnSelectRig; //Field offset: 0x20
	public GameObject connexionHandler; //Field offset: 0x28
	public HardwareRig vrRig; //Field offset: 0x30
	public HardwareRig desktopRig; //Field offset: 0x38
	private Camera rigSelectionCamera; //Field offset: 0x40
	public bool forceVROnAndroid; //Field offset: 0x48
	public bool rigSelected; //Field offset: 0x49
	public Mode mode; //Field offset: 0x4C

	public RigSelection() { }

	private void Awake() { }

	protected override void DisableDebugSelectedByUI() { }

	private void EnableDesktopRig() { }

	private void EnableVRRig() { }

	protected override void OnGUI() { }

	private void OnRigSelected() { }

	[ContextMenu("Set preference to desktop")]
	public void SetDesktopPreference() { }

	[ContextMenu("Set preference to VR")]
	public void SetVRPreference() { }

}

