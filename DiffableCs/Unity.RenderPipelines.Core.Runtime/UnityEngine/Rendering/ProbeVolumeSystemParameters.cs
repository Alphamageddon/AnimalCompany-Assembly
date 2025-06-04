namespace UnityEngine.Rendering;

public struct ProbeVolumeSystemParameters
{
	public ProbeVolumeTextureMemoryBudget memoryBudget; //Field offset: 0x0
	public ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget; //Field offset: 0x4
	public Mesh probeDebugMesh; //Field offset: 0x8
	public Shader probeDebugShader; //Field offset: 0x10
	public Mesh offsetDebugMesh; //Field offset: 0x18
	public Shader offsetDebugShader; //Field offset: 0x20
	public ComputeShader scenarioBlendingShader; //Field offset: 0x28
	public ProbeVolumeSceneData sceneData; //Field offset: 0x30
	public ProbeVolumeSHBands shBands; //Field offset: 0x38
	public bool supportsRuntimeDebug; //Field offset: 0x3C
	public bool supportStreaming; //Field offset: 0x3D

}

