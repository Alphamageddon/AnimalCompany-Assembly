namespace Unity.XR.CoreUtils;

public interface IComponentHost
{

	public THostType[] HostedComponents
	{
		 get { } //Length: 0
	}

	public THostType[] get_HostedComponents() { }

}

