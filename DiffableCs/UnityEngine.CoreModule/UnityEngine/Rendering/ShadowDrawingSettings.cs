namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
{
	private CullingResults m_CullingResults; //Field offset: 0x0
	private int m_LightIndex; //Field offset: 0x10
	private int m_UseRenderingLayerMaskTest; //Field offset: 0x14
	private ShadowSplitData m_SplitData; //Field offset: 0x18
	private ShadowObjectsFilter m_ObjectsFilter; //Field offset: 0x114
	private BatchCullingProjectionType m_ProjectionType; //Field offset: 0x118

	public ShadowSplitData splitData
	{
		 set { } //Length: 24
	}

	public bool useRenderingLayerMaskTest
	{
		 set { } //Length: 12
	}

	public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex, BatchCullingProjectionType projectionType) { }

	public override bool Equals(ShadowDrawingSettings other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void set_splitData(ShadowSplitData value) { }

	public void set_useRenderingLayerMaskTest(bool value) { }

}

