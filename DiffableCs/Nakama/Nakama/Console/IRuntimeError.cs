namespace Nakama.Console;

public interface IRuntimeError
{

	public int Code
	{
		 get { } //Length: 0
	}

	public IEnumerable<IProtobufAny> Details
	{
		 get { } //Length: 0
	}

	public string Error
	{
		 get { } //Length: 0
	}

	public string Message
	{
		 get { } //Length: 0
	}

	public int get_Code() { }

	public IEnumerable<IProtobufAny> get_Details() { }

	public string get_Error() { }

	public string get_Message() { }

}

