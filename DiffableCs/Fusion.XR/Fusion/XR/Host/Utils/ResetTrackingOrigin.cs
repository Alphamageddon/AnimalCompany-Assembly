namespace Fusion.XR.Host.Utils;

public class ResetTrackingOrigin : MonoBehaviour
{
	internal enum Status
	{
		Unknown = 0,
		FixNotRequired = 1,
		FixRequiredHeadsetNotDetected = 2,
		FixBeingApplied = 3,
		FixFinished = 4,
	}

	public float fixDuration; //Field offset: 0x20
	private float fixElapsedTime; //Field offset: 0x24
	public List<String> unityVersionRequiringFixing; //Field offset: 0x28
	public InputActionProperty headsetAvailableAction; //Field offset: 0x30
	public Status status; //Field offset: 0x48

	public bool HeadsetDetected
	{
		 get { } //Length: 100
	}

	public ResetTrackingOrigin() { }

	private void Awake() { }

	private void FixfloorOrigin() { }

	public bool get_HeadsetDetected() { }

	private void Start() { }

	private void Update() { }

}

