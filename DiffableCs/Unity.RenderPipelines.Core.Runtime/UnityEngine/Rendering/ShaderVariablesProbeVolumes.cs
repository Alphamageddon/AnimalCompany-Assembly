namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.11\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs", needAccessors = False, generateCBuffer = True, constantRegister = 5)]
internal struct ShaderVariablesProbeVolumes
{
	public Vector4 _PoolDim_CellInMeters; //Field offset: 0x0
	public Vector4 _MinCellPos_Noise; //Field offset: 0x10
	public Vector4 _IndicesDim_IndexChunkSize; //Field offset: 0x20
	public Vector4 _Biases_CellInMinBrick_MinBrickSize; //Field offset: 0x30
	public Vector4 _LeakReductionParams; //Field offset: 0x40
	public Vector4 _Weight_MinLoadedCell; //Field offset: 0x50
	public Vector4 _MaxLoadedCell_FrameIndex; //Field offset: 0x60
	public Vector4 _NormalizationClamp_Padding12; //Field offset: 0x70

}

