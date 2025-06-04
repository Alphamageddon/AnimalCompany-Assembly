namespace UnityEngine.XR.Interaction.Toolkit;

public struct InteractionState
{
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; //Field offset: 0x0
	[SerializeField]
	private bool m_Active; //Field offset: 0x4
	private bool m_ActivatedThisFrame; //Field offset: 0x5
	private bool m_DeactivatedThisFrame; //Field offset: 0x6

	public bool activatedThisFrame
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool active
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool deactivatedThisFrame
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("deActivatedThisFrame has been deprecated. Use deactivatedThisFrame instead. (UnityUpgradable) -> deactivatedThisFrame")]
	public bool deActivatedThisFrame
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float value
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool get_activatedThisFrame() { }

	public bool get_active() { }

	public bool get_deactivatedThisFrame() { }

	public bool get_deActivatedThisFrame() { }

	public float get_value() { }

	[Obsolete("Reset has been renamed. Use ResetFrameDependent instead. (UnityUpgradable) -> ResetFrameDependent()")]
	public void Reset() { }

	public void ResetFrameDependent() { }

	public void set_activatedThisFrame(bool value) { }

	public void set_active(bool value) { }

	public void set_deactivatedThisFrame(bool value) { }

	public void set_deActivatedThisFrame(bool value) { }

	public void set_value(float value) { }

	public void SetFrameDependent(bool wasActive) { }

	public void SetFrameState(bool isActive) { }

	public void SetFrameState(bool isActive, float newValue) { }

}

