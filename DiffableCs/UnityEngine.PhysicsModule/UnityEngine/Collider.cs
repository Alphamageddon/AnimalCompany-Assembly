namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public class Collider : Component
{

	public Rigidbody attachedRigidbody
	{
		[NativeMethod("GetRigidbody")]
		 get { } //Length: 60
	}

	public Bounds bounds
	{
		 get { } //Length: 104
	}

	public bool enabled
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public LayerMask includeLayers
	{
		 set { } //Length: 72
	}

	public bool isTrigger
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	[NativeMethod("GetRigidbody")]
	public Rigidbody get_attachedRigidbody() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	public bool get_isTrigger() { }

	public void set_enabled(bool value) { }

	public void set_includeLayers(LayerMask value) { }

	private void set_includeLayers_Injected(ref LayerMask value) { }

	public void set_isTrigger(bool value) { }

}

