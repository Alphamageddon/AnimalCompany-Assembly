namespace Fusion.XR.Host.Utils;

public class HideForLocalUser : NetworkBehaviour
{
	public string localUserLayer; //Field offset: 0x80
	public string remoteUserLayer; //Field offset: 0x88
	public bool hideLocalAvatar; //Field offset: 0x90
	public bool applyLayerToChildren; //Field offset: 0x91
	private HardwareRig rig; //Field offset: 0x98

	public HideForLocalUser() { }

	private void Awake() { }

	private void ConfigureCamera() { }

	public void ConfigureLocalRenderers() { }

	public void ConfigureRemoteRenderers() { }

	public virtual void Spawned() { }

	private void Start() { }

}

