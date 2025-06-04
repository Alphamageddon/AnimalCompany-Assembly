namespace Nakama.Console;

public interface IStatusListStatus
{

	public double AvgInputKbs
	{
		 get { } //Length: 0
	}

	public double AvgLatencyMs
	{
		 get { } //Length: 0
	}

	public double AvgOutputKbs
	{
		 get { } //Length: 0
	}

	public double AvgRateSec
	{
		 get { } //Length: 0
	}

	public int GoroutineCount
	{
		 get { } //Length: 0
	}

	public int Health
	{
		 get { } //Length: 0
	}

	public int MatchCount
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public int PresenceCount
	{
		 get { } //Length: 0
	}

	public int SessionCount
	{
		 get { } //Length: 0
	}

	public double get_AvgInputKbs() { }

	public double get_AvgLatencyMs() { }

	public double get_AvgOutputKbs() { }

	public double get_AvgRateSec() { }

	public int get_GoroutineCount() { }

	public int get_Health() { }

	public int get_MatchCount() { }

	public string get_Name() { }

	public int get_PresenceCount() { }

	public int get_SessionCount() { }

}

