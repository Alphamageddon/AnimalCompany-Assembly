namespace Fusion;

[DisallowMultipleComponent]
[NetworkBehaviourWeaved(14)]
public sealed class NetworkTransform : NetworkTRSP, INetworkTRSPTeleport, IBeforeAllTicks, IAfterAllTicks, IBeforeCopyPreviousState
{
	[InlineHelp]
	[SerializeField]
	public bool SyncScale; //Field offset: 0x81
	[InlineHelp]
	[SerializeField]
	public bool SyncParent; //Field offset: 0x82
	private Tick _initial; //Field offset: 0x84
	private Transform _transform; //Field offset: 0x88
	private bool _simulation; //Field offset: 0x90
	private bool _aoiEnabled; //Field offset: 0x91
	private bool _aoiAutoUpdateOriginal; //Field offset: 0x92
	[InlineHelp]
	[SerializeField]
	private bool _autoAOIOverride; //Field offset: 0x93
	[InlineHelp]
	[SerializeField]
	public bool DisableSharedModeInterpolation; //Field offset: 0x94
	private bool _render; //Field offset: 0x95
	private Vector3 _renderPosition; //Field offset: 0x98
	private Quaternion _renderRotation; //Field offset: 0xA4

	public bool AutoUpdateAreaOfInterestOverride
	{
		 get { } //Length: 8
		 set { } //Length: 16
	}

	public NetworkTransform() { }

	private void Awake() { }

	private void CopyToBuffer() { }

	private void CopyToEngine() { }

	private override void Fusion.IAfterAllTicks.AfterAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.IBeforeAllTicks.BeforeAllTicks(bool resimulation, int tickCount) { }

	private override void Fusion.IBeforeCopyPreviousState.BeforeCopyPreviousState() { }

	public bool get_AutoUpdateAreaOfInterestOverride() { }

	public virtual void Render() { }

	public void set_AutoUpdateAreaOfInterestOverride(bool value) { }

	public virtual void SetAreaOfInterestOverride(NetworkObject obj) { }

	public virtual void Spawned() { }

	public override void Teleport(Nullable<Vector3> position = null, Nullable<Quaternion> rotation = null) { }

}

