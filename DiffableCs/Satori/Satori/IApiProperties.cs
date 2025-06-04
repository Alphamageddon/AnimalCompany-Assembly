namespace Satori;

public interface IApiProperties
{

	public IDictionary<String, String> Computed
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Custom
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Default
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> get_Computed() { }

	public IDictionary<String, String> get_Custom() { }

	public IDictionary<String, String> get_Default() { }

}

