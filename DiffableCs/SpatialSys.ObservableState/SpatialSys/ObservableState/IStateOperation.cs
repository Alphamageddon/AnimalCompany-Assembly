namespace SpatialSys.ObservableState;

public interface IStateOperation
{

	public OperationType opType
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int param1TypeID
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IStateObject state
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void AppendReadableDebugString(StringBuilder sb) { }

	public IStateOperation Clone() { }

	public void CopyFrom(IStateOperation op) { }

	public OperationType get_opType() { }

	public int get_param1TypeID() { }

	public IStateObject get_state() { }

	public void Reset() { }

	public void set_opType(OperationType value) { }

	public void set_param1TypeID(int value) { }

	public void set_state(IStateObject value) { }

	public ImmerPatch ToImmerPatch() { }

}

