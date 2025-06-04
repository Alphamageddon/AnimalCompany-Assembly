namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Two-Handed Grab Move Provider", 11)]
[DefaultExecutionOrder(-209)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.TwoHandedGrabMoveProvider.html")]
public class TwoHandedGrabMoveProvider : ConstrainedMoveProvider
{
	[SerializeField]
	[Tooltip("The left hand grab move instance which will be used as one half of two-handed locomotion.")]
	private GrabMoveProvider m_LeftGrabMoveProvider; //Field offset: 0x68
	[SerializeField]
	[Tooltip("The right hand grab move instance which will be used as one half of two-handed locomotion.")]
	private GrabMoveProvider m_RightGrabMoveProvider; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Controls whether to override the settings for individual handed providers with this provider's settings on initialization.")]
	private bool m_OverrideSharedSettingsOnInit; //Field offset: 0x78
	[SerializeField]
	[Tooltip("The ratio of actual movement distance to controller movement distance.")]
	private float m_MoveFactor; //Field offset: 0x7C
	[SerializeField]
	[Tooltip("Controls whether translation requires both grab move inputs to be active.")]
	private bool m_RequireTwoHandsForTranslation; //Field offset: 0x80
	[SerializeField]
	[Tooltip("Controls whether to enable yaw rotation of the user.")]
	private bool m_EnableRotation; //Field offset: 0x81
	[SerializeField]
	[Tooltip("Controls whether to enable uniform scaling of the user.")]
	private bool m_EnableScaling; //Field offset: 0x82
	[SerializeField]
	[Tooltip("The minimum user scale allowed.")]
	private float m_MinimumScale; //Field offset: 0x84
	[SerializeField]
	[Tooltip("The maximum user scale allowed.")]
	private float m_MaximumScale; //Field offset: 0x88
	private bool m_IsMoving; //Field offset: 0x8C
	private Vector3 m_PreviousMidpointBetweenControllers; //Field offset: 0x90
	private float m_InitialOriginYaw; //Field offset: 0x9C
	private Vector3 m_InitialLeftToRightDirection; //Field offset: 0xA0
	private Vector3 m_InitialLeftToRightOrthogonal; //Field offset: 0xAC
	private float m_InitialOriginScale; //Field offset: 0xB8
	private float m_InitialDistanceBetweenHands; //Field offset: 0xBC

	public bool enableRotation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GrabMoveProvider leftGrabMoveProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maximumScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float minimumScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float moveFactor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool overrideSharedSettingsOnInit
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool requireTwoHandsForTranslation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GrabMoveProvider rightGrabMoveProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TwoHandedGrabMoveProvider() { }

	protected virtual Vector3 ComputeDesiredMove(out bool attemptingMove) { }

	public bool get_enableRotation() { }

	public bool get_enableScaling() { }

	public GrabMoveProvider get_leftGrabMoveProvider() { }

	public float get_maximumScale() { }

	public float get_minimumScale() { }

	public float get_moveFactor() { }

	public bool get_overrideSharedSettingsOnInit() { }

	public bool get_requireTwoHandsForTranslation() { }

	public GrabMoveProvider get_rightGrabMoveProvider() { }

	private void OnBeginLocomotion(LocomotionSystem otherSystem) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_enableRotation(bool value) { }

	public void set_enableScaling(bool value) { }

	public void set_leftGrabMoveProvider(GrabMoveProvider value) { }

	public void set_maximumScale(float value) { }

	public void set_minimumScale(float value) { }

	public void set_moveFactor(float value) { }

	public void set_overrideSharedSettingsOnInit(bool value) { }

	public void set_requireTwoHandsForTranslation(bool value) { }

	public void set_rightGrabMoveProvider(GrabMoveProvider value) { }

}

