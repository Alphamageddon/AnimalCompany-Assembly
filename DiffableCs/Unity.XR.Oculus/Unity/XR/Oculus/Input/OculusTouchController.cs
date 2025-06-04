namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}])]
[Preserve]
public class OculusTouchController : XRControllerWithRumble
{
	[CompilerGenerated]
	private Vector2Control <thumbstick>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <primaryButton>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <secondaryButton>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ButtonControl <thumbstickClicked>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private ButtonControl <primaryTouched>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private ButtonControl <secondaryTouched>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private AxisControl <triggerTouched>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private ButtonControl <thumbstickTouched>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x230

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerAcceleration"}])]
	[Preserve]
	public private Vector3Control deviceAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularAcceleration"}])]
	[Preserve]
	public private Vector3Control deviceAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerAngularVelocity"}])]
	[Preserve]
	public private Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerPosition"}])]
	[Preserve]
	public private Vector3Control devicePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerRotation"}])]
	[Preserve]
	public private QuaternionControl deviceRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerVelocity"}])]
	[Preserve]
	public private Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private AxisControl grip
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"GripButton"}])]
	[Preserve]
	public private ButtonControl gripPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"ControllerIsTracked"}])]
	[Preserve]
	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"A", "X", "Alternate"}])]
	[Preserve]
	public private ButtonControl primaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"ATouched", "XTouched", "ATouch", "XTouch"}])]
	[Preserve]
	public private ButtonControl primaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"B", "Y", "Primary"}])]
	[Preserve]
	public private ButtonControl secondaryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"BTouched", "YTouched", "BTouch", "YTouch"}])]
	[Preserve]
	public private ButtonControl secondaryTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private ButtonControl start
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"Primary2DAxis", "Joystick"}])]
	[Preserve]
	public private Vector2Control thumbstick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadPressed", "thumbstickClick"}])]
	[Preserve]
	public private ButtonControl thumbstickClicked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"JoystickOrPadTouched", "thumbstickTouch"}])]
	[Preserve]
	public private ButtonControl thumbstickTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"controllerTrackingState"}])]
	[Preserve]
	public private IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private AxisControl trigger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexButton", "indexTouched"}])]
	[Preserve]
	public private ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"indexTouch", "indexNearTouched"}])]
	[Preserve]
	public private AxisControl triggerTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public OculusTouchController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_devicePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_deviceRotation() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public AxisControl get_grip() { }

	[CompilerGenerated]
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public ButtonControl get_primaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_primaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryButton() { }

	[CompilerGenerated]
	public ButtonControl get_secondaryTouched() { }

	[CompilerGenerated]
	public ButtonControl get_start() { }

	[CompilerGenerated]
	public Vector2Control get_thumbstick() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickClicked() { }

	[CompilerGenerated]
	public ButtonControl get_thumbstickTouched() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	public AxisControl get_triggerTouched() { }

	[CompilerGenerated]
	private void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_devicePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_grip(AxisControl value) { }

	[CompilerGenerated]
	private void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_primaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryButton(ButtonControl value) { }

	[CompilerGenerated]
	private void set_secondaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_start(ButtonControl value) { }

	[CompilerGenerated]
	private void set_thumbstick(Vector2Control value) { }

	[CompilerGenerated]
	private void set_thumbstickClicked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_thumbstickTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	private void set_triggerTouched(AxisControl value) { }

}

