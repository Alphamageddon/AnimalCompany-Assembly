namespace UnityEngine;

[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider
{

	public Vector3 center
	{
		 set { } //Length: 84
	}

	public float height
	{
		 set { } //Length: 76
	}

	public bool isGrounded
	{
		[NativeName("IsGrounded")]
		 get { } //Length: 60
	}

	public float skinWidth
	{
		 get { } //Length: 60
	}

	[NativeName("IsGrounded")]
	public bool get_isGrounded() { }

	public float get_skinWidth() { }

	public CollisionFlags Move(Vector3 motion) { }

	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_height(float value) { }

}

