namespace Fusion;

[DefaultMember("Item")]
public interface INetworkArray : IEnumerable
{

	public object Item
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object get_Item(int index) { }

	public void set_Item(int index, object value) { }

}

