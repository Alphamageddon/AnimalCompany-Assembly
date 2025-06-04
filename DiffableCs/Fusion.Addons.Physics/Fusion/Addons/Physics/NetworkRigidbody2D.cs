namespace Fusion.Addons.Physics;

[DisallowMultipleComponent]
[NetworkBehaviourWeaved(38)]
[RequireComponent(typeof(Rigidbody2D))]
public class NetworkRigidbody2D : NetworkRigidbody<Rigidbody2D, RunnerSimulatePhysics2D>
{

	public virtual bool RBIsKinematic
	{
		 get { } //Length: 28
		 set { } //Length: 32
	}

	public virtual Vector3 RBPosition
	{
		 get { } //Length: 36
		 set { } //Length: 28
	}

	public virtual Quaternion RBRotation
	{
		 get { } //Length: 60
		 set { } //Length: 72
	}

	public NetworkRigidbody2D() { }

	protected virtual void ApplyExtras(Rigidbody2D rb, ref NetworkRBData data) { }

	protected virtual void ApplyRBPositionRotation(Rigidbody2D rb, Vector3 pos, Quaternion rot) { }

	protected virtual void Awake() { }

	protected virtual void CaptureExtras(Rigidbody2D rb, ref NetworkRBData data) { }

	protected virtual void CaptureRBPositionRotation(Rigidbody2D rb, ref NetworkRBData data) { }

	protected virtual void ForceRBSleep(Rigidbody2D rb) { }

	protected virtual void ForceRBWake(Rigidbody2D rb) { }

	public virtual bool get_RBIsKinematic() { }

	public virtual Vector3 get_RBPosition() { }

	public virtual Quaternion get_RBRotation() { }

	protected virtual int GetRBConstraints(Rigidbody2D rb) { }

	protected virtual NetworkRigidbodyFlags GetRBFlags(Rigidbody2D rb) { }

	protected virtual bool GetRBIsKinematic(Rigidbody2D rb) { }

	protected virtual bool IsRBSleeping(Rigidbody2D rb) { }

	protected virtual bool IsRigidbodyBelowSleepingThresholds(Rigidbody2D rb) { }

	protected virtual bool IsStateBelowSleepingThresholds(NetworkRBData data) { }

	public virtual void ResetRigidbody() { }

	public virtual void set_RBIsKinematic(bool value) { }

	public virtual void set_RBPosition(Vector3 value) { }

	public virtual void set_RBRotation(Quaternion value) { }

	protected virtual void SetRBConstraints(Rigidbody2D rb, int constraints) { }

	protected virtual void SetRBIsKinematic(Rigidbody2D rb, bool kinematic) { }

}

