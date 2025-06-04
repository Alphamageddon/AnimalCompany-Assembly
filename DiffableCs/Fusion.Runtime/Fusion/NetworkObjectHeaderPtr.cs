namespace Fusion;

public struct NetworkObjectHeaderPtr
{
	public NetworkObjectHeader* Ptr; //Field offset: 0x0

	public NetworkId Id
	{
		 get { } //Length: 28
	}

	public NetworkObjectTypeId Type
	{
		 get { } //Length: 28
	}

	public NetworkId get_Id() { }

	public NetworkObjectTypeId get_Type() { }

}

