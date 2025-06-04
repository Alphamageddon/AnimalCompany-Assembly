namespace UnityEngine;

[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequiredByNativeCode]
public class BoxCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 92
		 set { } //Length: 84
	}

	public Vector3 size
	{
		 get { } //Length: 92
		 set { } //Length: 84
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public Vector3 get_size() { }

	private void get_size_Injected(out Vector3 ret) { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_size(Vector3 value) { }

	private void set_size_Injected(ref Vector3 value) { }

}

