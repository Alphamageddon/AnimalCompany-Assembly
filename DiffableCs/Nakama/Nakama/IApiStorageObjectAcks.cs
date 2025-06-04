namespace Nakama;

public interface IApiStorageObjectAcks
{

	public IEnumerable<IApiStorageObjectAck> Acks
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiStorageObjectAck> get_Acks() { }

}

