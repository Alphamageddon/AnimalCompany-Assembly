namespace Photon.Voice.Unity.UtilityScripts;

public class MicAmplifierFloat : IProcessor<Single>, IDisposable
{
	[CompilerGenerated]
	private float <AmplificationFactor>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Disabled>k__BackingField; //Field offset: 0x14

	public float AmplificationFactor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool Disabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public MicAmplifierFloat(float amplificationFactor) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public float get_AmplificationFactor() { }

	[CompilerGenerated]
	public bool get_Disabled() { }

	public override Single[] Process(Single[] buf) { }

	[CompilerGenerated]
	public void set_AmplificationFactor(float value) { }

	[CompilerGenerated]
	public void set_Disabled(bool value) { }

}

