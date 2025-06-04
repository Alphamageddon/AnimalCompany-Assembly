namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Continuous Turn Provider (Action-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedContinuousTurnProvider.html")]
public class ActionBasedContinuousTurnProvider : ContinuousTurnProviderBase
{
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Turn data from the left hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_LeftHandTurnAction; //Field offset: 0x50
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Turn data from the right hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_RightHandTurnAction; //Field offset: 0x68

	public InputActionProperty leftHandTurnAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty rightHandTurnAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public ActionBasedContinuousTurnProvider() { }

	public InputActionProperty get_leftHandTurnAction() { }

	public InputActionProperty get_rightHandTurnAction() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected virtual Vector2 ReadInput() { }

	public void set_leftHandTurnAction(InputActionProperty value) { }

	public void set_rightHandTurnAction(InputActionProperty value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

}

