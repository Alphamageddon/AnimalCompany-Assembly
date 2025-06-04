namespace UnityEngine.SubsystemsImplementation;

public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <id>k__BackingField; //Field offset: 0x10

	public override string id
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected SubsystemDescriptorWithProvider() { }

	internal abstract ISubsystem CreateImpl() { }

	[CompilerGenerated]
	public override string get_id() { }

	private override ISubsystem UnityEngine.ISubsystemDescriptor.Create() { }

}

