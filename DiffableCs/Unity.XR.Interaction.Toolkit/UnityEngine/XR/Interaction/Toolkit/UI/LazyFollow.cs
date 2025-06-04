namespace UnityEngine.XR.Interaction.Toolkit.UI;

[AddComponentMenu("XR/Lazy Follow", 22)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.LazyFollow.html")]
public class LazyFollow : MonoBehaviour
{
	internal enum PositionFollowMode
	{
		None = 0,
		Follow = 1,
	}

	internal enum RotationFollowMode
	{
		None = 0,
		LookAt = 1,
		LookAtWithWorldUp = 2,
		Follow = 3,
	}

	private const float k_LowerSpeedVariance = 0; //Field offset: 0x0
	private const float k_UpperSpeedVariance = 0.999; //Field offset: 0x0
	[Header("Target Config")]
	[SerializeField]
	[Tooltip("(Optional) The object being followed. If not set, this will default to the main camera when this component is enabled.")]
	private Transform m_Target; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The amount to offset the target's position when following. This position is relative/local to the target object.")]
	private Vector3 m_TargetOffset; //Field offset: 0x28
	[SerializeField]
	[Space]
	[Tooltip("If true, read the local transform of the target to lazy follow, otherwise read the world transform. If using look at rotation follow modes, only world-space follow is supported.")]
	private bool m_FollowInLocalSpace; //Field offset: 0x34
	[SerializeField]
	[Tooltip("If true, apply the target offset in local space. If false, apply the target offset in world space.")]
	private bool m_ApplyTargetInLocalSpace; //Field offset: 0x35
	[Header("General Follow Params")]
	[SerializeField]
	[Tooltip("Movement speed used when smoothing to new target. Lower values mean the lazy follow lags further behind the target.")]
	private float m_MovementSpeed; //Field offset: 0x38
	[Range(0, 0.999)]
	[SerializeField]
	[Tooltip("Adjust movement speed based on distance from the target using a tolerance percentage. 0% for constant speed.")]
	private float m_MovementSpeedVariancePercentage; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("Snap to target position when this component is enabled.")]
	private bool m_SnapOnEnable; //Field offset: 0x40
	[Header("Position Follow Params")]
	[SerializeField]
	[Tooltip("Determines the follow mode used to determine a new rotation. Look At is best used with the target being the main camera.")]
	private PositionFollowMode m_PositionFollowMode; //Field offset: 0x44
	[SerializeField]
	[Tooltip("Minimum distance from target before which a follow lazy follow starts.")]
	private float m_MinDistanceAllowed; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Maximum distance from target before lazy follow targets, when time threshold is reached.")]
	private float m_MaxDistanceAllowed; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Time required to elapse (in seconds) before the max distance allowed goes from the min distance to the max.")]
	private float m_TimeUntilThresholdReachesMaxDistance; //Field offset: 0x50
	[Header("Rotation Follow Params")]
	[SerializeField]
	[Tooltip("Determines the follow mode used to determine a new rotation. Look At is best used with the target being the main camera.")]
	private RotationFollowMode m_RotationFollowMode; //Field offset: 0x54
	[SerializeField]
	[Tooltip("Minimum angle offset (in degrees) from target before which lazy follow starts.")]
	private float m_MinAngleAllowed; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Maximum angle offset (in degrees) from target before lazy follow targets, when time threshold is reached.")]
	private float m_MaxAngleAllowed; //Field offset: 0x5C
	[SerializeField]
	[Tooltip("Time required to elapse (in seconds) before the max angle offset allowed goes from the min angle offset to the max.")]
	private float m_TimeUntilThresholdReachesMaxAngle; //Field offset: 0x60
	private float m_LowerMovementSpeed; //Field offset: 0x64
	private float m_UpperMovementSpeed; //Field offset: 0x68
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x70
	private SmartFollowVector3TweenableVariable m_Vector3TweenableVariable; //Field offset: 0x78
	private SmartFollowQuaternionTweenableVariable m_QuaternionTweenableVariable; //Field offset: 0x80

	public bool applyTargetInLocalSpace
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool followInLocalSpace
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float maxAngleAllowed
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public float maxDistanceAllowed
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float minAngleAllowed
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public float minDistanceAllowed
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public float movementSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 48
	}

	public float movementSpeedVariancePercentage
	{
		 get { } //Length: 8
		 set { } //Length: 72
	}

	public PositionFollowMode positionFollowMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public RotationFollowMode rotationFollowMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool snapOnEnable
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform target
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 targetOffset
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public float timeUntilThresholdReachesMaxAngle
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public float timeUntilThresholdReachesMaxDistance
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public LazyFollow() { }

	protected void Awake() { }

	public bool get_applyTargetInLocalSpace() { }

	public bool get_followInLocalSpace() { }

	public float get_maxAngleAllowed() { }

	public float get_maxDistanceAllowed() { }

	public float get_minAngleAllowed() { }

	public float get_minDistanceAllowed() { }

	public float get_movementSpeed() { }

	public float get_movementSpeedVariancePercentage() { }

	public PositionFollowMode get_positionFollowMode() { }

	public RotationFollowMode get_rotationFollowMode() { }

	public bool get_snapOnEnable() { }

	public Transform get_target() { }

	public Vector3 get_targetOffset() { }

	public float get_timeUntilThresholdReachesMaxAngle() { }

	public float get_timeUntilThresholdReachesMaxDistance() { }

	protected void LateUpdate() { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected void OnValidate() { }

	public void set_applyTargetInLocalSpace(bool value) { }

	public void set_followInLocalSpace(bool value) { }

	public void set_maxAngleAllowed(float value) { }

	public void set_maxDistanceAllowed(float value) { }

	public void set_minAngleAllowed(float value) { }

	public void set_minDistanceAllowed(float value) { }

	public void set_movementSpeed(float value) { }

	public void set_movementSpeedVariancePercentage(float value) { }

	public void set_positionFollowMode(PositionFollowMode value) { }

	public void set_rotationFollowMode(RotationFollowMode value) { }

	public void set_snapOnEnable(bool value) { }

	public void set_target(Transform value) { }

	public void set_targetOffset(Vector3 value) { }

	public void set_timeUntilThresholdReachesMaxAngle(float value) { }

	public void set_timeUntilThresholdReachesMaxDistance(float value) { }

	protected override bool TryGetThresholdTargetPosition(out Vector3 newTarget) { }

	protected override bool TryGetThresholdTargetRotation(out Quaternion newTarget) { }

	private void UpdatePosition(float3 position) { }

	private void UpdateRotation(Quaternion rotation) { }

	private void UpdateUpperAndLowerSpeedBounds() { }

	private void ValidateFollowMode() { }

}

