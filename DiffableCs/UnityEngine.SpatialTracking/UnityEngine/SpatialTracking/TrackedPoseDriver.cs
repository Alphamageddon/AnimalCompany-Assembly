namespace UnityEngine.SpatialTracking;

[AddComponentMenu("XR/Tracked Pose Driver")]
[DefaultExecutionOrder(-30000)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.legacyinputhelpers@2.1/manual/index.html")]
public class TrackedPoseDriver : MonoBehaviour
{
	internal enum DeviceType
	{
		GenericXRDevice = 0,
		GenericXRController = 1,
		GenericXRRemote = 2,
	}

	internal enum TrackedPose
	{
		LeftEye = 0,
		RightEye = 1,
		Center = 2,
		Head = 3,
		LeftPose = 4,
		RightPose = 5,
		ColorCamera = 6,
		DepthCameraDeprecated = 7,
		FisheyeCameraDeprected = 8,
		DeviceDeprecated = 9,
		RemotePose = 10,
	}

	internal enum TrackingType
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2,
	}

	internal enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2,
	}

	[SerializeField]
	private DeviceType m_Device; //Field offset: 0x20
	[SerializeField]
	private TrackedPose m_PoseSource; //Field offset: 0x24
	[SerializeField]
	private BasePoseProvider m_PoseProviderComponent; //Field offset: 0x28
	[SerializeField]
	private TrackingType m_TrackingType; //Field offset: 0x30
	[SerializeField]
	private UpdateType m_UpdateType; //Field offset: 0x34
	[SerializeField]
	private bool m_UseRelativeTransform; //Field offset: 0x38
	protected Pose m_OriginPose; //Field offset: 0x3C

	public internal DeviceType deviceType
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public Pose originPose
	{
		 get { } //Length: 20
		 set { } //Length: 28
	}

	public BasePoseProvider poseProviderComponent
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public internal TrackedPose poseSource
	{
		 get { } //Length: 8
		internal set { } //Length: 8
	}

	public TrackingType trackingType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UpdateType updateType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool UseRelativeTransform
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public TrackedPoseDriver() { }

	protected override void Awake() { }

	private void CacheLocalPosition() { }

	protected override void FixedUpdate() { }

	public DeviceType get_deviceType() { }

	public Pose get_originPose() { }

	public BasePoseProvider get_poseProviderComponent() { }

	public TrackedPose get_poseSource() { }

	public TrackingType get_trackingType() { }

	public UpdateType get_updateType() { }

	public bool get_UseRelativeTransform() { }

	private PoseDataFlags GetPoseData(DeviceType device, TrackedPose poseSource, out Pose resultPose) { }

	private bool HasStereoCamera() { }

	[BeforeRenderOrder(-30000)]
	protected override void OnBeforeRender() { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void PerformUpdate() { }

	private void ResetToCachedLocalPosition() { }

	internal void set_deviceType(DeviceType value) { }

	public void set_originPose(Pose value) { }

	public void set_poseProviderComponent(BasePoseProvider value) { }

	internal void set_poseSource(TrackedPose value) { }

	public void set_trackingType(TrackingType value) { }

	public void set_updateType(UpdateType value) { }

	public void set_UseRelativeTransform(bool value) { }

	protected override void SetLocalTransform(Vector3 newPosition, Quaternion newRotation, PoseDataFlags poseFlags) { }

	public bool SetPoseSource(DeviceType deviceType, TrackedPose pose) { }

	protected Pose TransformPoseByOriginIfNeeded(Pose pose) { }

	protected override void Update() { }

}

