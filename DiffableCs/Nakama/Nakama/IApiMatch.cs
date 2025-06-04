namespace Nakama;

public interface IApiMatch
{

	public bool Authoritative
	{
		 get { } //Length: 0
	}

	public string HandlerName
	{
		 get { } //Length: 0
	}

	public string Label
	{
		 get { } //Length: 0
	}

	public string MatchId
	{
		 get { } //Length: 0
	}

	public int Size
	{
		 get { } //Length: 0
	}

	public int TickRate
	{
		 get { } //Length: 0
	}

	public bool get_Authoritative() { }

	public string get_HandlerName() { }

	public string get_Label() { }

	public string get_MatchId() { }

	public int get_Size() { }

	public int get_TickRate() { }

}

