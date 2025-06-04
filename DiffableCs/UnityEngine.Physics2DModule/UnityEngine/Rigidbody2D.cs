namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{

	public float angularDrag
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public float angularVelocity
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public RigidbodyType2D bodyType
	{
		 get { } //Length: 60
		[NativeMethod("SetBodyType_Binding")]
		 set { } //Length: 68
	}

	public RigidbodyConstraints2D constraints
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public float drag
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public float gravityScale
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public bool isKinematic
	{
		 get { } //Length: 72
		 set { } //Length: 76
	}

	public float mass
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector2 position
	{
		 get { } //Length: 76
		 set { } //Length: 72
	}

	public float rotation
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector2 velocity
	{
		 get { } //Length: 76
		 set { } //Length: 72
	}

	public float get_angularDrag() { }

	public float get_angularVelocity() { }

	public RigidbodyType2D get_bodyType() { }

	public RigidbodyConstraints2D get_constraints() { }

	public float get_drag() { }

	public float get_gravityScale() { }

	public bool get_isKinematic() { }

	public float get_mass() { }

	public Vector2 get_position() { }

	private void get_position_Injected(out Vector2 ret) { }

	public float get_rotation() { }

	public Vector2 get_velocity() { }

	private void get_velocity_Injected(out Vector2 ret) { }

	public bool IsSleeping() { }

	public void set_angularDrag(float value) { }

	public void set_angularVelocity(float value) { }

	[NativeMethod("SetBodyType_Binding")]
	public void set_bodyType(RigidbodyType2D value) { }

	public void set_constraints(RigidbodyConstraints2D value) { }

	public void set_drag(float value) { }

	public void set_gravityScale(float value) { }

	public void set_isKinematic(bool value) { }

	public void set_mass(float value) { }

	public void set_position(Vector2 value) { }

	private void set_position_Injected(ref Vector2 value) { }

	public void set_rotation(float value) { }

	public void set_velocity(Vector2 value) { }

	private void set_velocity_Injected(ref Vector2 value) { }

	public void Sleep() { }

	[NativeMethod("Wake")]
	public void WakeUp() { }

}

