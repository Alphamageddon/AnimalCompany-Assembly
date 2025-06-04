namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class ContinuousMoveProviderBase : LocomotionProvider
{
	internal enum GravityApplicationMode
	{
		AttemptingMove = 0,
		Immediately = 1,
	}

	[SerializeField]
	[Tooltip("The speed, in units per second, to move forward.")]
	private float m_MoveSpeed; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Controls whether to enable strafing (sideways movement).")]
	private bool m_EnableStrafe; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Controls whether to enable flying (unconstrained movement). This overrides the use of gravity.")]
	private bool m_EnableFly; //Field offset: 0x4D
	[SerializeField]
	[Tooltip("Controls whether gravity affects this provider when a Character Controller is used and flying is disabled.")]
	private bool m_UseGravity; //Field offset: 0x4E
	[SerializeField]
	[Tooltip("Controls when gravity begins to take effect.")]
	private GravityApplicationMode m_GravityApplicationMode; //Field offset: 0x50
	[SerializeField]
	[Tooltip("The source Transform to define the forward direction.")]
	private Transform m_ForwardSource; //Field offset: 0x58
	private CharacterController m_CharacterController; //Field offset: 0x60
	private bool m_AttemptedGetCharacterController; //Field offset: 0x68
	private bool m_IsMovingXROrigin; //Field offset: 0x69
	private Vector3 m_VerticalVelocity; //Field offset: 0x6C

	public bool enableFly
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableStrafe
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform forwardSource
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GravityApplicationMode gravityApplicationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float moveSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool useGravity
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	protected ContinuousMoveProviderBase() { }

	protected override Vector3 ComputeDesiredMove(Vector2 input) { }

	private void FindCharacterController() { }

	public bool get_enableFly() { }

	public bool get_enableStrafe() { }

	public Transform get_forwardSource() { }

	public GravityApplicationMode get_gravityApplicationMode() { }

	public float get_moveSpeed() { }

	public bool get_useGravity() { }

	protected override void MoveRig(Vector3 translationInWorldSpace) { }

	protected abstract Vector2 ReadInput() { }

	public void set_enableFly(bool value) { }

	public void set_enableStrafe(bool value) { }

	public void set_forwardSource(Transform value) { }

	public void set_gravityApplicationMode(GravityApplicationMode value) { }

	public void set_moveSpeed(float value) { }

	public void set_useGravity(bool value) { }

	protected void Update() { }

}

