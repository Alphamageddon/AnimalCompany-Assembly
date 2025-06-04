namespace UnityEngine.AI;

[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public sealed class NavMeshData : object
{

	public Vector3 position
	{
		 set { } //Length: 84
	}

	public Quaternion rotation
	{
		 set { } //Length: 84
	}

	public NavMeshData(int agentTypeID) { }

	[StaticAccessor("NavMeshDataBindings", StaticAccessorType::DoubleColon (2))]
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

}

