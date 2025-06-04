namespace Fusion.Addons.Physics;

[DisallowMultipleComponent]
[NetworkBehaviourWeaved(38)]
[RequireComponent(typeof(Rigidbody))]
public class NetworkRigidbody3D : NetworkRigidbody<Rigidbody, RunnerSimulatePhysics3D>
{

	public virtual bool RBIsKinematic
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public virtual Vector3 RBPosition
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public virtual Quaternion RBRotation
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public NetworkRigidbody3D() { }

	protected virtual void ApplyExtras(Rigidbody rb, ref NetworkRBData data) { }

	protected virtual void ApplyRBPositionRotation(Rigidbody rb, Vector3 pos, Quaternion rot) { }

	protected virtual void Awake() { }

	protected virtual void CaptureExtras(Rigidbody rb, ref NetworkRBData data) { }

	protected virtual void CaptureRBPositionRotation(Rigidbody rb, ref NetworkRBData data) { }

	protected virtual void ForceRBSleep(Rigidbody rb) { }

	protected virtual void ForceRBWake(Rigidbody rb) { }

	public virtual bool get_RBIsKinematic() { }

	public virtual Vector3 get_RBPosition() { }

	public virtual Quaternion get_RBRotation() { }

	protected virtual int GetRBConstraints(Rigidbody rb) { }

	protected virtual NetworkRigidbodyFlags GetRBFlags(Rigidbody rb) { }

	protected virtual bool GetRBIsKinematic(Rigidbody rb) { }

	protected virtual bool IsRBSleeping(Rigidbody rb) { }

	protected virtual bool IsRigidbodyBelowSleepingThresholds(Rigidbody rb) { }

	protected virtual bool IsStateBelowSleepingThresholds(NetworkRBData data) { }

	public virtual void ResetRigidbody() { }

	public virtual void set_RBIsKinematic(bool value) { }

	public virtual void set_RBPosition(Vector3 value) { }

	public virtual void set_RBRotation(Quaternion value) { }

	protected virtual void SetRBConstraints(Rigidbody rb, int constraints) { }

	protected virtual void SetRBIsKinematic(Rigidbody rb, bool kinematic) { }

}

