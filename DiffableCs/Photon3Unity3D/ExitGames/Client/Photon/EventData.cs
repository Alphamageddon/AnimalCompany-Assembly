namespace ExitGames.Client.Photon;

[DefaultMember("Item")]
public class EventData
{
	public byte Code; //Field offset: 0x10
	public readonly ParameterDictionary Parameters; //Field offset: 0x18
	public byte SenderKey; //Field offset: 0x20
	private int sender; //Field offset: 0x24
	public byte CustomDataKey; //Field offset: 0x28
	private object customData; //Field offset: 0x30

	public internal object CustomData
	{
		 get { } //Length: 56
		internal set { } //Length: 8
	}

	public internal object Item
	{
		 get { } //Length: 44
		internal set { } //Length: 28
	}

	public internal int Sender
	{
		 get { } //Length: 124
		internal set { } //Length: 8
	}

	public EventData() { }

	public object get_CustomData() { }

	public object get_Item(byte key) { }

	public int get_Sender() { }

	internal void Reset() { }

	internal void set_CustomData(object value) { }

	internal void set_Item(byte key, object value) { }

	internal void set_Sender(int value) { }

	public virtual string ToString() { }

	public string ToStringFull() { }

}

