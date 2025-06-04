namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
public struct NavMeshHit
{
	private Vector3 m_Position; //Field offset: 0x0
	private Vector3 m_Normal; //Field offset: 0xC
	private float m_Distance; //Field offset: 0x18
	private int m_Mask; //Field offset: 0x1C
	private int m_Hit; //Field offset: 0x20

	public Vector3 position
	{
		 get { } //Length: 12
	}

	public Vector3 get_position() { }

}

