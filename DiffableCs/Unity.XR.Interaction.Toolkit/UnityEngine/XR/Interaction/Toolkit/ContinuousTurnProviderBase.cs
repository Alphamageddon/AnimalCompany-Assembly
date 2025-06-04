namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class ContinuousTurnProviderBase : LocomotionProvider
{
	[SerializeField]
	[Tooltip("The number of degrees/second clockwise to rotate when turning clockwise.")]
	private float m_TurnSpeed; //Field offset: 0x48
	private bool m_IsTurningXROrigin; //Field offset: 0x4C

	public float turnSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected ContinuousTurnProviderBase() { }

	public float get_turnSpeed() { }

	protected override float GetTurnAmount(Vector2 input) { }

	protected abstract Vector2 ReadInput() { }

	public void set_turnSpeed(float value) { }

	protected void TurnRig(float turnAmount) { }

	protected void Update() { }

}

