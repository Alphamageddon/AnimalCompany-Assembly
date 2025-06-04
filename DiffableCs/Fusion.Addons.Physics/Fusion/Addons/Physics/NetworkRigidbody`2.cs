namespace Fusion.Addons.Physics;

[NetworkBehaviourWeaved(14)]
public abstract class NetworkRigidbody : NetworkRigidbodyBase, IStateAuthorityChanged, ISimulationExit, IBeforeAllTicks, IAfterTick
{
	protected RBType _rigidbody; //Field offset: 0x0
	protected PhysicsSimType _physicsSimulator; //Field offset: 0x0
	protected bool _originalIsKinematic; //Field offset: 0x0
	private int _remainingSimulationsCount; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"position", "rotation", "moving"}])]
	protected ValueTuple<Nullable`1<Vector3>, Nullable`1<Quaternion>, Boolean> _deferredTeleport; //Field offset: 0x0

	public RBType Rigidbody
	{
		 get { } //Length: 8
	}

	protected NetworkRigidbody`2() { }

	protected override void ApplyDeferredTeleport() { }

	protected abstract void ApplyExtras(RBType rb, ref NetworkRBData data) { }

	protected abstract void ApplyRBPositionRotation(RBType rb, Vector3 pos, Quaternion rot) { }

	protected override void Awake() { }

	protected abstract void CaptureExtras(RBType rb, ref NetworkRBData data) { }

	protected abstract void CaptureRBPositionRotation(RBType rb, ref NetworkRBData data) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	protected override void CopyToBuffer(bool captureTRSPOnly) { }

	protected override void CopyToEngine(bool predictionReset) { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	protected override void EnsureHasRunnerSimulatePhysics() { }

	protected abstract void ForceRBSleep(RBType rb) { }

	protected abstract void ForceRBWake(RBType rb) { }

	private override void Fusion.IAfterTick.AfterTick() { }

	private override void Fusion.IBeforeAllTicks.BeforeAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.ISimulationExit.SimulationExit() { }

	public RBType get_Rigidbody() { }

	protected abstract int GetRBConstraints(RBType rb) { }

	protected abstract NetworkRigidbodyFlags GetRBFlags(RBType rb) { }

	protected abstract bool GetRBIsKinematic(RBType rb) { }

	protected override void IncrementTeleportKey(bool moving) { }

	protected abstract bool IsRBSleeping(RBType rb) { }

	protected abstract bool IsRigidbodyBelowSleepingThresholds(RBType rb) { }

	protected abstract bool IsStateBelowSleepingThresholds(NetworkRBData data) { }

	protected override void OnParentNotFound() { }

	public virtual void Render() { }

	public override void ResetRigidbody() { }

	protected abstract void SetRBConstraints(RBType rb, int constraints) { }

	protected abstract void SetRBIsKinematic(RBType rb, bool kinematic) { }

	public virtual void Spawned() { }

	public override void StateAuthorityChanged() { }

	public virtual void Teleport(Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null) { }

}

