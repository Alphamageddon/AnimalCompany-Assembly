namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRRig.html")]
[Obsolete("XRRig has been deprecated. Use the XROrigin component instead.")]
public class XRRig : XROrigin
{
	[SerializeField]
	private GameObject m_CameraGameObject; //Field offset: 0x58

	[Obsolete("cameraFloorOffsetObject has been deprecated. Use CameraFloorOffsetObject instead.")]
	public GameObject cameraFloorOffsetObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("cameraGameObject has been deprecated. Use Camera instead for similar functionality.")]
	public GameObject cameraGameObject
	{
		 get { } //Length: 8
		 set { } //Length: 168
	}

	[Obsolete("cameraInRigSpaceHeight has been deprecated. Use CameraInOriginSpaceHeight instead.")]
	public float cameraInRigSpaceHeight
	{
		 get { } //Length: 8
	}

	[Obsolete("cameraInRigSpacePos has been deprecated. Use CameraInOriginSpacePos instead.")]
	public Vector3 cameraInRigSpacePos
	{
		 get { } //Length: 8
	}

	[Obsolete("cameraYOffset has been deprecated. Use CameraYOffset instead.")]
	public float cameraYOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("currentTrackingOriginMode has been deprecated. Use CurrentTrackingOriginMode instead.")]
	public TrackingOriginModeFlags currentTrackingOriginMode
	{
		 get { } //Length: 8
	}

	[Obsolete("requestedTrackingOriginMode has been deprecated. Use RequestedTrackingOriginMode instead.")]
	public TrackingOriginMode requestedTrackingOriginMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("rig has been deprecated. Use Origin instead.")]
	public GameObject rig
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("rigInCameraSpacePos has been deprecated. Use OriginInCameraSpacePos instead.")]
	public Vector3 rigInCameraSpacePos
	{
		 get { } //Length: 8
	}

	public XRRig() { }

	protected void Awake() { }

	public GameObject get_cameraFloorOffsetObject() { }

	public GameObject get_cameraGameObject() { }

	public float get_cameraInRigSpaceHeight() { }

	public Vector3 get_cameraInRigSpacePos() { }

	public float get_cameraYOffset() { }

	public TrackingOriginModeFlags get_currentTrackingOriginMode() { }

	public TrackingOriginMode get_requestedTrackingOriginMode() { }

	public GameObject get_rig() { }

	public Vector3 get_rigInCameraSpacePos() { }

	[Obsolete("MatchRigUp has been deprecated. Use MatchOriginUp instead.")]
	public bool MatchRigUp(Vector3 destinationUp) { }

	[Obsolete("MatchRigUpCameraForward has been deprecated. Use MatchOriginUpCameraForward instead.")]
	public bool MatchRigUpCameraForward(Vector3 destinationUp, Vector3 destinationForward) { }

	[Obsolete("MatchRigUpRigForward has been deprecated. Use MatchOriginUpOriginForward instead.")]
	public bool MatchRigUpRigForward(Vector3 destinationUp, Vector3 destinationForward) { }

	[Obsolete("RotateAroundCameraUsingRigUp has been deprecated. Use RotateAroundCameraUsingOriginUp instead.")]
	public bool RotateAroundCameraUsingRigUp(float angleDegrees) { }

	public void set_cameraFloorOffsetObject(GameObject value) { }

	public void set_cameraGameObject(GameObject value) { }

	public void set_cameraYOffset(float value) { }

	public void set_requestedTrackingOriginMode(TrackingOriginMode value) { }

	public void set_rig(GameObject value) { }

}

