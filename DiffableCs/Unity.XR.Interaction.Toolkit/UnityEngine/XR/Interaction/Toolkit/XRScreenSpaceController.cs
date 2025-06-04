namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Screen Space Controller", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRScreenSpaceController.html")]
public class XRScreenSpaceController : XRBaseController
{
	[Header("Touchscreen Gesture Actions")]
	[SerializeField]
	[Tooltip("When enabled, a Touchscreen Gesture Input Controller will be added to the Input System device list to detect touch gestures.")]
	private bool m_EnableTouchscreenGestureInputController; //Field offset: 0xA4
	[SerializeField]
	[Tooltip("The action to use for the screen tap position. (Vector 2 Control).")]
	private InputActionProperty m_TapStartPositionAction; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("The action to use for the current screen drag position. (Vector 2 Control).")]
	private InputActionProperty m_DragCurrentPositionAction; //Field offset: 0xC0
	[SerializeField]
	[Tooltip("The action to use for the delta of the screen drag. (Vector 2 Control).")]
	private InputActionProperty m_DragDeltaAction; //Field offset: 0xD8
	[FormerlySerializedAs("m_PinchStartPosition")]
	[SerializeField]
	[Tooltip("The action to use for the screen pinch gesture start position. (Vector 2 Control).")]
	private InputActionProperty m_PinchStartPositionAction; //Field offset: 0xF0
	[SerializeField]
	[Tooltip("The action to use for the gap of the screen pinch gesture. (Axis Control).")]
	private InputActionProperty m_PinchGapAction; //Field offset: 0x108
	[SerializeField]
	[Tooltip("The action to use for the delta of the screen pinch gesture. (Axis Control).")]
	private InputActionProperty m_PinchGapDeltaAction; //Field offset: 0x120
	[FormerlySerializedAs("m_TwistStartPosition")]
	[SerializeField]
	[Tooltip("The action to use for the screen twist gesture start position. (Vector 2 Control).")]
	private InputActionProperty m_TwistStartPositionAction; //Field offset: 0x138
	[FormerlySerializedAs("m_TwistRotationDeltaAction")]
	[SerializeField]
	[Tooltip("The action to use for the delta of the screen twist gesture. (Axis Control).")]
	private InputActionProperty m_TwistDeltaRotationAction; //Field offset: 0x150
	[FormerlySerializedAs("m_ScreenTouchCount")]
	[SerializeField]
	[Tooltip("The number of concurrent touches on the screen. (Integer Control).")]
	private InputActionProperty m_ScreenTouchCountAction; //Field offset: 0x168
	[SerializeField]
	[Tooltip("The camera associated with the screen, and through which screen presses/touches will be interpreted.")]
	private Camera m_ControllerCamera; //Field offset: 0x180
	[SerializeField]
	[Tooltip("Tells the XR Screen Space Controller to ignore interactions when hitting a screen space canvas.")]
	private bool m_BlockInteractionsWithScreenSpaceUI; //Field offset: 0x188
	[CompilerGenerated]
	private float <scaleDelta>k__BackingField; //Field offset: 0x18C
	private bool m_HasCheckedDisabledTrackingInputReferenceActions; //Field offset: 0x190
	private bool m_HasCheckedDisabledInputReferenceActions; //Field offset: 0x191
	private UIInputModule m_UIInputModule; //Field offset: 0x198

	public bool blockInteractionsWithScreenSpaceUI
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Camera controllerCamera
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionProperty dragCurrentPositionAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty dragDeltaAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public bool enableTouchscreenGestureInputController
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputActionProperty pinchGapAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	[Obsolete("pinchGapDelta has been deprecated. Use pinchGapDeltaAction instead. (UnityUpgradable) -> pinchGapDeltaAction")]
	public InputActionProperty pinchGapDelta
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty pinchGapDeltaAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	[Obsolete("pinchStartPosition has been deprecated. Use pinchStartPositionAction instead. (UnityUpgradable) -> pinchStartPositionAction")]
	public InputActionProperty pinchStartPosition
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty pinchStartPositionAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public private float scaleDelta
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Obsolete("screenTouchCount has been deprecated. Use screenTouchCountAction instead. (UnityUpgradable) -> screenTouchCountAction")]
	public InputActionProperty screenTouchCount
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty screenTouchCountAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty tapStartPositionAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public InputActionProperty twistDeltaRotationAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	[Obsolete("twistRotationDeltaAction has been deprecated. Use twistDeltaRotationAction instead. (UnityUpgradable) -> twistDeltaRotationAction")]
	public InputActionProperty twistRotationDeltaAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	[Obsolete("twistStartPosition has been deprecated. Use twistStartPositionAction instead. (UnityUpgradable) -> twistStartPositionAction")]
	public InputActionProperty twistStartPosition
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public InputActionProperty twistStartPositionAction
	{
		 get { } //Length: 24
		 set { } //Length: 48
	}

	public XRScreenSpaceController() { }

	private void DestroyTouchscreenGestureController() { }

	private void DisableAllDirectActions() { }

	private void EnableAllDirectActions() { }

	private bool FindUIInputModule() { }

	public bool get_blockInteractionsWithScreenSpaceUI() { }

	public Camera get_controllerCamera() { }

	public InputActionProperty get_dragCurrentPositionAction() { }

	public InputActionProperty get_dragDeltaAction() { }

	public bool get_enableTouchscreenGestureInputController() { }

	public InputActionProperty get_pinchGapAction() { }

	public InputActionProperty get_pinchGapDelta() { }

	public InputActionProperty get_pinchGapDeltaAction() { }

	public InputActionProperty get_pinchStartPosition() { }

	public InputActionProperty get_pinchStartPositionAction() { }

	[CompilerGenerated]
	public float get_scaleDelta() { }

	public InputActionProperty get_screenTouchCount() { }

	public InputActionProperty get_screenTouchCountAction() { }

	public InputActionProperty get_tapStartPositionAction() { }

	public InputActionProperty get_twistDeltaRotationAction() { }

	public InputActionProperty get_twistRotationDeltaAction() { }

	public InputActionProperty get_twistStartPosition() { }

	public InputActionProperty get_twistStartPositionAction() { }

	private void InitializeTouchscreenGestureController() { }

	private static bool IsDisabledReferenceAction(InputActionProperty property) { }

	private bool IsPointerOverScreenSpaceCanvas() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_blockInteractionsWithScreenSpaceUI(bool value) { }

	public void set_controllerCamera(Camera value) { }

	public void set_dragCurrentPositionAction(InputActionProperty value) { }

	public void set_dragDeltaAction(InputActionProperty value) { }

	public void set_enableTouchscreenGestureInputController(bool value) { }

	public void set_pinchGapAction(InputActionProperty value) { }

	public void set_pinchGapDelta(InputActionProperty value) { }

	public void set_pinchGapDeltaAction(InputActionProperty value) { }

	public void set_pinchStartPosition(InputActionProperty value) { }

	public void set_pinchStartPositionAction(InputActionProperty value) { }

	[CompilerGenerated]
	private void set_scaleDelta(float value) { }

	public void set_screenTouchCount(InputActionProperty value) { }

	public void set_screenTouchCountAction(InputActionProperty value) { }

	public void set_tapStartPositionAction(InputActionProperty value) { }

	public void set_twistDeltaRotationAction(InputActionProperty value) { }

	public void set_twistRotationDeltaAction(InputActionProperty value) { }

	public void set_twistStartPosition(InputActionProperty value) { }

	public void set_twistStartPositionAction(InputActionProperty value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

	protected void Start() { }

	private bool TryGetCurrentOneInputSelectAction(out InputAction action) { }

	private bool TryGetCurrentPositionAction(int touchCount, out InputAction action) { }

	private bool TryGetCurrentTwoInputSelectAction(out InputAction action) { }

	protected virtual void UpdateInput(XRControllerState controllerState) { }

	protected virtual void UpdateTrackingInput(XRControllerState controllerState) { }

}

