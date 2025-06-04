namespace Nakama;

public interface IApiMatchList
{

	public IEnumerable<IApiMatch> Matches
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiMatch> get_Matches() { }

}

