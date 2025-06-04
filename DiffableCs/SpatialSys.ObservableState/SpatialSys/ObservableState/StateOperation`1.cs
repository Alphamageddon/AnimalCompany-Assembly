namespace SpatialSys.ObservableState;

public class StateOperation : IStateOperation
{
	private const string REDACTED_VALUE_STRING = "[REDACTED]"; //Field offset: 0x0
	private const string NULL_VALUE_STRING = "null"; //Field offset: 0x0
	[CompilerGenerated]
	private IStateObject <state>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private OperationType <opType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private T <param1>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <param1TypeID>k__BackingField; //Field offset: 0x0

	public override OperationType opType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public T param1
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public override int param1TypeID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IStateObject state
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StateOperation`1() { }

	public StateOperation`1(IStateObject state, OperationType opType, T param1, int param1TypeID) { }

	public override void AppendReadableDebugString(StringBuilder sb) { }

	public override IStateOperation Clone() { }

	public override void CopyFrom(IStateOperation other) { }

	[CompilerGenerated]
	public override OperationType get_opType() { }

	[CompilerGenerated]
	public T get_param1() { }

	[CompilerGenerated]
	public override int get_param1TypeID() { }

	[CompilerGenerated]
	public override IStateObject get_state() { }

	public override void Reset() { }

	[CompilerGenerated]
	public override void set_opType(OperationType value) { }

	[CompilerGenerated]
	public void set_param1(T value) { }

	[CompilerGenerated]
	public override void set_param1TypeID(int value) { }

	[CompilerGenerated]
	public override void set_state(IStateObject value) { }

	public override ImmerPatch ToImmerPatch() { }

	public virtual string ToString() { }

}

