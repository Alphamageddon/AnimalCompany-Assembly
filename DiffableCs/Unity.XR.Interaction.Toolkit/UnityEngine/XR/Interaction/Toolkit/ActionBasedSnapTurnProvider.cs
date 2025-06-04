namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Snap Turn Provider (Action-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedSnapTurnProvider.html")]
public class ActionBasedSnapTurnProvider : SnapTurnProviderBase
{
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Snap Turn data from the left hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_LeftHandSnapTurnAction; //Field offset: 0x68
	[SerializeField]
	[Tooltip("The Input System Action that will be used to read Snap Turn data from the right hand controller. Must be a Value Vector2 Control.")]
	private InputActionProperty m_RightHandSnapTurnAction; //Field offset: 0x80

	public InputActionProperty leftHandSnapTurnAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty rightHandSnapTurnAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public ActionBasedSnapTurnProvider() { }

	public InputActionProperty get_leftHandSnapTurnAction() { }

	public InputActionProperty get_rightHandSnapTurnAction() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected virtual Vector2 ReadInput() { }

	public void set_leftHandSnapTurnAction(InputActionProperty value) { }

	public void set_rightHandSnapTurnAction(InputActionProperty value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

}

