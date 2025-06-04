namespace Unity.XR.Oculus.Input;

[InputControlLayout(hideInUI = True, displayName = "Oculus Headset (w/ on-headset controls)")]
[Preserve]
public class OculusHMDExtended : OculusHMD
{
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; //Field offset: 0x278
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; //Field offset: 0x280

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
	public private Vector2Control touchpad
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public OculusHMDExtended() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public ButtonControl get_back() { }

	[CompilerGenerated]
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	private void set_back(ButtonControl value) { }

	[CompilerGenerated]
	private void set_touchpad(Vector2Control value) { }

}

