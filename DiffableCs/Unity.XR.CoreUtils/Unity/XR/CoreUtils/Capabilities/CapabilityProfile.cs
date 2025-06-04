namespace Unity.XR.CoreUtils.Capabilities;

public abstract class CapabilityProfile : ScriptableObject
{
	[CompilerGenerated]
	private static Action<CapabilityProfile> CapabilityChanged; //Field offset: 0x0

	public static event Action<CapabilityProfile> CapabilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 204
		[CompilerGenerated]
		 remove { } //Length: 204
	}

	protected CapabilityProfile() { }

	[CompilerGenerated]
	public static void add_CapabilityChanged(Action<CapabilityProfile> value) { }

	[CompilerGenerated]
	public static void remove_CapabilityChanged(Action<CapabilityProfile> value) { }

	public void ReportCapabilityChanged() { }

}

