namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public float angularDrag
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 92
		 set { } //Length: 84
	}

	public RigidbodyConstraints constraints
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool detectCollisions
	{
		 set { } //Length: 68
	}

	public float drag
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector3 inertiaTensor
	{
		 get { } //Length: 92
	}

	public bool isKinematic
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public float mass
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public Vector3 position
	{
		 get { } //Length: 92
		 set { } //Length: 84
	}

	public Quaternion rotation
	{
		 get { } //Length: 88
		 set { } //Length: 84
	}

	public bool useGravity
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Vector3 velocity
	{
		 get { } //Length: 92
		 set { } //Length: 84
	}

	public Vector3 worldCenterOfMass
	{
		 get { } //Length: 92
	}

	public Rigidbody() { }

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	public void AddTorque(Vector3 torque, ForceMode mode) { }

	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public float get_angularDrag() { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public RigidbodyConstraints get_constraints() { }

	public float get_drag() { }

	public Vector3 get_inertiaTensor() { }

	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	public bool get_isKinematic() { }

	public float get_mass() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public bool get_useGravity() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Vector3 get_worldCenterOfMass() { }

	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	public bool IsSleeping() { }

	public void MovePosition(Vector3 position) { }

	private void MovePosition_Injected(ref Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private void MoveRotation_Injected(ref Quaternion rot) { }

	public void set_angularDrag(float value) { }

	public void set_angularVelocity(Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	public void set_constraints(RigidbodyConstraints value) { }

	public void set_detectCollisions(bool value) { }

	public void set_drag(float value) { }

	public void set_isKinematic(bool value) { }

	public void set_mass(float value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void set_useGravity(bool value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

	public void Sleep() { }

	public void WakeUp() { }

}

