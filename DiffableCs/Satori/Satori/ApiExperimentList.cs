namespace Satori;

internal class ApiExperimentList : IApiExperimentList
{
	[CompilerGenerated]
	private List<ApiExperiment> <_experiments>k__BackingField; //Field offset: 0x10

	[DataMember(Name = "experiments")]
	[Preserve]
	public List<ApiExperiment> _experiments
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IEnumerable<IApiExperiment> Experiments
	{
		 get { } //Length: 120
	}

	public ApiExperimentList() { }

	[CompilerGenerated]
	public List<ApiExperiment> get__experiments() { }

	public override IEnumerable<IApiExperiment> get_Experiments() { }

	[CompilerGenerated]
	public void set__experiments(List<ApiExperiment> value) { }

	public virtual string ToString() { }

}

