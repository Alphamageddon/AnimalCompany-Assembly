namespace Unity.XR.Oculus.Input;

[InputControlLayout(hideInUI = True, displayName = "GearVR Controller", commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}])]
[Preserve]
public class GearVRTrackedController : XRController
{
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1F0

	[InputControl]
	[Preserve]
	public private ButtonControl back
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control deviceAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control deviceAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control devicePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private QuaternionControl deviceRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private ButtonControl touchpadClicked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private ButtonControl touchpadTouched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
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

	[InputControl]
	[Preserve]
	public private ButtonControl triggerPressed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GearVRTrackedController() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_back() { }

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
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	private void set_back(ButtonControl value) { }

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
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	private void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	private void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	private void set_triggerPressed(ButtonControl value) { }

}

