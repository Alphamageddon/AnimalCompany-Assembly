namespace UnityEngine;

[NativeHeader("Modules/Physics/RaycastHit.h")]
[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
[UsedByNativeCode]
public struct RaycastHit
{
	[NativeName("point")]
	internal Vector3 m_Point; //Field offset: 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; //Field offset: 0x18
	[NativeName("distance")]
	internal float m_Distance; //Field offset: 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; //Field offset: 0x20
	[NativeName("collider")]
	internal int m_Collider; //Field offset: 0x28

	public Collider collider
	{
		 get { } //Length: 172
	}

	public float distance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 normal
	{
		 get { } //Length: 12
	}

	public Vector3 point
	{
		 get { } //Length: 12
	}

	public Rigidbody rigidbody
	{
		 get { } //Length: 188
	}

	public Transform transform
	{
		 get { } //Length: 220
	}

	public Collider get_collider() { }

	public float get_distance() { }

	public Vector3 get_normal() { }

	public Vector3 get_point() { }

	public Rigidbody get_rigidbody() { }

	public Transform get_transform() { }

	public void set_distance(float value) { }

}

