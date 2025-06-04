namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode(Optional = True)]
public class Collider2D : Behaviour
{

	public Bounds bounds
	{
		 get { } //Length: 104
	}

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

}

