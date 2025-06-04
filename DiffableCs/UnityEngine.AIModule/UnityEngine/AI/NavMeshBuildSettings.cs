namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
public struct NavMeshBuildSettings
{
	private int m_AgentTypeID; //Field offset: 0x0
	private float m_AgentRadius; //Field offset: 0x4
	private float m_AgentHeight; //Field offset: 0x8
	private float m_AgentSlope; //Field offset: 0xC
	private float m_AgentClimb; //Field offset: 0x10
	private float m_LedgeDropHeight; //Field offset: 0x14
	private float m_MaxJumpAcrossDistance; //Field offset: 0x18
	private float m_MinRegionArea; //Field offset: 0x1C
	private int m_OverrideVoxelSize; //Field offset: 0x20
	private float m_VoxelSize; //Field offset: 0x24
	private int m_OverrideTileSize; //Field offset: 0x28
	private int m_TileSize; //Field offset: 0x2C
	private int m_BuildHeightMesh; //Field offset: 0x30
	private uint m_MaxJobWorkers; //Field offset: 0x34
	private int m_PreserveTilesOutsideBounds; //Field offset: 0x38
	private NavMeshBuildDebugSettings m_Debug; //Field offset: 0x3C

	public float agentRadius
	{
		 get { } //Length: 8
	}

	public int agentTypeID
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool buildHeightMesh
	{
		 set { } //Length: 12
	}

	public float minRegionArea
	{
		 set { } //Length: 8
	}

	public bool overrideTileSize
	{
		 set { } //Length: 12
	}

	public bool overrideVoxelSize
	{
		 set { } //Length: 12
	}

	public int tileSize
	{
		 set { } //Length: 8
	}

	public float voxelSize
	{
		 set { } //Length: 8
	}

	public float get_agentRadius() { }

	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public void set_buildHeightMesh(bool value) { }

	public void set_minRegionArea(float value) { }

	public void set_overrideTileSize(bool value) { }

	public void set_overrideVoxelSize(bool value) { }

	public void set_tileSize(int value) { }

	public void set_voxelSize(float value) { }

}

