namespace UnityEngine.ProBuilder;

internal sealed class MeshHandle
{
	private Transform m_Transform; //Field offset: 0x10
	private Mesh m_Mesh; //Field offset: 0x18

	public Mesh mesh
	{
		 get { } //Length: 8
	}

	public MeshHandle(Transform transform, Mesh mesh) { }

	public void DrawMeshNow(int submeshIndex) { }

	public Mesh get_mesh() { }

}

