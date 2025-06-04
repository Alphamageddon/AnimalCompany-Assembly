namespace Nakama.Console;

public interface IApiNotification
{

	public int Code
	{
		 get { } //Length: 0
	}

	public string Content
	{
		 get { } //Length: 0
	}

	public string CreateTime
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public bool Persistent
	{
		 get { } //Length: 0
	}

	public string SenderId
	{
		 get { } //Length: 0
	}

	public string Subject
	{
		 get { } //Length: 0
	}

	public int get_Code() { }

	public string get_Content() { }

	public string get_CreateTime() { }

	public string get_Id() { }

	public bool get_Persistent() { }

	public string get_SenderId() { }

	public string get_Subject() { }

}

