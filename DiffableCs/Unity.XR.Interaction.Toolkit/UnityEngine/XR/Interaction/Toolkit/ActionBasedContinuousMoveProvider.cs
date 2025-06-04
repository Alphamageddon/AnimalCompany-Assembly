namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Continuous Move Provider (Action-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedContinuousMoveProvider.html")]
public class ActionBasedContinuousMoveProvider : ContinuousMoveProviderBase
{
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Move data from the left hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_LeftHandMoveAction; //Field offset: 0x78
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Move data from the right hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_RightHandMoveAction; //Field offset: 0x90

	public InputActionProperty leftHandMoveAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty rightHandMoveAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public ActionBasedContinuousMoveProvider() { }

	public InputActionProperty get_leftHandMoveAction() { }

	public InputActionProperty get_rightHandMoveAction() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected virtual Vector2 ReadInput() { }

	public void set_leftHandMoveAction(InputActionProperty value) { }

	public void set_rightHandMoveAction(InputActionProperty value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

}

