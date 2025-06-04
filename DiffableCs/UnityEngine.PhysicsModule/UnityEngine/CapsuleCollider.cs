namespace UnityEngine;

[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 92
	}

	public int direction
	{
		 get { } //Length: 60
	}

	public float height
	{
		 get { } //Length: 60
	}

	public float radius
	{
		 get { } //Length: 60
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public int get_direction() { }

	public float get_height() { }

	public float get_radius() { }

}

