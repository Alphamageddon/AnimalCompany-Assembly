namespace Satori;

public interface IApiExperimentList
{

	public IEnumerable<IApiExperiment> Experiments
	{
		 get { } //Length: 0
	}

	public IEnumerable<IApiExperiment> get_Experiments() { }

}

