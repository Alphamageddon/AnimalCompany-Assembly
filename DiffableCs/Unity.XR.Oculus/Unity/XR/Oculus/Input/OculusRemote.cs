namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Remote")]
[Preserve]
public class OculusRemote : InputDevice
{
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x180

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
	public private ButtonControl start
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

	public OculusRemote() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_back() { }

	[CompilerGenerated]
	public ButtonControl get_start() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	private void set_back(ButtonControl value) { }

	[CompilerGenerated]
	private void set_start(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

}

