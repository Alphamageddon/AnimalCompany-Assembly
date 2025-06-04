namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class SnapTurnProviderBase : LocomotionProvider
{
	[SerializeField]
	[Tooltip("The number of degrees clockwise to rotate when snap turning clockwise.")]
	private float m_TurnAmount; //Field offset: 0x48
	[SerializeField]
	[Tooltip("The amount of time that the system will wait before starting another snap turn.")]
	private float m_DebounceTime; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Controls whether to enable left & right snap turns.")]
	private bool m_EnableTurnLeftRight; //Field offset: 0x50
	[SerializeField]
	[Tooltip("Controls whether to enable 180° snap turns.")]
	private bool m_EnableTurnAround; //Field offset: 0x51
	[SerializeField]
	[Tooltip("The time (in seconds) to delay the first turn after receiving initial input for the turn.")]
	private float m_DelayTime; //Field offset: 0x54
	private float m_CurrentTurnAmount; //Field offset: 0x58
	private float m_TimeStarted; //Field offset: 0x5C
	private float m_DelayStartTime; //Field offset: 0x60

	public float debounceTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float delayTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool enableTurnAround
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableTurnLeftRight
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float turnAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected SnapTurnProviderBase() { }

	protected virtual void Awake() { }

	internal void FakeStartTurn(bool isLeft) { }

	internal void FakeStartTurnAround() { }

	public float get_debounceTime() { }

	public float get_delayTime() { }

	public bool get_enableTurnAround() { }

	public bool get_enableTurnLeftRight() { }

	public float get_turnAmount() { }

	protected override float GetTurnAmount(Vector2 input) { }

	protected abstract Vector2 ReadInput() { }

	public void set_debounceTime(float value) { }

	public void set_delayTime(float value) { }

	public void set_enableTurnAround(bool value) { }

	public void set_enableTurnLeftRight(bool value) { }

	public void set_turnAmount(float value) { }

	protected void StartTurn(float amount) { }

	protected void Update() { }

}

