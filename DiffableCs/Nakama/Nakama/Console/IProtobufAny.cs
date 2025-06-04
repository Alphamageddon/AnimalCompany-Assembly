namespace Nakama.Console;

public interface IProtobufAny
{

	public string TypeUrl
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
	}

	public string get_TypeUrl() { }

	public string get_Value() { }

}

