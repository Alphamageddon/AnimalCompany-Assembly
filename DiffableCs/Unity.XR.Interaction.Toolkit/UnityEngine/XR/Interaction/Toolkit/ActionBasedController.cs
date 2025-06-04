namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Controller (Action-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ActionBasedController.html")]
public class ActionBasedController : XRBaseController
{
	[SerializeField]
	private InputActionProperty m_PositionAction; //Field offset: 0xA8
	[SerializeField]
	private InputActionProperty m_RotationAction; //Field offset: 0xC0
	[SerializeField]
	private InputActionProperty m_IsTrackedAction; //Field offset: 0xD8
	[SerializeField]
	private InputActionProperty m_TrackingStateAction; //Field offset: 0xF0
	[SerializeField]
	private InputActionProperty m_SelectAction; //Field offset: 0x108
	[SerializeField]
	private InputActionProperty m_SelectActionValue; //Field offset: 0x120
	[SerializeField]
	private InputActionProperty m_ActivateAction; //Field offset: 0x138
	[SerializeField]
	private InputActionProperty m_ActivateActionValue; //Field offset: 0x150
	[SerializeField]
	private InputActionProperty m_UIPressAction; //Field offset: 0x168
	[SerializeField]
	private InputActionProperty m_UIPressActionValue; //Field offset: 0x180
	[SerializeField]
	private InputActionProperty m_UIScrollAction; //Field offset: 0x198
	[SerializeField]
	private InputActionProperty m_HapticDeviceAction; //Field offset: 0x1B0
	[SerializeField]
	private InputActionProperty m_RotateAnchorAction; //Field offset: 0x1C8
	[SerializeField]
	private InputActionProperty m_DirectionalAnchorRotationAction; //Field offset: 0x1E0
	[SerializeField]
	private InputActionProperty m_TranslateAnchorAction; //Field offset: 0x1F8
	[SerializeField]
	private InputActionProperty m_ScaleToggleAction; //Field offset: 0x210
	[SerializeField]
	private InputActionProperty m_ScaleDeltaAction; //Field offset: 0x228
	private bool m_HasCheckedDisabledTrackingInputReferenceActions; //Field offset: 0x240
	private bool m_HasCheckedDisabledInputReferenceActions; //Field offset: 0x241
	[SerializeField]
	private float m_ButtonPressPoint; //Field offset: 0x244

	public InputActionProperty activateAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty activateActionValue
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	[Obsolete("Deprecated, this obsolete property is not used when Input System version is 1.1.0 or higher. Configure press point on the action or binding instead.", True)]
	public float buttonPressPoint
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionProperty directionalAnchorRotationAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty hapticDeviceAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty isTrackedAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty positionAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty rotateAnchorAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty rotationAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty scaleDeltaAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty scaleToggleAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty selectAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty selectActionValue
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty trackingStateAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty translateAnchorAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty uiPressAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty uiPressActionValue
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty uiScrollAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public ActionBasedController() { }

	private void DisableAllDirectActions() { }

	private void EnableAllDirectActions() { }

	public InputActionProperty get_activateAction() { }

	public InputActionProperty get_activateActionValue() { }

	public float get_buttonPressPoint() { }

	public InputActionProperty get_directionalAnchorRotationAction() { }

	public InputActionProperty get_hapticDeviceAction() { }

	public InputActionProperty get_isTrackedAction() { }

	public InputActionProperty get_positionAction() { }

	public InputActionProperty get_rotateAnchorAction() { }

	public InputActionProperty get_rotationAction() { }

	public InputActionProperty get_scaleDeltaAction() { }

	public InputActionProperty get_scaleToggleAction() { }

	public InputActionProperty get_selectAction() { }

	public InputActionProperty get_selectActionValue() { }

	public InputActionProperty get_trackingStateAction() { }

	public InputActionProperty get_translateAnchorAction() { }

	public InputActionProperty get_uiPressAction() { }

	public InputActionProperty get_uiPressActionValue() { }

	public InputActionProperty get_uiScrollAction() { }

	private static bool IsDisabledReferenceAction(InputActionProperty property) { }

	protected override bool IsPressed(InputAction action) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected override float ReadValue(InputAction action) { }

	public virtual bool SendHapticImpulse(float amplitude, float duration) { }

	public void set_activateAction(InputActionProperty value) { }

	public void set_activateActionValue(InputActionProperty value) { }

	public void set_buttonPressPoint(float value) { }

	public void set_directionalAnchorRotationAction(InputActionProperty value) { }

	public void set_hapticDeviceAction(InputActionProperty value) { }

	public void set_isTrackedAction(InputActionProperty value) { }

	public void set_positionAction(InputActionProperty value) { }

	public void set_rotateAnchorAction(InputActionProperty value) { }

	public void set_rotationAction(InputActionProperty value) { }

	public void set_scaleDeltaAction(InputActionProperty value) { }

	public void set_scaleToggleAction(InputActionProperty value) { }

	public void set_selectAction(InputActionProperty value) { }

	public void set_selectActionValue(InputActionProperty value) { }

	public void set_trackingStateAction(InputActionProperty value) { }

	public void set_translateAnchorAction(InputActionProperty value) { }

	public void set_uiPressAction(InputActionProperty value) { }

	public void set_uiPressActionValue(InputActionProperty value) { }

	public void set_uiScrollAction(InputActionProperty value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

	protected virtual void UpdateInput(XRControllerState controllerState) { }

	protected virtual void UpdateTrackingInput(XRControllerState controllerState) { }

}

