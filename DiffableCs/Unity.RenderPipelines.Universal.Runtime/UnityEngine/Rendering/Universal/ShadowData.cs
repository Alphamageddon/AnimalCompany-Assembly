namespace UnityEngine.Rendering.Universal;

public struct ShadowData
{
	public bool supportsMainLightShadows; //Field offset: 0x0
	internal bool mainLightShadowsEnabled; //Field offset: 0x1
	[Obsolete("Obsolete, this feature was replaced by new 'ScreenSpaceShadows' renderer feature")]
	public bool requiresScreenSpaceShadowResolve; //Field offset: 0x2
	public int mainLightShadowmapWidth; //Field offset: 0x4
	public int mainLightShadowmapHeight; //Field offset: 0x8
	public int mainLightShadowCascadesCount; //Field offset: 0xC
	public Vector3 mainLightShadowCascadesSplit; //Field offset: 0x10
	public float mainLightShadowCascadeBorder; //Field offset: 0x1C
	public bool supportsAdditionalLightShadows; //Field offset: 0x20
	internal bool additionalLightShadowsEnabled; //Field offset: 0x21
	public int additionalLightsShadowmapWidth; //Field offset: 0x24
	public int additionalLightsShadowmapHeight; //Field offset: 0x28
	public bool supportsSoftShadows; //Field offset: 0x2C
	public int shadowmapDepthBufferBits; //Field offset: 0x30
	public List<Vector4> bias; //Field offset: 0x38
	public List<Int32> resolution; //Field offset: 0x40
	internal bool isKeywordAdditionalLightShadowsEnabled; //Field offset: 0x48
	internal bool isKeywordSoftShadowsEnabled; //Field offset: 0x49

}

