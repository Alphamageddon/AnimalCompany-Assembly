namespace Fusion.Addons.Physics;

[NetworkBehaviourWeaved(14)]
public abstract class NetworkRigidbodyBase : NetworkTRSP, INetworkTRSPTeleport
{
	[InlineHelp]
	[SerializeField]
	public bool SyncScale; //Field offset: 0x81
	[InlineHelp]
	[SerializeField]
	public bool SyncParent; //Field offset: 0x82
	[InlineHelp]
	[SerializeField]
	protected Transform _interpolationTarget; //Field offset: 0x88
	[InlineHelp]
	[SerializeField]
	public bool UsePreciseRotation; //Field offset: 0x90
	[DrawIf("_interpolationTarget", False, CompareOperator::IsZero (7), DrawIfMode::Hide (1))]
	[InlineHelp]
	[SerializeField]
	[Space]
	public bool UseRenderSleepThresholds; //Field offset: 0x91
	[DrawIf("_showSleepOptions", True, CompareOperator::Equal (0), DrawIfMode::Hide (1))]
	[InlineHelp]
	[SerializeField]
	public TRSThresholds RenderThresholds; //Field offset: 0x94
	protected Transform _transform; //Field offset: 0xA8
	protected bool _doNotInterpolate; //Field offset: 0xB0
	protected bool _clientPrediction; //Field offset: 0xB1
	protected bool _rootIsDirtyFromInterpolation; //Field offset: 0xB2
	protected bool _targIsDirtyFromInterpolation; //Field offset: 0xB3
	protected bool _aoiEnabled; //Field offset: 0xB4
	[CompilerGenerated]
	private bool <AutoSimulateIsEnabled>k__BackingField; //Field offset: 0xB5

	protected bool _showSleepOptions
	{
		 get { } //Length: 120
	}

	protected bool AutoSimulateIsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	protected NetworkRBData Data
	{
		 get { } //Length: 76
	}

	public Transform InterpolationTarget
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public abstract bool RBIsKinematic
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract Vector3 RBPosition
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract Quaternion RBRotation
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected NetworkRigidbodyBase() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	protected bool get__showSleepOptions() { }

	[CompilerGenerated]
	protected bool get_AutoSimulateIsEnabled() { }

	protected NetworkRBData get_Data() { }

	public Transform get_InterpolationTarget() { }

	public abstract bool get_RBIsKinematic() { }

	public abstract Vector3 get_RBPosition() { }

	public abstract Quaternion get_RBRotation() { }

	protected override void OnValidate() { }

	[CompilerGenerated]
	protected void set_AutoSimulateIsEnabled(bool value) { }

	public void set_InterpolationTarget(Transform value) { }

	public abstract void set_RBIsKinematic(bool value) { }

	public abstract void set_RBPosition(Vector3 value) { }

	public abstract void set_RBRotation(Quaternion value) { }

	public void SetInterpolationTarget(Transform target) { }

	public virtual void Spawned() { }

	public abstract void Teleport(Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null) { }

}

