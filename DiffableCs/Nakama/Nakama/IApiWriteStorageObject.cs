namespace Nakama;

public interface IApiWriteStorageObject
{

	public string Collection
	{
		 get { } //Length: 0
	}

	public string Key
	{
		 get { } //Length: 0
	}

	public int PermissionRead
	{
		 get { } //Length: 0
	}

	public int PermissionWrite
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
	}

	public string Version
	{
		 get { } //Length: 0
	}

	public string get_Collection() { }

	public string get_Key() { }

	public int get_PermissionRead() { }

	public int get_PermissionWrite() { }

	public string get_Value() { }

	public string get_Version() { }

}

