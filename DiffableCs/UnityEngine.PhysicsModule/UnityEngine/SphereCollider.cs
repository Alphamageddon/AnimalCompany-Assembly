namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequiredByNativeCode]
public class SphereCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 92
	}

	public float radius
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public float get_radius() { }

	public void set_radius(float value) { }

}

