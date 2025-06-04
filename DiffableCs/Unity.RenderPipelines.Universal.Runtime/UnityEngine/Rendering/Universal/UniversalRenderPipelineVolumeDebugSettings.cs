namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
{

	public virtual LayerMask selectedCameraLayerMask
	{
		 get { } //Length: 184
	}

	public virtual Vector3 selectedCameraPosition
	{
		 get { } //Length: 212
	}

	public virtual VolumeStack selectedCameraVolumeStack
	{
		 get { } //Length: 280
	}

	public virtual Type targetRenderPipeline
	{
		 get { } //Length: 108
	}

	public UniversalRenderPipelineVolumeDebugSettings() { }

	public virtual LayerMask get_selectedCameraLayerMask() { }

	public virtual Vector3 get_selectedCameraPosition() { }

	public virtual VolumeStack get_selectedCameraVolumeStack() { }

	public virtual Type get_targetRenderPipeline() { }

}

