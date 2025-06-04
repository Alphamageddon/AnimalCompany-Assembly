namespace Satori;

public interface IApiMessage
{

	public string ConsumeTime
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

	public string ImageUrl
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Metadata
	{
		 get { } //Length: 0
	}

	public string ReadTime
	{
		 get { } //Length: 0
	}

	public string ScheduleId
	{
		 get { } //Length: 0
	}

	public string SendTime
	{
		 get { } //Length: 0
	}

	public string Text
	{
		 get { } //Length: 0
	}

	public string Title
	{
		 get { } //Length: 0
	}

	public string UpdateTime
	{
		 get { } //Length: 0
	}

	public string get_ConsumeTime() { }

	public string get_CreateTime() { }

	public string get_Id() { }

	public string get_ImageUrl() { }

	public IDictionary<String, String> get_Metadata() { }

	public string get_ReadTime() { }

	public string get_ScheduleId() { }

	public string get_SendTime() { }

	public string get_Text() { }

	public string get_Title() { }

	public string get_UpdateTime() { }

}

