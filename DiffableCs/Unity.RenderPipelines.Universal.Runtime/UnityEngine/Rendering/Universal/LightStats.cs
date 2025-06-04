namespace UnityEngine.Rendering.Universal;

internal struct LightStats
{
	public int totalLights; //Field offset: 0x0
	public int totalNormalMapUsage; //Field offset: 0x4
	public int totalVolumetricUsage; //Field offset: 0x8
	public uint blendStylesUsed; //Field offset: 0xC
	public uint blendStylesWithLights; //Field offset: 0x10

}

