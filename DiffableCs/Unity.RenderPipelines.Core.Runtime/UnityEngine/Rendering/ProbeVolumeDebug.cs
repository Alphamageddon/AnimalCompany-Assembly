namespace UnityEngine.Rendering;

internal class ProbeVolumeDebug : IDebugData
{
	public bool drawProbes; //Field offset: 0x10
	public bool drawBricks; //Field offset: 0x11
	public bool drawCells; //Field offset: 0x12
	public bool realtimeSubdivision; //Field offset: 0x13
	public int subdivisionCellUpdatePerFrame; //Field offset: 0x14
	public float subdivisionDelayInSeconds; //Field offset: 0x18
	public DebugProbeShadingMode probeShading; //Field offset: 0x1C
	public float probeSize; //Field offset: 0x20
	public float subdivisionViewCullingDistance; //Field offset: 0x24
	public float probeCullingDistance; //Field offset: 0x28
	public int maxSubdivToVisualize; //Field offset: 0x2C
	public int minSubdivToVisualize; //Field offset: 0x30
	public float exposureCompensation; //Field offset: 0x34
	public bool drawVirtualOffsetPush; //Field offset: 0x38
	public float offsetSize; //Field offset: 0x3C
	public bool freezeStreaming; //Field offset: 0x40
	public int otherStateIndex; //Field offset: 0x44

	public ProbeVolumeDebug() { }

	[CompilerGenerated]
	private void <GetReset>b__19_0() { }

	public override Action GetReset() { }

	private void Init() { }

}

