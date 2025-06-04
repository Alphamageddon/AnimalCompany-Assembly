namespace Fusion;

[ExecuteAlways]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Olive (9))]
public class FusionBasicBillboard : Behaviour
{
	private static float _lastCameraFindTime; //Field offset: 0x0
	private static Camera _currentCam; //Field offset: 0x8
	[InlineHelp]
	public Camera Camera; //Field offset: 0x20

	private Camera MainCamera
	{
		private get { } //Length: 120
		private set { } //Length: 76
	}

	public FusionBasicBillboard() { }

	private Camera get_MainCamera() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void ResetStatics() { }

	private void set_MainCamera(Camera value) { }

	public void UpdateLookAt() { }

}

