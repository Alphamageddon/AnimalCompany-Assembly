namespace Satori;

public interface IApiUpdatePropertiesRequest
{

	public IDictionary<String, String> Custom
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> Default
	{
		 get { } //Length: 0
	}

	public bool Recompute
	{
		 get { } //Length: 0
	}

	public IDictionary<String, String> get_Custom() { }

	public IDictionary<String, String> get_Default() { }

	public bool get_Recompute() { }

}

