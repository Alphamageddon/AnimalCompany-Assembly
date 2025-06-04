namespace UnityEngine.XR.Interaction.Toolkit.UI;

[AddComponentMenu("Event/XR UI Input Module", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.XRUIInputModule.html")]
public class XRUIInputModule : UIInputModule
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UIHoverEventArgs> <>9__109_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal UIHoverEventArgs <.ctor>b__109_0() { }

	}

	internal enum ActiveInputMode
	{
		InputManagerBindings = 0,
		InputSystemActions = 1,
		Both = 2,
	}

	private struct RegisteredInteractor
	{
		public IUIInteractor interactor; //Field offset: 0x0
		public TrackedDeviceModel model; //Field offset: 0x8

		public RegisteredInteractor(IUIInteractor interactor, int deviceIndex) { }

	}

	private struct RegisteredTouch
	{
		public bool isValid; //Field offset: 0x0
		public int touchId; //Field offset: 0x4
		public TouchModel model; //Field offset: 0x8

		public RegisteredTouch(Touch touch, int deviceIndex) { }

	}

	internal const float kPixelPerLine = 20; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	[Tooltip("Represents which Active Input Mode will be used in the situation where the Active Input Handling project setting is set to Both.")]
	private ActiveInputMode m_ActiveInputMode; //Field offset: 0x120
	[HideInInspector]
	[SerializeField]
	[Tooltip("The maximum distance to ray cast with tracked devices to find hit objects.")]
	private float m_MaxTrackedDeviceRaycastDistance; //Field offset: 0x124
	[Header("Input Devices")]
	[SerializeField]
	[Tooltip("If true, will forward 3D tracked device data to UI elements.")]
	private bool m_EnableXRInput; //Field offset: 0x128
	[SerializeField]
	[Tooltip("If true, will forward 2D mouse data to UI elements.")]
	private bool m_EnableMouseInput; //Field offset: 0x129
	[SerializeField]
	[Tooltip("If true, will forward 2D touch data to UI elements.")]
	private bool m_EnableTouchInput; //Field offset: 0x12A
	[Header("Input System UI Actions")]
	[SerializeField]
	[Tooltip("Pointer input action reference, such as a mouse or single-finger touch device.")]
	private InputActionReference m_PointAction; //Field offset: 0x130
	[SerializeField]
	[Tooltip("Left-click input action reference, typically the left button on a mouse.")]
	private InputActionReference m_LeftClickAction; //Field offset: 0x138
	[SerializeField]
	[Tooltip("Middle-click input action reference, typically the middle button on a mouse.")]
	private InputActionReference m_MiddleClickAction; //Field offset: 0x140
	[SerializeField]
	[Tooltip("Right-click input action reference, typically the right button on a mouse.")]
	private InputActionReference m_RightClickAction; //Field offset: 0x148
	[SerializeField]
	[Tooltip("Scroll wheel input action reference, typically the scroll wheel on a mouse.")]
	private InputActionReference m_ScrollWheelAction; //Field offset: 0x150
	[SerializeField]
	[Tooltip("Navigation input action reference will change which UI element is currently selected to the one up, down, left of or right of the currently selected one.")]
	private InputActionReference m_NavigateAction; //Field offset: 0x158
	[SerializeField]
	[Tooltip("Submit input action reference will trigger a submission of the currently selected UI in the Event System.")]
	private InputActionReference m_SubmitAction; //Field offset: 0x160
	[SerializeField]
	[Tooltip("Cancel input action reference will trigger canceling out of the currently selected UI in the Event System.")]
	private InputActionReference m_CancelAction; //Field offset: 0x168
	[SerializeField]
	[Tooltip("When enabled, built-in Input System actions will be used if no Input System UI Actions are assigned.")]
	private bool m_EnableBuiltinActionsAsFallback; //Field offset: 0x170
	[HideInInspector]
	[SerializeField]
	[Tooltip("If true, will use the Input Manager (Old) configuration to forward gamepad data to UI elements.")]
	private bool m_EnableGamepadInput; //Field offset: 0x171
	[HideInInspector]
	[SerializeField]
	[Tooltip("If true, will use the Input Manager (Old) configuration to forward joystick data to UI elements.")]
	private bool m_EnableJoystickInput; //Field offset: 0x172
	[HideInInspector]
	[SerializeField]
	[Tooltip("Name of the horizontal axis for gamepad/joystick UI navigation when using the old Input Manager.")]
	private string m_HorizontalAxis; //Field offset: 0x178
	[HideInInspector]
	[SerializeField]
	[Tooltip("Name of the vertical axis for gamepad/joystick UI navigation when using the old Input Manager.")]
	private string m_VerticalAxis; //Field offset: 0x180
	[HideInInspector]
	[SerializeField]
	[Tooltip("Name of the gamepad/joystick button to use for UI selection or submission when using the old Input Manager.")]
	private string m_SubmitButton; //Field offset: 0x188
	[HideInInspector]
	[SerializeField]
	[Tooltip("Name of the gamepad/joystick button to use for UI cancel or back commands when using the old Input Manager.")]
	private string m_CancelButton; //Field offset: 0x190
	private int m_RollingPointerId; //Field offset: 0x198
	private bool m_UseBuiltInInputSystemActions; //Field offset: 0x19C
	private MouseModel m_MouseState; //Field offset: 0x1A0
	private NavigationModel m_NavigationState; //Field offset: 0x358
	private readonly List<RegisteredTouch> m_RegisteredTouches; //Field offset: 0x378
	private readonly List<RegisteredInteractor> m_RegisteredInteractors; //Field offset: 0x380
	private readonly LinkedPool<UIHoverEventArgs> m_UIHoverEventArgs; //Field offset: 0x388

	public ActiveInputMode activeInputMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference cancelAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public string cancelButton
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool enableBuiltinActionsAsFallback
	{
		 get { } //Length: 8
		 set { } //Length: 56
	}

	public bool enableGamepadInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableJoystickInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableMouseInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableTouchInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableXRInput
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public string horizontalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference leftClickAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	[Obsolete("maxRaycastDistance has been deprecated. Its value was unused, calling this property is unnecessary and should be removed.")]
	public float maxRaycastDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference middleClickAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public InputActionReference navigateAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public InputActionReference pointAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public InputActionReference rightClickAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public InputActionReference scrollWheelAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public InputActionReference submitAction
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public string submitButton
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string verticalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRUIInputModule() { }

	private void DisableAllActions() { }

	private static void DisableInputAction(InputActionReference inputAction) { }

	protected virtual void DoProcess() { }

	private void EnableAllActions() { }

	private static void EnableInputAction(InputActionReference inputAction) { }

	public ActiveInputMode get_activeInputMode() { }

	public InputActionReference get_cancelAction() { }

	public string get_cancelButton() { }

	public bool get_enableBuiltinActionsAsFallback() { }

	public bool get_enableGamepadInput() { }

	public bool get_enableJoystickInput() { }

	public bool get_enableMouseInput() { }

	public bool get_enableTouchInput() { }

	public bool get_enableXRInput() { }

	public string get_horizontalAxis() { }

	public InputActionReference get_leftClickAction() { }

	public float get_maxRaycastDistance() { }

	public InputActionReference get_middleClickAction() { }

	public InputActionReference get_navigateAction() { }

	public InputActionReference get_pointAction() { }

	public InputActionReference get_rightClickAction() { }

	public InputActionReference get_scrollWheelAction() { }

	public InputActionReference get_submitAction() { }

	public string get_submitButton() { }

	public string get_verticalAxis() { }

	private int GetDisplayIndexFor(InputControl control) { }

	public IUIInteractor GetInteractor(int pointerId) { }

	public bool GetTrackedDeviceModel(IUIInteractor interactor, out TrackedDeviceModel model) { }

	private bool InputActionReferencesAreSet() { }

	private static bool IsActionEnabled(InputActionReference inputAction) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void ProcessMouse() { }

	private void ProcessNavigation() { }

	private bool ProcessTouches() { }

	public void RegisterInteractor(IUIInteractor interactor) { }

	public void set_activeInputMode(ActiveInputMode value) { }

	public void set_cancelAction(InputActionReference value) { }

	public void set_cancelButton(string value) { }

	public void set_enableBuiltinActionsAsFallback(bool value) { }

	public void set_enableGamepadInput(bool value) { }

	public void set_enableJoystickInput(bool value) { }

	public void set_enableMouseInput(bool value) { }

	public void set_enableTouchInput(bool value) { }

	public void set_enableXRInput(bool value) { }

	public void set_horizontalAxis(string value) { }

	public void set_leftClickAction(InputActionReference value) { }

	public void set_maxRaycastDistance(float value) { }

	public void set_middleClickAction(InputActionReference value) { }

	public void set_navigateAction(InputActionReference value) { }

	public void set_pointAction(InputActionReference value) { }

	public void set_rightClickAction(InputActionReference value) { }

	public void set_scrollWheelAction(InputActionReference value) { }

	public void set_submitAction(InputActionReference value) { }

	public void set_submitButton(string value) { }

	public void set_verticalAxis(string value) { }

	private void SetInputAction(ref InputActionReference inputAction, InputActionReference value) { }

	public void UnregisterInteractor(IUIInteractor interactor) { }

}

