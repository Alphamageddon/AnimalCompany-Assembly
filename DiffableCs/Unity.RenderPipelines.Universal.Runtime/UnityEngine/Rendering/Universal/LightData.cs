namespace UnityEngine.Rendering.Universal;

public struct LightData
{
	public int mainLightIndex; //Field offset: 0x0
	public int additionalLightsCount; //Field offset: 0x4
	public int maxPerObjectAdditionalLightsCount; //Field offset: 0x8
	public NativeArray<VisibleLight> visibleLights; //Field offset: 0x10
	public bool shadeAdditionalLightsPerVertex; //Field offset: 0x20
	public bool supportsMixedLighting; //Field offset: 0x21
	public bool reflectionProbeBoxProjection; //Field offset: 0x22
	public bool reflectionProbeBlending; //Field offset: 0x23
	public bool supportsLightLayers; //Field offset: 0x24
	public bool supportsAdditionalLights; //Field offset: 0x25

}

