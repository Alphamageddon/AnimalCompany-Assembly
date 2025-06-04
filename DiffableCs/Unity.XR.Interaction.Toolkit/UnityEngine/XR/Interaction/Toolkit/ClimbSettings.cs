namespace UnityEngine.XR.Interaction.Toolkit;

public class ClimbSettings
{
	[SerializeField]
	[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's x-axis.")]
	private bool m_AllowFreeXMovement; //Field offset: 0x10
	[SerializeField]
	[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's y-axis.")]
	private bool m_AllowFreeYMovement; //Field offset: 0x11
	[SerializeField]
	[Tooltip("Controls whether to allow unconstrained movement along the climb interactable's z-axis.")]
	private bool m_AllowFreeZMovement; //Field offset: 0x12

	public bool allowFreeXMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowFreeYMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowFreeZMovement
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public ClimbSettings() { }

	public bool get_allowFreeXMovement() { }

	public bool get_allowFreeYMovement() { }

	public bool get_allowFreeZMovement() { }

	public void set_allowFreeXMovement(bool value) { }

	public void set_allowFreeYMovement(bool value) { }

	public void set_allowFreeZMovement(bool value) { }

}

