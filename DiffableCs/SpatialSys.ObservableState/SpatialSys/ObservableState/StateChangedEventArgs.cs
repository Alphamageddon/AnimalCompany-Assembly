namespace SpatialSys.ObservableState;

public struct StateChangedEventArgs
{
	[CompilerGenerated]
	private readonly bool <initialize>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IReadOnlyList<IStateOperation> <operations>k__BackingField; //Field offset: 0x8

	public bool initialize
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public IReadOnlyList<IStateOperation> operations
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public StateChangedEventArgs(bool initialize, IReadOnlyList<IStateOperation> operations) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_initialize() { }

	[CompilerGenerated]
	[IsReadOnly]
	public IReadOnlyList<IStateOperation> get_operations() { }

}

