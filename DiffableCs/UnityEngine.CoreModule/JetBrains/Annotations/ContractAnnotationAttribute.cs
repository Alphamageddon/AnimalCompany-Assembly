namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public sealed class ContractAnnotationAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Contract>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <ForceFullStates>k__BackingField; //Field offset: 0x18

	public ContractAnnotationAttribute(string contract) { }

	public ContractAnnotationAttribute(string contract, bool forceFullStates) { }

}

