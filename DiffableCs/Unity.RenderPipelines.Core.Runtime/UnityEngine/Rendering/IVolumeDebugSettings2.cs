namespace UnityEngine.Rendering;

public interface IVolumeDebugSettings2 : IVolumeDebugSettings
{

	public Type targetRenderPipeline
	{
		 get { } //Length: 0
	}

	public List<ValueTuple`2<String, Type>> volumeComponentsPathAndType
	{
		 get { } //Length: 0
	}

	public Type get_targetRenderPipeline() { }

	public List<ValueTuple`2<String, Type>> get_volumeComponentsPathAndType() { }

}

