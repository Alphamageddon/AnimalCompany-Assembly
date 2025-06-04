namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class ConstrainedMoveProvider : LocomotionProvider
{
	internal enum GravityApplicationMode
	{
		AttemptingMove = 0,
		Immediately = 1,
	}

	[SerializeField]
	[Tooltip("Controls whether to enable unconstrained movement along the x-axis.")]
	private bool m_EnableFreeXMovement; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Controls whether to enable unconstrained movement along the y-axis.")]
	private bool m_EnableFreeYMovement; //Field offset: 0x49
	[SerializeField]
	[Tooltip("Controls whether to enable unconstrained movement along the z-axis.")]
	private bool m_EnableFreeZMovement; //Field offset: 0x4A
	[SerializeField]
	[Tooltip("Controls whether gravity applies to constrained axes when a Character Controller is used.")]
	private bool m_UseGravity; //Field offset: 0x4B
	[SerializeField]
	[Tooltip("Controls when gravity begins to take effect.")]
	private GravityApplicationMode m_GravityApplicationMode; //Field offset: 0x4C
	private CharacterController m_CharacterController; //Field offset: 0x50
	private bool m_AttemptedGetCharacterController; //Field offset: 0x58
	private bool m_IsMovingXROrigin; //Field offset: 0x59
	private Vector3 m_GravityDrivenVelocity; //Field offset: 0x5C

	public bool enableFreeXMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableFreeYMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableFreeZMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GravityApplicationMode gravityMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool useGravity
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	protected ConstrainedMoveProvider() { }

	protected abstract Vector3 ComputeDesiredMove(out bool attemptingMove) { }

	private void FindCharacterController() { }

	public bool get_enableFreeXMovement() { }

	public bool get_enableFreeYMovement() { }

	public bool get_enableFreeZMovement() { }

	public GravityApplicationMode get_gravityMode() { }

	public bool get_useGravity() { }

	protected override void MoveRig(Vector3 translationInWorldSpace) { }

	public void set_enableFreeXMovement(bool value) { }

	public void set_enableFreeYMovement(bool value) { }

	public void set_enableFreeZMovement(bool value) { }

	public void set_gravityMode(GravityApplicationMode value) { }

	public void set_useGravity(bool value) { }

	protected void Update() { }

}

