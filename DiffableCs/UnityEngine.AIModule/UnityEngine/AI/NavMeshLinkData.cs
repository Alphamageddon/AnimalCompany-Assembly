namespace UnityEngine.AI;

public struct NavMeshLinkData
{
	private Vector3 m_StartPosition; //Field offset: 0x0
	private Vector3 m_EndPosition; //Field offset: 0xC
	private float m_CostModifier; //Field offset: 0x18
	private int m_Bidirectional; //Field offset: 0x1C
	private float m_Width; //Field offset: 0x20
	private int m_Area; //Field offset: 0x24
	private int m_AgentTypeID; //Field offset: 0x28

	public int agentTypeID
	{
		 set { } //Length: 8
	}

	public int area
	{
		 set { } //Length: 8
	}

	public bool bidirectional
	{
		 set { } //Length: 12
	}

	public float costModifier
	{
		 set { } //Length: 8
	}

	public Vector3 endPosition
	{
		 set { } //Length: 12
	}

	public Vector3 startPosition
	{
		 set { } //Length: 12
	}

	public float width
	{
		 set { } //Length: 8
	}

	public void set_agentTypeID(int value) { }

	public void set_area(int value) { }

	public void set_bidirectional(bool value) { }

	public void set_costModifier(float value) { }

	public void set_endPosition(Vector3 value) { }

	public void set_startPosition(Vector3 value) { }

	public void set_width(float value) { }

}

