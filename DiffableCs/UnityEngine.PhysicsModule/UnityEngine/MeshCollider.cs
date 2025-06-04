namespace UnityEngine;

[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[RequiredByNativeCode]
public class MeshCollider : Collider
{

	public bool convex
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Mesh sharedMesh
	{
		 set { } //Length: 68
	}

	public bool get_convex() { }

	public void set_convex(bool value) { }

	public void set_sharedMesh(Mesh value) { }

}

