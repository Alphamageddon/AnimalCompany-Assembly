namespace Satori;

public interface IApiFlag
{

	public bool ConditionChanged
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public string Value
	{
		 get { } //Length: 0
	}

	public bool get_ConditionChanged() { }

	public string get_Name() { }

	public string get_Value() { }

}

