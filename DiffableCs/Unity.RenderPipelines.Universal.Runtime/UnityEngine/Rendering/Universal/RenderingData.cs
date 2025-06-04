namespace UnityEngine.Rendering.Universal;

public struct RenderingData
{
	internal CommandBuffer commandBuffer; //Field offset: 0x0
	public CullingResults cullResults; //Field offset: 0x8
	public CameraData cameraData; //Field offset: 0x18
	public LightData lightData; //Field offset: 0x228
	public ShadowData shadowData; //Field offset: 0x250
	public PostProcessingData postProcessingData; //Field offset: 0x2A0
	public bool supportsDynamicBatching; //Field offset: 0x2AC
	public PerObjectData perObjectData; //Field offset: 0x2B0
	public bool postProcessingEnabled; //Field offset: 0x2B4

}

