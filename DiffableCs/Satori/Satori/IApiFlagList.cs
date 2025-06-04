namespace Satori;

public interface IApiFlagList
{

	public IEnumerable<IApiFlag> Flags
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiFlag> get_Flags() { }

}

