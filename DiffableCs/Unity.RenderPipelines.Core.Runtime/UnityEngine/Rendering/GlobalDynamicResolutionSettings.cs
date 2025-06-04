namespace UnityEngine.Rendering;

public struct GlobalDynamicResolutionSettings
{
	public bool enabled; //Field offset: 0x0
	public bool useMipBias; //Field offset: 0x1
	public bool enableDLSS; //Field offset: 0x2
	public uint DLSSPerfQualitySetting; //Field offset: 0x4
	public UpsamplerScheduleType DLSSInjectionPoint; //Field offset: 0x8
	public bool DLSSUseOptimalSettings; //Field offset: 0xC
	[Range(0, 1)]
	public float DLSSSharpness; //Field offset: 0x10
	public bool fsrOverrideSharpness; //Field offset: 0x14
	[Range(0, 1)]
	public float fsrSharpness; //Field offset: 0x18
	public float maxPercentage; //Field offset: 0x1C
	public float minPercentage; //Field offset: 0x20
	public DynamicResolutionType dynResType; //Field offset: 0x24
	public DynamicResUpscaleFilter upsampleFilter; //Field offset: 0x25
	public bool forceResolution; //Field offset: 0x26
	public float forcedPercentage; //Field offset: 0x28
	public float lowResTransparencyMinimumThreshold; //Field offset: 0x2C
	public float rayTracingHalfResThreshold; //Field offset: 0x30
	public float lowResSSGIMinimumThreshold; //Field offset: 0x34
	public float lowResVolumetricCloudsMinimumThreshold; //Field offset: 0x38

	public static GlobalDynamicResolutionSettings NewDefault() { }

}

