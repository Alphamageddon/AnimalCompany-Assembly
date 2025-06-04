namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Tracking Reference")]
[Preserve]
public class OculusTrackingReference : InputDevice
{
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x188

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

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceIsTracked"}])]
	[Preserve]
	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[InputControl(aliases = new IL2CPP_TYPE_STRING[] {"trackingReferenceTrackingState"}])]
	[Preserve]
	public private IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public OculusTrackingReference() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_devicePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_deviceRotation() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	private void set_devicePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

}

