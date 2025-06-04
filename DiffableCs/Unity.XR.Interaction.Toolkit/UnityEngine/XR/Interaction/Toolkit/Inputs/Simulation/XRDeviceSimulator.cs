namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[AddComponentMenu("XR/Debug/XR Device Simulator", 11)]
[DefaultExecutionOrder(-29991)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.XRDeviceSimulator.html")]
public class XRDeviceSimulator : MonoBehaviour
{
	[Flags]
	internal enum Axis2DTargets
	{
		None = 0,
		Position = 1,
		Primary2DAxis = 2,
		Secondary2DAxis = 4,
	}

	internal enum DeviceMode
	{
		Controller = 0,
		Hand = 1,
	}

	internal class SimulatedHandExpression : ISerializationCallbackReceiver
	{
		[Delayed]
		[SerializeField]
		[Tooltip("The unique name for the hand expression.")]
		private string m_Name; //Field offset: 0x10
		[SerializeField]
		[Tooltip("The input action to trigger the hand expression.")]
		private InputActionReference m_ToggleAction; //Field offset: 0x18
		[SerializeField]
		[Tooltip("The captured hand expression to simulate when the input action is performed.")]
		private HandExpressionCapture m_Capture; //Field offset: 0x20
		private HandExpressionName m_ExpressionName; //Field offset: 0x28
		private Action<SimulatedHandExpression, CallbackContext> m_Performed; //Field offset: 0x38
		private bool m_Subscribed; //Field offset: 0x40

		public event Action<SimulatedHandExpression, CallbackContext> performed
		{
			 add { } //Length: 300
			 remove { } //Length: 296
		}

		internal HandExpressionCapture capture
		{
			internal get { } //Length: 8
			internal set { } //Length: 8
		}

		internal HandExpressionName expressionName
		{
			internal get { } //Length: 12
			internal set { } //Length: 8
		}

		public Sprite icon
		{
			 get { } //Length: 28
		}

		public string name
		{
			 get { } //Length: 108
		}

		public InputActionReference toggleAction
		{
			 get { } //Length: 8
		}

		public SimulatedHandExpression() { }

		public void add_performed(Action<SimulatedHandExpression, CallbackContext> value) { }

		internal HandExpressionCapture get_capture() { }

		internal HandExpressionName get_expressionName() { }

		public Sprite get_icon() { }

		public string get_name() { }

		public InputActionReference get_toggleAction() { }

		private void OnActionPerformed(CallbackContext context) { }

		public void remove_performed(Action<SimulatedHandExpression, CallbackContext> value) { }

		internal void set_capture(HandExpressionCapture value) { }

		internal void set_expressionName(HandExpressionName value) { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

		private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	}

	internal enum Space
	{
		Local = 0,
		Parent = 1,
		Screen = 2,
	}

	[Flags]
	public enum TargetedDevices
	{
		None = 0,
		FPS = 1,
		LeftDevice = 2,
		RightDevice = 4,
		HMD = 8,
	}

	internal enum TransformationMode
	{
		Translate = 0,
		Rotate = 1,
	}

	private const float k_CameraMaxXAngle = 80; //Field offset: 0x0
	private static readonly Vector3 s_LeftDeviceDefaultInitialPosition; //Field offset: 0x0
	private static readonly Vector3 s_RightDeviceDefaultInitialPosition; //Field offset: 0xC
	[CompilerGenerated]
	private static XRDeviceSimulator <instance>k__BackingField; //Field offset: 0x18
	[SerializeField]
	[Tooltip("Input Action asset containing controls for the simulator itself. Unity will automatically enable and disable it with this component.")]
	private InputActionAsset m_DeviceSimulatorActionAsset; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Input Action asset containing controls for the simulated controllers. Unity will automatically enable and disable it as needed.")]
	private InputActionAsset m_ControllerActionAsset; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The Input System Action used to translate in the x-axis (left/right) while held. Must be a Value Axis Control.")]
	private InputActionReference m_KeyboardXTranslateAction; //Field offset: 0x30
	[SerializeField]
	[Tooltip("The Input System Action used to translate in the y-axis (up/down) while held. Must be a Value Axis Control.")]
	private InputActionReference m_KeyboardYTranslateAction; //Field offset: 0x38
	[SerializeField]
	[Tooltip("The Input System Action used to translate in the z-axis (forward/back) while held. Must be a Value Axis Control.")]
	private InputActionReference m_KeyboardZTranslateAction; //Field offset: 0x40
	[SerializeField]
	[Tooltip("The Input System Action used to enable manipulation of the left-hand controller while held. Must be a Button Control.")]
	private InputActionReference m_ManipulateLeftAction; //Field offset: 0x48
	[SerializeField]
	[Tooltip("The Input System Action used to enable manipulation of the right-hand controller while held. Must be a Button Control.")]
	private InputActionReference m_ManipulateRightAction; //Field offset: 0x50
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable manipulation of the left-hand controller when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleManipulateLeftAction; //Field offset: 0x58
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable manipulation of the right-hand controller when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleManipulateRightAction; //Field offset: 0x60
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable looking around with the HMD and controllers. Must be a Button Control.")]
	private InputActionReference m_ToggleManipulateBodyAction; //Field offset: 0x68
	[SerializeField]
	[Tooltip("The Input System Action used to enable manipulation of the HMD while held. Must be a Button Control.")]
	private InputActionReference m_ManipulateHeadAction; //Field offset: 0x70
	[SerializeField]
	[Tooltip("The Input System Action used to change between hand and controller mode. Must be a Button Control.")]
	private InputActionReference m_HandControllerModeAction; //Field offset: 0x78
	[SerializeField]
	[Tooltip("The Input System Action used to cycle between the different available devices. Must be a Button Control.")]
	private InputActionReference m_CycleDevicesAction; //Field offset: 0x80
	[SerializeField]
	[Tooltip("The Input System Action used to stop all manipulation. Must be a Button Control.")]
	private InputActionReference m_StopManipulationAction; //Field offset: 0x88
	[SerializeField]
	[Tooltip("The Input System Action used to translate or rotate by a scaled amount along or about the x- and y-axes. Must be a Value Vector2 Control.")]
	private InputActionReference m_MouseDeltaAction; //Field offset: 0x90
	[SerializeField]
	[Tooltip("The Input System Action used to translate or rotate by a scaled amount along or about the z-axis. Must be a Value Vector2 Control.")]
	private InputActionReference m_MouseScrollAction; //Field offset: 0x98
	[SerializeField]
	[Tooltip("The Input System Action used to cause the manipulated device(s) to rotate when moving the mouse when held. Must be a Button Control.")]
	private InputActionReference m_RotateModeOverrideAction; //Field offset: 0xA0
	[SerializeField]
	[Tooltip("The Input System Action used to toggle between translating or rotating the manipulated device(s) when moving the mouse when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleMouseTransformationModeAction; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("The Input System Action used to cause the manipulated device(s) to rotate when moving the mouse while held when it would normally translate, and vice-versa. Must be a Button Control.")]
	private InputActionReference m_NegateModeAction; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("The Input System Action used to constrain the translation or rotation to the x-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
	private InputActionReference m_XConstraintAction; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("The Input System Action used to constrain the translation or rotation to the y-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
	private InputActionReference m_YConstraintAction; //Field offset: 0xC0
	[SerializeField]
	[Tooltip("The Input System Action used to constrain the translation or rotation to the z-axis when moving the mouse or resetting. May be combined with another axis constraint to constrain to a plane. Must be a Button Control.")]
	private InputActionReference m_ZConstraintAction; //Field offset: 0xC8
	[SerializeField]
	[Tooltip("The Input System Action used to cause the manipulated device(s) to reset position or rotation (depending on the effective manipulation mode). Must be a Button Control.")]
	private InputActionReference m_ResetAction; //Field offset: 0xD0
	[SerializeField]
	[Tooltip("The Input System Action used to toggle the cursor lock mode for the game window when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleCursorLockAction; //Field offset: 0xD8
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable translation from keyboard inputs when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleDevicePositionTargetAction; //Field offset: 0xE0
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable manipulation of the Primary2DAxis of the controllers when pressed. Must be a Button Control.")]
	private InputActionReference m_TogglePrimary2DAxisTargetAction; //Field offset: 0xE8
	[SerializeField]
	[Tooltip("The Input System Action used to toggle enable manipulation of the Secondary2DAxis of the controllers when pressed. Must be a Button Control.")]
	private InputActionReference m_ToggleSecondary2DAxisTargetAction; //Field offset: 0xF0
	[SerializeField]
	[Tooltip("The Input System Action used to control the value of one or more 2D Axis controls on the manipulated controller device(s). Must be a Value Vector2 Control.")]
	private InputActionReference m_Axis2DAction; //Field offset: 0xF8
	[SerializeField]
	[Tooltip("The Input System Action used to control one or more 2D Axis controls on the opposite hand of the exclusively manipulated controller device. Must be a Value Vector2 Control.")]
	private InputActionReference m_RestingHandAxis2DAction; //Field offset: 0x100
	[SerializeField]
	[Tooltip("The Input System Action used to control the Grip control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_GripAction; //Field offset: 0x108
	[SerializeField]
	[Tooltip("The Input System Action used to control the Trigger control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_TriggerAction; //Field offset: 0x110
	[SerializeField]
	[Tooltip("The Input System Action used to control the PrimaryButton control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_PrimaryButtonAction; //Field offset: 0x118
	[SerializeField]
	[Tooltip("The Input System Action used to control the SecondaryButton control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_SecondaryButtonAction; //Field offset: 0x120
	[SerializeField]
	[Tooltip("The Input System Action used to control the Menu control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_MenuAction; //Field offset: 0x128
	[SerializeField]
	[Tooltip("The Input System Action used to control the Primary2DAxisClick control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_Primary2DAxisClickAction; //Field offset: 0x130
	[SerializeField]
	[Tooltip("The Input System Action used to control the Secondary2DAxisClick control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_Secondary2DAxisClickAction; //Field offset: 0x138
	[SerializeField]
	[Tooltip("The Input System Action used to control the Primary2DAxisTouch control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_Primary2DAxisTouchAction; //Field offset: 0x140
	[SerializeField]
	[Tooltip("The Input System Action used to control the Secondary2DAxisTouch control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_Secondary2DAxisTouchAction; //Field offset: 0x148
	[SerializeField]
	[Tooltip("The Input System Action used to control the PrimaryTouch control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_PrimaryTouchAction; //Field offset: 0x150
	[SerializeField]
	[Tooltip("The Input System Action used to control the SecondaryTouch control of the manipulated controller device(s). Must be a Button Control.")]
	private InputActionReference m_SecondaryTouchAction; //Field offset: 0x158
	[SerializeField]
	[Tooltip("Input Action asset containing controls for the simulated hands. Unity will automatically enable and disable it as needed.")]
	private InputActionAsset m_HandActionAsset; //Field offset: 0x160
	[SerializeField]
	[Tooltip("The resting hand expression to use when no other hand expression is active.")]
	private HandExpressionCapture m_RestingHandExpressionCapture; //Field offset: 0x168
	[SerializeField]
	[Tooltip("The list of hand expressions to simulate.")]
	private List<SimulatedHandExpression> m_SimulatedHandExpressions; //Field offset: 0x170
	[SerializeField]
	[Tooltip("The Transform that contains the Camera. This is usually the \"Head\" of XR Origins. Automatically set to the first enabled camera tagged MainCamera if unset.")]
	private Transform m_CameraTransform; //Field offset: 0x178
	[SerializeField]
	[Tooltip("The coordinate space in which keyboard translation should operate.")]
	private Space m_KeyboardTranslateSpace; //Field offset: 0x180
	[SerializeField]
	[Tooltip("The coordinate space in which mouse translation should operate.")]
	private Space m_MouseTranslateSpace; //Field offset: 0x184
	[SerializeField]
	[Tooltip("Speed of translation in the x-axis (left/right) when triggered by keyboard input.")]
	private float m_KeyboardXTranslateSpeed; //Field offset: 0x188
	[SerializeField]
	[Tooltip("Speed of translation in the y-axis (up/down) when triggered by keyboard input.")]
	private float m_KeyboardYTranslateSpeed; //Field offset: 0x18C
	[SerializeField]
	[Tooltip("Speed of translation in the z-axis (forward/back) when triggered by keyboard input.")]
	private float m_KeyboardZTranslateSpeed; //Field offset: 0x190
	[SerializeField]
	[Tooltip("Speed multiplier applied for body translation when triggered by keyboard input.")]
	private float m_KeyboardBodyTranslateMultiplier; //Field offset: 0x194
	[SerializeField]
	[Tooltip("Sensitivity of translation in the x-axis (left/right) when triggered by mouse input.")]
	private float m_MouseXTranslateSensitivity; //Field offset: 0x198
	[SerializeField]
	[Tooltip("Sensitivity of translation in the y-axis (up/down) when triggered by mouse input.")]
	private float m_MouseYTranslateSensitivity; //Field offset: 0x19C
	[SerializeField]
	[Tooltip("Sensitivity of translation in the z-axis (forward/back) when triggered by mouse scroll input.")]
	private float m_MouseScrollTranslateSensitivity; //Field offset: 0x1A0
	[SerializeField]
	[Tooltip("Sensitivity of rotation along the x-axis (pitch) when triggered by mouse input.")]
	private float m_MouseXRotateSensitivity; //Field offset: 0x1A4
	[SerializeField]
	[Tooltip("Sensitivity of rotation along the y-axis (yaw) when triggered by mouse input.")]
	private float m_MouseYRotateSensitivity; //Field offset: 0x1A8
	[SerializeField]
	[Tooltip("Sensitivity of rotation along the z-axis (roll) when triggered by mouse scroll input.")]
	private float m_MouseScrollRotateSensitivity; //Field offset: 0x1AC
	[SerializeField]
	[Tooltip("A boolean value of whether to invert the y-axis of mouse input when rotating by mouse input.\nA false value (default) means typical FPS style where moving the mouse up/down pitches up/down.\nA true value means flight control style where moving the mouse up/down pitches down/up.")]
	private bool m_MouseYRotateInvert; //Field offset: 0x1B0
	[SerializeField]
	[Tooltip("The desired cursor lock mode to toggle to from None (either Locked or Confined).")]
	private CursorLockMode m_DesiredCursorLockMode; //Field offset: 0x1B4
	[SerializeField]
	[Tooltip("Whether or not to remove other XR HMD devices in this session so that they don't conflict with the XR Device Simulator.")]
	private bool m_RemoveOtherHMDDevices; //Field offset: 0x1B8
	[SerializeField]
	[Tooltip("Whether to create a simulated Hand Tracking Subsystem and provider on startup. Requires the XR Hands package.")]
	private bool m_HandTrackingCapability; //Field offset: 0x1B9
	[SerializeField]
	[Tooltip("The optional Device Simulator UI prefab to use along with the XR Device Simulator.")]
	private GameObject m_DeviceSimulatorUI; //Field offset: 0x1C0
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The amount of the simulated grip on the controller when the Grip control is pressed.")]
	private float m_GripAmount; //Field offset: 0x1C8
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The amount of the simulated trigger pull on the controller when the Trigger control is pressed.")]
	private float m_TriggerAmount; //Field offset: 0x1CC
	[SerializeField]
	[Tooltip("Whether the HMD should report the pose as fully tracked or unavailable/inferred.")]
	private bool m_HMDIsTracked; //Field offset: 0x1D0
	[SerializeField]
	[Tooltip("Which tracking values the HMD should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
	private InputTrackingState m_HMDTrackingState; //Field offset: 0x1D4
	[SerializeField]
	[Tooltip("Whether the left-hand controller should report the pose as fully tracked or unavailable/inferred.")]
	private bool m_LeftControllerIsTracked; //Field offset: 0x1D8
	[SerializeField]
	[Tooltip("Which tracking values the left-hand controller should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
	private InputTrackingState m_LeftControllerTrackingState; //Field offset: 0x1DC
	[SerializeField]
	[Tooltip("Whether the right-hand controller should report the pose as fully tracked or unavailable/inferred.")]
	private bool m_RightControllerIsTracked; //Field offset: 0x1E0
	[SerializeField]
	[Tooltip("Which tracking values the right-hand controller should report as being valid or meaningful to use, which could mean either tracked or inferred.")]
	private InputTrackingState m_RightControllerTrackingState; //Field offset: 0x1E4
	[SerializeField]
	[Tooltip("Whether the left hand should report the pose as fully tracked or unavailable/inferred.")]
	private bool m_LeftHandIsTracked; //Field offset: 0x1E8
	[SerializeField]
	[Tooltip("Whether the right hand should report the pose as fully tracked or unavailable/inferred.")]
	private bool m_RightHandIsTracked; //Field offset: 0x1E9
	[CompilerGenerated]
	private TransformationMode <mouseTransformationMode>k__BackingField; //Field offset: 0x1EC
	[CompilerGenerated]
	private bool <negateMode>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private Axis2DTargets <axis2DTargets>k__BackingField; //Field offset: 0x1F4
	private TargetedDevices m_TargetedDeviceInput; //Field offset: 0x1F8
	private DeviceMode m_DeviceMode; //Field offset: 0x1FC
	private bool m_DeviceModeDirty; //Field offset: 0x200
	private bool m_StartedDeviceModeChange; //Field offset: 0x201
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"transform", "camera"}])]
	private ValueTuple<Transform, Camera> m_CachedCamera; //Field offset: 0x208
	private float m_KeyboardXTranslateInput; //Field offset: 0x218
	private float m_KeyboardYTranslateInput; //Field offset: 0x21C
	private float m_KeyboardZTranslateInput; //Field offset: 0x220
	private Vector2 m_MouseDeltaInput; //Field offset: 0x224
	private Vector2 m_MouseScrollInput; //Field offset: 0x22C
	private bool m_RotateModeOverrideInput; //Field offset: 0x234
	private bool m_XConstraintInput; //Field offset: 0x235
	private bool m_YConstraintInput; //Field offset: 0x236
	private bool m_ZConstraintInput; //Field offset: 0x237
	private bool m_ResetInput; //Field offset: 0x238
	private Vector2 m_Axis2DInput; //Field offset: 0x23C
	private Vector2 m_RestingHandAxis2DInput; //Field offset: 0x244
	private bool m_GripInput; //Field offset: 0x24C
	private bool m_TriggerInput; //Field offset: 0x24D
	private bool m_PrimaryButtonInput; //Field offset: 0x24E
	private bool m_SecondaryButtonInput; //Field offset: 0x24F
	private bool m_MenuInput; //Field offset: 0x250
	private bool m_Primary2DAxisClickInput; //Field offset: 0x251
	private bool m_Secondary2DAxisClickInput; //Field offset: 0x252
	private bool m_Primary2DAxisTouchInput; //Field offset: 0x253
	private bool m_Secondary2DAxisTouchInput; //Field offset: 0x254
	private bool m_PrimaryTouchInput; //Field offset: 0x255
	private bool m_SecondaryTouchInput; //Field offset: 0x256
	private bool m_ManipulatedRestingHandAxis2D; //Field offset: 0x257
	private Vector3 m_LeftControllerEuler; //Field offset: 0x258
	private Vector3 m_RightControllerEuler; //Field offset: 0x264
	private Vector3 m_CenterEyeEuler; //Field offset: 0x270
	private XRSimulatedHMDState m_HMDState; //Field offset: 0x27C
	private XRSimulatedControllerState m_LeftControllerState; //Field offset: 0x2F1
	private XRSimulatedControllerState m_RightControllerState; //Field offset: 0x330
	private XRSimulatedHMD m_HMDDevice; //Field offset: 0x370
	private XRSimulatedController m_LeftControllerDevice; //Field offset: 0x378
	private XRSimulatedController m_RightControllerDevice; //Field offset: 0x380
	private bool m_OnInputDeviceChangeSubscribed; //Field offset: 0x388
	private XRSimulatedHandState m_LeftHandState; //Field offset: 0x390
	private XRSimulatedHandState m_RightHandState; //Field offset: 0x3C8

	public InputActionReference axis2DAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public Axis2DTargets axis2DTargets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Transform cameraTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionAsset controllerActionAsset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference cycleDevicesAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public CursorLockMode desiredCursorLockMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public DeviceMode deviceMode
	{
		 get { } //Length: 8
	}

	public InputActionAsset deviceSimulatorActionAsset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject deviceSimulatorUI
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference gripAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float gripAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionAsset handActionAsset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference handControllerModeAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool handTrackingCapability
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool hmdIsTracked
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputTrackingState hmdTrackingState
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private static XRDeviceSimulator instance
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	public float keyboardBodyTranslateMultiplier
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Space keyboardTranslateSpace
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference keyboardXTranslateAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float keyboardXTranslateSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference keyboardYTranslateAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float keyboardYTranslateSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference keyboardZTranslateAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float keyboardZTranslateSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool leftControllerIsTracked
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputTrackingState leftControllerTrackingState
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool leftHandIsTracked
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputActionReference manipulateHeadAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference manipulateLeftAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference manipulateRightAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool manipulatingFPS
	{
		 get { } //Length: 16
	}

	public bool manipulatingLeftController
	{
		 get { } //Length: 32
	}

	public bool manipulatingLeftDevice
	{
		 get { } //Length: 16
	}

	public bool manipulatingLeftHand
	{
		 get { } //Length: 36
	}

	public bool manipulatingRightController
	{
		 get { } //Length: 32
	}

	public bool manipulatingRightDevice
	{
		 get { } //Length: 16
	}

	public bool manipulatingRightHand
	{
		 get { } //Length: 36
	}

	public InputActionReference menuAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference mouseDeltaAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference mouseScrollAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float mouseScrollRotateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float mouseScrollTranslateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TransformationMode mouseTransformationMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Space mouseTranslateSpace
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float mouseXRotateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float mouseXTranslateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool mouseYRotateInvert
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float mouseYRotateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float mouseYTranslateSensitivity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private bool negateMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public InputActionReference negateModeAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference primary2DAxisClickAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference primary2DAxisTouchAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference primaryButtonAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference primaryTouchAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool removeOtherHMDDevices
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputActionReference resetAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference restingHandAxis2DAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public bool rightControllerIsTracked
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputTrackingState rightControllerTrackingState
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool rightHandIsTracked
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputActionReference rotateModeOverrideAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference secondary2DAxisClickAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference secondary2DAxisTouchAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference secondaryButtonAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference secondaryTouchAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public List<SimulatedHandExpression> simulatedHandExpressions
	{
		 get { } //Length: 8
	}

	public InputActionReference stopManipulationAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	private TargetedDevices targetedDeviceInput
	{
		private get { } //Length: 8
		private set { } //Length: 8
	}

	public InputActionReference toggleCursorLockAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleDevicePositionTargetAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleManipulateBodyAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleManipulateLeftAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleManipulateRightAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleMouseTransformationModeAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference togglePrimary2DAxisTargetAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference toggleSecondary2DAxisTargetAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference triggerAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float triggerAmount
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputActionReference xConstraintAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference yConstraintAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public InputActionReference zConstraintAction
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	private static XRDeviceSimulator() { }

	public XRDeviceSimulator() { }

	private void AddControllerDevices() { }

	protected override void AddDevices() { }

	private void ApplyHandState() { }

	protected override void Awake() { }

	private bool FindCameraTransform() { }

	public InputActionReference get_axis2DAction() { }

	[CompilerGenerated]
	public Axis2DTargets get_axis2DTargets() { }

	public Transform get_cameraTransform() { }

	public InputActionAsset get_controllerActionAsset() { }

	public InputActionReference get_cycleDevicesAction() { }

	public CursorLockMode get_desiredCursorLockMode() { }

	public DeviceMode get_deviceMode() { }

	public InputActionAsset get_deviceSimulatorActionAsset() { }

	public GameObject get_deviceSimulatorUI() { }

	public InputActionReference get_gripAction() { }

	public float get_gripAmount() { }

	public InputActionAsset get_handActionAsset() { }

	public InputActionReference get_handControllerModeAction() { }

	public bool get_handTrackingCapability() { }

	public bool get_hmdIsTracked() { }

	public InputTrackingState get_hmdTrackingState() { }

	[CompilerGenerated]
	public static XRDeviceSimulator get_instance() { }

	public float get_keyboardBodyTranslateMultiplier() { }

	public Space get_keyboardTranslateSpace() { }

	public InputActionReference get_keyboardXTranslateAction() { }

	public float get_keyboardXTranslateSpeed() { }

	public InputActionReference get_keyboardYTranslateAction() { }

	public float get_keyboardYTranslateSpeed() { }

	public InputActionReference get_keyboardZTranslateAction() { }

	public float get_keyboardZTranslateSpeed() { }

	public bool get_leftControllerIsTracked() { }

	public InputTrackingState get_leftControllerTrackingState() { }

	public bool get_leftHandIsTracked() { }

	public InputActionReference get_manipulateHeadAction() { }

	public InputActionReference get_manipulateLeftAction() { }

	public InputActionReference get_manipulateRightAction() { }

	public bool get_manipulatingFPS() { }

	public bool get_manipulatingLeftController() { }

	public bool get_manipulatingLeftDevice() { }

	public bool get_manipulatingLeftHand() { }

	public bool get_manipulatingRightController() { }

	public bool get_manipulatingRightDevice() { }

	public bool get_manipulatingRightHand() { }

	public InputActionReference get_menuAction() { }

	public InputActionReference get_mouseDeltaAction() { }

	public InputActionReference get_mouseScrollAction() { }

	public float get_mouseScrollRotateSensitivity() { }

	public float get_mouseScrollTranslateSensitivity() { }

	[CompilerGenerated]
	public TransformationMode get_mouseTransformationMode() { }

	public Space get_mouseTranslateSpace() { }

	public float get_mouseXRotateSensitivity() { }

	public float get_mouseXTranslateSensitivity() { }

	public bool get_mouseYRotateInvert() { }

	public float get_mouseYRotateSensitivity() { }

	public float get_mouseYTranslateSensitivity() { }

	[CompilerGenerated]
	public bool get_negateMode() { }

	public InputActionReference get_negateModeAction() { }

	public InputActionReference get_primary2DAxisClickAction() { }

	public InputActionReference get_primary2DAxisTouchAction() { }

	public InputActionReference get_primaryButtonAction() { }

	public InputActionReference get_primaryTouchAction() { }

	public bool get_removeOtherHMDDevices() { }

	public InputActionReference get_resetAction() { }

	public InputActionReference get_restingHandAxis2DAction() { }

	public bool get_rightControllerIsTracked() { }

	public InputTrackingState get_rightControllerTrackingState() { }

	public bool get_rightHandIsTracked() { }

	public InputActionReference get_rotateModeOverrideAction() { }

	public InputActionReference get_secondary2DAxisClickAction() { }

	public InputActionReference get_secondary2DAxisTouchAction() { }

	public InputActionReference get_secondaryButtonAction() { }

	public InputActionReference get_secondaryTouchAction() { }

	public List<SimulatedHandExpression> get_simulatedHandExpressions() { }

	public InputActionReference get_stopManipulationAction() { }

	private TargetedDevices get_targetedDeviceInput() { }

	public InputActionReference get_toggleCursorLockAction() { }

	public InputActionReference get_toggleDevicePositionTargetAction() { }

	public InputActionReference get_toggleManipulateBodyAction() { }

	public InputActionReference get_toggleManipulateLeftAction() { }

	public InputActionReference get_toggleManipulateRightAction() { }

	public InputActionReference get_toggleMouseTransformationModeAction() { }

	public InputActionReference get_togglePrimary2DAxisTargetAction() { }

	public InputActionReference get_toggleSecondary2DAxisTargetAction() { }

	public InputActionReference get_triggerAction() { }

	public float get_triggerAmount() { }

	public InputActionReference get_xConstraintAction() { }

	public InputActionReference get_yConstraintAction() { }

	public InputActionReference get_zConstraintAction() { }

	private static void GetAxes(Space translateSpace, Transform cameraTransform, out Vector3 right, out Vector3 up, out Vector3 forward) { }

	private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedHandState state, in Quaternion inverseCameraParentRotation) { }

	private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedControllerState state, in Quaternion inverseCameraParentRotation) { }

	private static Quaternion GetDeltaRotation(Space translateSpace, in XRSimulatedHMDState state, in Quaternion inverseCameraParentRotation) { }

	private static Quaternion GetDeltaRotation(Space translateSpace, Quaternion rotation, in Quaternion inverseCameraParentRotation) { }

	private static InputAction GetInputAction(InputActionReference actionReference) { }

	protected Vector3 GetResetScale() { }

	private void InitializeHandSubsystem() { }

	public static TransformationMode Negate(TransformationMode mode) { }

	private CursorLockMode Negate(CursorLockMode mode) { }

	private static DeviceMode Negate(DeviceMode mode) { }

	private void OnAxis2DCanceled(CallbackContext context) { }

	private void OnAxis2DPerformed(CallbackContext context) { }

	private void OnCycleDevicesPerformed(CallbackContext context) { }

	private void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	private void OnGripCanceled(CallbackContext context) { }

	private void OnGripPerformed(CallbackContext context) { }

	private void OnHandControllerModePerformed(CallbackContext context) { }

	private void OnInputDeviceChange(InputDevice device, InputDeviceChange change) { }

	private void OnKeyboardXTranslateCanceled(CallbackContext context) { }

	private void OnKeyboardXTranslatePerformed(CallbackContext context) { }

	private void OnKeyboardYTranslateCanceled(CallbackContext context) { }

	private void OnKeyboardYTranslatePerformed(CallbackContext context) { }

	private void OnKeyboardZTranslateCanceled(CallbackContext context) { }

	private void OnKeyboardZTranslatePerformed(CallbackContext context) { }

	private void OnManipulateHeadCanceled(CallbackContext context) { }

	private void OnManipulateHeadPerformed(CallbackContext context) { }

	private void OnManipulateLeftCanceled(CallbackContext context) { }

	private void OnManipulateLeftPerformed(CallbackContext context) { }

	private void OnManipulateRightCanceled(CallbackContext context) { }

	private void OnManipulateRightPerformed(CallbackContext context) { }

	private void OnMenuCanceled(CallbackContext context) { }

	private void OnMenuPerformed(CallbackContext context) { }

	private void OnMouseDeltaCanceled(CallbackContext context) { }

	private void OnMouseDeltaPerformed(CallbackContext context) { }

	private void OnMouseScrollCanceled(CallbackContext context) { }

	private void OnMouseScrollPerformed(CallbackContext context) { }

	private void OnNegateModeCanceled(CallbackContext context) { }

	private void OnNegateModePerformed(CallbackContext context) { }

	private void OnPrimary2DAxisClickCanceled(CallbackContext context) { }

	private void OnPrimary2DAxisClickPerformed(CallbackContext context) { }

	private void OnPrimary2DAxisTouchCanceled(CallbackContext context) { }

	private void OnPrimary2DAxisTouchPerformed(CallbackContext context) { }

	private void OnPrimaryButtonCanceled(CallbackContext context) { }

	private void OnPrimaryButtonPerformed(CallbackContext context) { }

	private void OnPrimaryTouchCanceled(CallbackContext context) { }

	private void OnPrimaryTouchPerformed(CallbackContext context) { }

	private void OnResetCanceled(CallbackContext context) { }

	private void OnResetPerformed(CallbackContext context) { }

	private void OnRestingHandAxis2DCanceled(CallbackContext context) { }

	private void OnRestingHandAxis2DPerformed(CallbackContext context) { }

	private void OnRotateModeOverrideCanceled(CallbackContext context) { }

	private void OnRotateModeOverridePerformed(CallbackContext context) { }

	private void OnSecondary2DAxisClickCanceled(CallbackContext context) { }

	private void OnSecondary2DAxisClickPerformed(CallbackContext context) { }

	private void OnSecondary2DAxisTouchCanceled(CallbackContext context) { }

	private void OnSecondary2DAxisTouchPerformed(CallbackContext context) { }

	private void OnSecondaryButtonCanceled(CallbackContext context) { }

	private void OnSecondaryButtonPerformed(CallbackContext context) { }

	private void OnSecondaryTouchCanceled(CallbackContext context) { }

	private void OnSecondaryTouchPerformed(CallbackContext context) { }

	private void OnStopManipulationPerformed(CallbackContext context) { }

	private void OnToggleCursorLockPerformed(CallbackContext context) { }

	private void OnToggleDevicePositionTargetPerformed(CallbackContext context) { }

	private void OnToggleManipulateBodyPerformed(CallbackContext context) { }

	private void OnToggleManipulateLeftPerformed(CallbackContext context) { }

	private void OnToggleManipulateRightPerformed(CallbackContext context) { }

	private void OnToggleMouseTransformationModePerformed(CallbackContext context) { }

	private void OnTogglePrimary2DAxisTargetPerformed(CallbackContext context) { }

	private void OnToggleSecondary2DAxisTargetPerformed(CallbackContext context) { }

	private void OnTriggerCanceled(CallbackContext context) { }

	private void OnTriggerPerformed(CallbackContext context) { }

	private void OnXConstraintCanceled(CallbackContext context) { }

	private void OnXConstraintPerformed(CallbackContext context) { }

	private void OnYConstraintCanceled(CallbackContext context) { }

	private void OnYConstraintPerformed(CallbackContext context) { }

	private void OnZConstraintCanceled(CallbackContext context) { }

	private void OnZConstraintPerformed(CallbackContext context) { }

	protected override void ProcessAnalogButtonControlInput(ref XRSimulatedControllerState controllerState) { }

	protected override void ProcessAxis2DControlInput() { }

	protected override void ProcessButtonControlInput(ref XRSimulatedControllerState controllerState) { }

	protected override void ProcessControlInput() { }

	protected override void ProcessPoseInput() { }

	private void RemoveControllerDevices() { }

	protected override void RemoveDevices() { }

	public void set_axis2DAction(InputActionReference value) { }

	[CompilerGenerated]
	public void set_axis2DTargets(Axis2DTargets value) { }

	public void set_cameraTransform(Transform value) { }

	public void set_controllerActionAsset(InputActionAsset value) { }

	public void set_cycleDevicesAction(InputActionReference value) { }

	public void set_desiredCursorLockMode(CursorLockMode value) { }

	public void set_deviceSimulatorActionAsset(InputActionAsset value) { }

	public void set_deviceSimulatorUI(GameObject value) { }

	public void set_gripAction(InputActionReference value) { }

	public void set_gripAmount(float value) { }

	public void set_handActionAsset(InputActionAsset value) { }

	public void set_handControllerModeAction(InputActionReference value) { }

	public void set_handTrackingCapability(bool value) { }

	public void set_hmdIsTracked(bool value) { }

	public void set_hmdTrackingState(InputTrackingState value) { }

	[CompilerGenerated]
	private static void set_instance(XRDeviceSimulator value) { }

	public void set_keyboardBodyTranslateMultiplier(float value) { }

	public void set_keyboardTranslateSpace(Space value) { }

	public void set_keyboardXTranslateAction(InputActionReference value) { }

	public void set_keyboardXTranslateSpeed(float value) { }

	public void set_keyboardYTranslateAction(InputActionReference value) { }

	public void set_keyboardYTranslateSpeed(float value) { }

	public void set_keyboardZTranslateAction(InputActionReference value) { }

	public void set_keyboardZTranslateSpeed(float value) { }

	public void set_leftControllerIsTracked(bool value) { }

	public void set_leftControllerTrackingState(InputTrackingState value) { }

	public void set_leftHandIsTracked(bool value) { }

	public void set_manipulateHeadAction(InputActionReference value) { }

	public void set_manipulateLeftAction(InputActionReference value) { }

	public void set_manipulateRightAction(InputActionReference value) { }

	public void set_menuAction(InputActionReference value) { }

	public void set_mouseDeltaAction(InputActionReference value) { }

	public void set_mouseScrollAction(InputActionReference value) { }

	public void set_mouseScrollRotateSensitivity(float value) { }

	public void set_mouseScrollTranslateSensitivity(float value) { }

	[CompilerGenerated]
	public void set_mouseTransformationMode(TransformationMode value) { }

	public void set_mouseTranslateSpace(Space value) { }

	public void set_mouseXRotateSensitivity(float value) { }

	public void set_mouseXTranslateSensitivity(float value) { }

	public void set_mouseYRotateInvert(bool value) { }

	public void set_mouseYRotateSensitivity(float value) { }

	public void set_mouseYTranslateSensitivity(float value) { }

	[CompilerGenerated]
	private void set_negateMode(bool value) { }

	public void set_negateModeAction(InputActionReference value) { }

	public void set_primary2DAxisClickAction(InputActionReference value) { }

	public void set_primary2DAxisTouchAction(InputActionReference value) { }

	public void set_primaryButtonAction(InputActionReference value) { }

	public void set_primaryTouchAction(InputActionReference value) { }

	public void set_removeOtherHMDDevices(bool value) { }

	public void set_resetAction(InputActionReference value) { }

	public void set_restingHandAxis2DAction(InputActionReference value) { }

	public void set_rightControllerIsTracked(bool value) { }

	public void set_rightControllerTrackingState(InputTrackingState value) { }

	public void set_rightHandIsTracked(bool value) { }

	public void set_rotateModeOverrideAction(InputActionReference value) { }

	public void set_secondary2DAxisClickAction(InputActionReference value) { }

	public void set_secondary2DAxisTouchAction(InputActionReference value) { }

	public void set_secondaryButtonAction(InputActionReference value) { }

	public void set_secondaryTouchAction(InputActionReference value) { }

	public void set_stopManipulationAction(InputActionReference value) { }

	private void set_targetedDeviceInput(TargetedDevices value) { }

	public void set_toggleCursorLockAction(InputActionReference value) { }

	public void set_toggleDevicePositionTargetAction(InputActionReference value) { }

	public void set_toggleManipulateBodyAction(InputActionReference value) { }

	public void set_toggleManipulateLeftAction(InputActionReference value) { }

	public void set_toggleManipulateRightAction(InputActionReference value) { }

	public void set_toggleMouseTransformationModeAction(InputActionReference value) { }

	public void set_togglePrimary2DAxisTargetAction(InputActionReference value) { }

	public void set_toggleSecondary2DAxisTargetAction(InputActionReference value) { }

	public void set_triggerAction(InputActionReference value) { }

	public void set_triggerAmount(float value) { }

	public void set_xConstraintAction(InputActionReference value) { }

	public void set_yConstraintAction(InputActionReference value) { }

	public void set_zConstraintAction(InputActionReference value) { }

	private static void Subscribe(InputActionReference reference, Action<CallbackContext> performed = null, Action<CallbackContext> canceled = null) { }

	private void SubscribeAxis2DAction() { }

	private void SubscribeCycleDevicesAction() { }

	private void SubscribeGripAction() { }

	private void SubscribeHandControllerModeAction() { }

	private void SubscribeKeyboardXTranslateAction() { }

	private void SubscribeKeyboardYTranslateAction() { }

	private void SubscribeKeyboardZTranslateAction() { }

	private void SubscribeManipulateHeadAction() { }

	private void SubscribeManipulateLeftAction() { }

	private void SubscribeManipulateRightAction() { }

	private void SubscribeMenuAction() { }

	private void SubscribeMouseDeltaAction() { }

	private void SubscribeMouseScrollAction() { }

	private void SubscribeNegateModeAction() { }

	private void SubscribePrimary2DAxisClickAction() { }

	private void SubscribePrimary2DAxisTouchAction() { }

	private void SubscribePrimaryButtonAction() { }

	private void SubscribePrimaryTouchAction() { }

	private void SubscribeResetAction() { }

	private void SubscribeRestingHandAxis2DAction() { }

	private void SubscribeRotateModeOverrideAction() { }

	private void SubscribeSecondary2DAxisClickAction() { }

	private void SubscribeSecondary2DAxisTouchAction() { }

	private void SubscribeSecondaryButtonAction() { }

	private void SubscribeSecondaryTouchAction() { }

	private void SubscribeStopManipulationAction() { }

	private void SubscribeToggleCursorLockAction() { }

	private void SubscribeToggleDevicePositionTargetAction() { }

	private void SubscribeToggleManipulateBodyAction() { }

	private void SubscribeToggleManipulateLeftAction() { }

	private void SubscribeToggleManipulateRightAction() { }

	private void SubscribeToggleMouseTransformationModeAction() { }

	private void SubscribeTogglePrimary2DAxisTargetAction() { }

	private void SubscribeToggleSecondary2DAxisTargetAction() { }

	private void SubscribeTriggerAction() { }

	private void SubscribeXConstraintAction() { }

	private void SubscribeYConstraintAction() { }

	private void SubscribeZConstraintAction() { }

	private void ToggleHandExpression(SimulatedHandExpression simulatedExpression) { }

	internal static bool TryExecuteCommand(InputDeviceCommand* commandPtr, out long result) { }

	private static void Unsubscribe(InputActionReference reference, Action<CallbackContext> performed = null, Action<CallbackContext> canceled = null) { }

	private void UnsubscribeAxis2DAction() { }

	private void UnsubscribeCycleDevicesAction() { }

	private void UnsubscribeGripAction() { }

	private void UnsubscribeHandControllerModeAction() { }

	private void UnsubscribeKeyboardXTranslateAction() { }

	private void UnsubscribeKeyboardYTranslateAction() { }

	private void UnsubscribeKeyboardZTranslateAction() { }

	private void UnsubscribeManipulateHeadAction() { }

	private void UnsubscribeManipulateLeftAction() { }

	private void UnsubscribeManipulateRightAction() { }

	private void UnsubscribeMenuAction() { }

	private void UnsubscribeMouseDeltaAction() { }

	private void UnsubscribeMouseScrollAction() { }

	private void UnsubscribeNegateModeAction() { }

	private void UnsubscribePrimary2DAxisClickAction() { }

	private void UnsubscribePrimary2DAxisTouchAction() { }

	private void UnsubscribePrimaryButtonAction() { }

	private void UnsubscribePrimaryTouchAction() { }

	private void UnsubscribeResetAction() { }

	private void UnsubscribeRestingHandAxis2DAction() { }

	private void UnsubscribeRotateModeOverrideAction() { }

	private void UnsubscribeSecondary2DAxisClickAction() { }

	private void UnsubscribeSecondary2DAxisTouchAction() { }

	private void UnsubscribeSecondaryButtonAction() { }

	private void UnsubscribeSecondaryTouchAction() { }

	private void UnsubscribeStopManipulationAction() { }

	private void UnsubscribeToggleCursorLockAction() { }

	private void UnsubscribeToggleDevicePositionTargetAction() { }

	private void UnsubscribeToggleManipulateBodyAction() { }

	private void UnsubscribeToggleManipulateLeftAction() { }

	private void UnsubscribeToggleManipulateRightAction() { }

	private void UnsubscribeToggleMouseTransformationModeAction() { }

	private void UnsubscribeTogglePrimary2DAxisTargetAction() { }

	private void UnsubscribeToggleSecondary2DAxisTargetAction() { }

	private void UnsubscribeTriggerAction() { }

	private void UnsubscribeXConstraintAction() { }

	private void UnsubscribeYConstraintAction() { }

	private void UnsubscribeZConstraintAction() { }

	protected override void Update() { }

}

