namespace RSG;

public interface IPendingPromise : IRejectable
{

	public int Id
	{
		 get { } //Length: 0
	}

	public int get_Id() { }

	public void ReportProgress(float progress) { }

	public void Resolve() { }

}

