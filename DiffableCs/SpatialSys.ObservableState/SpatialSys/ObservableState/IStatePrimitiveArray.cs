namespace SpatialSys.ObservableState;

[DefaultMember("Item")]
public interface IStatePrimitiveArray : IStatePrimitive, IStateObject
{

	public object Item
	{
		 get { } //Length: 0
	}

	public int Length
	{
		 get { } //Length: 0
	}

	public string ContentsToString() { }

	public string ContentsToString(object value) { }

	public object get_Item(int index) { }

	public int get_Length() { }

	public object GetValueAsArray() { }

	public bool ValueEquals(IStatePrimitiveArray other) { }

}

