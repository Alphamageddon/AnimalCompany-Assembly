namespace SpatialSys.ObservableState;

public interface IStatePrimitive : IStateObject
{

	public byte syncRate
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Type valueType
	{
		 get { } //Length: 0
	}

	public int valueTypeID
	{
		 get { } //Length: 0
	}

	public IStateOperation AllocateSetOperationWithCurrentValue(StateOperationPool pool) { }

	public byte get_syncRate() { }

	public Type get_valueType() { }

	public int get_valueTypeID() { }

	public object GetValue() { }

	public void set_syncRate(byte value) { }

	public void SetValue(object value) { }

}

