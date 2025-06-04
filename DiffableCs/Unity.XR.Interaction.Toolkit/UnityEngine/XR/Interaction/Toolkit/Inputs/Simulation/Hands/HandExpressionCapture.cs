namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands;

internal class HandExpressionCapture : ScriptableObject
{
	[SerializeField]
	[Tooltip("An icon to represent the hand expression.")]
	private Sprite m_Icon; //Field offset: 0x18
	[SerializeField]
	[Tooltip("The captured left hand joint poses.")]
	private Pose[] m_LeftCapturedPoses; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The captured right hand joint poses.")]
	private Pose[] m_RightCapturedPoses; //Field offset: 0x28

	public Sprite icon
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Pose[] leftHandCapturedPoses
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Pose[] rightHandCapturedPoses
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public HandExpressionCapture() { }

	public Sprite get_icon() { }

	public Pose[] get_leftHandCapturedPoses() { }

	public Pose[] get_rightHandCapturedPoses() { }

	public void set_icon(Sprite value) { }

	public void set_leftHandCapturedPoses(Pose[] value) { }

	public void set_rightHandCapturedPoses(Pose[] value) { }

}

