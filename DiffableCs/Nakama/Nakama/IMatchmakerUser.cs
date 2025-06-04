namespace Nakama;

public interface IMatchmakerUser
{

	public IDictionary<String, Double> NumericProperties
	{
		 get { } //Length: 0
	}

	public IUserPresence Presence
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> StringProperties
	{
		 get { } //Length: 0
	}

	public IDictionary<String, Double> get_NumericProperties() { }

	public IUserPresence get_Presence() { }

	public IDictionary<String, String> get_StringProperties() { }

}

