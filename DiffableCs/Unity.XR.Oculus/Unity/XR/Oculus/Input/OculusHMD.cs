namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset")]
[Preserve]
public class OculusHMD : XRHMD
{
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private Vector3Control <leftEyeAcceleration>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularAcceleration>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	private Vector3Control <rightEyeAcceleration>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularAcceleration>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	private Vector3Control <centerEyePosition>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	private QuaternionControl <centerEyeRotation>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x260
	[CompilerGenerated]
	private Vector3Control <centerEyeAcceleration>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularAcceleration>k__BackingField; //Field offset: 0x270

	[InputControl]
	[Preserve]
	public private Vector3Control centerEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control centerEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control centerEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control centerEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private QuaternionControl centerEyeRotation
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

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"deviceistracked"}])]
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
	public private Vector3Control leftEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control leftEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control leftEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control leftEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private QuaternionControl leftEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control rightEyeAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control rightEyeAngularAcceleration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control rightEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private Vector3Control rightEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl]
	[Preserve]
	public private QuaternionControl rightEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"devicetrackingstate"}])]
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
	public private ButtonControl userPresence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public OculusHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_centerEyeRotation() { }

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
	public Vector3Control get_leftEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularAcceleration() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_rightEyeRotation() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	private void set_centerEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyeRotation(QuaternionControl value) { }

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
	private void set_leftEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_rightEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	private void set_userPresence(ButtonControl value) { }

}

