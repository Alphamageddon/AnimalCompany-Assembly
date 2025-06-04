namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
[UsedByNativeCode]
public struct NavMeshBuildSource
{
	private Matrix4x4 m_Transform; //Field offset: 0x0
	private Vector3 m_Size; //Field offset: 0x40
	private NavMeshBuildSourceShape m_Shape; //Field offset: 0x4C
	private int m_Area; //Field offset: 0x50
	private int m_InstanceID; //Field offset: 0x54
	private int m_ComponentID; //Field offset: 0x58
	private int m_GenerateLinks; //Field offset: 0x5C

	public int area
	{
		 set { } //Length: 8
	}

	public Component component
	{
		 get { } //Length: 60
	}

	public NavMeshBuildSourceShape shape
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 size
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public object sourceObject
	{
		 get { } //Length: 60
	}

	public Matrix4x4 transform
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public Component get_component() { }

	public NavMeshBuildSourceShape get_shape() { }

	public Vector3 get_size() { }

	public object get_sourceObject() { }

	public Matrix4x4 get_transform() { }

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	private static object InternalGetObject(int instanceID) { }

	public void set_area(int value) { }

	public void set_shape(NavMeshBuildSourceShape value) { }

	public void set_size(Vector3 value) { }

	public void set_transform(Matrix4x4 value) { }

}

