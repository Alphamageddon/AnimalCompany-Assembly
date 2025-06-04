namespace Fusion;

[AddComponentMenu("Fusion/Network Object")]
[DisallowMultipleComponent]
[HelpURL("https://doc.photonengine.com/fusion/current/manual/network-object")]
[ScriptHelp(Url = "https://doc.photonengine.com/fusion/current/manual/network-object", BackColor = ScriptHeaderBackColor::Orange (5))]
public class NetworkObject : Behaviour
{
	public enum ObjectInterestModes
	{
		AreaOfInterest = 0,
		Global = 1,
		Explicit = 2,
	}

	internal sealed class PriorityLevelDelegate : MulticastDelegate
	{

		public PriorityLevelDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkObject networkObject, PlayerRef player, AsyncCallback callback, object object) { }

		public override PriorityLevel EndInvoke(IAsyncResult result) { }

		public override PriorityLevel Invoke(NetworkObject networkObject, PlayerRef player) { }

	}

	internal sealed class ReplicateToDelegate : MulticastDelegate
	{

		public ReplicateToDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkObject networkObject, PlayerRef player, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(NetworkObject networkObject, PlayerRef player) { }

	}

	internal Int32* Ptr; //Field offset: 0x20
	public bool IsResume; //Field offset: 0x28
	private NetworkRunner _runner; //Field offset: 0x30
	internal NetworkObjectMeta Meta; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	public uint SortKey; //Field offset: 0x40
	[Obsolete("not used anymore, use interest management instead")]
	public ReplicateToDelegate ReplicateTo; //Field offset: 0x48
	public PriorityLevelDelegate PriorityCallback; //Field offset: 0x50
	[FormerlySerializedAs("AoiMode")]
	[InlineHelp]
	[SerializeField]
	internal ObjectInterestModes ObjectInterest; //Field offset: 0x58
	[InlineHelp]
	public NetworkObjectFlags Flags; //Field offset: 0x5C
	internal NetworkObjectRuntimeFlags RuntimeFlags; //Field offset: 0x60
	public NetworkObjectTypeId NetworkTypeId; //Field offset: 0x64
	[InlineHelp]
	public NetworkObject[] NestedObjects; //Field offset: 0x70
	[InlineHelp]
	public NetworkBehaviour[] NetworkedBehaviours; //Field offset: 0x78
	private RenderSource _renderSource; //Field offset: 0x80

	internal Int32* BehaviourChangedTickArray
	{
		internal get { } //Length: 52
	}

	public bool HasInputAuthority
	{
		 get { } //Length: 224
	}

	public bool HasStateAuthority
	{
		 get { } //Length: 144
	}

	internal NetworkObjectHeader* Header
	{
		internal get { } //Length: 8
	}

	public NetworkId Id
	{
		 get { } //Length: 24
	}

	public PlayerRef InputAuthority
	{
		 get { } //Length: 120
	}

	public bool IsInSimulation
	{
		 get { } //Length: 12
	}

	public bool IsProxy
	{
		 get { } //Length: 340
	}

	public bool IsSpawnable
	{
		 get { } //Length: 16
		 set { } //Length: 4
	}

	public bool IsValid
	{
		 get { } //Length: 136
	}

	public Tick LastReceiveTick
	{
		 get { } //Length: 32
	}

	public string Name
	{
		 get { } //Length: 232
	}

	public RenderSource RenderSource
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float RenderTime
	{
		 get { } //Length: 168
	}

	public RenderTimeframe RenderTimeframe
	{
		 get { } //Length: 144
	}

	public NetworkRunner Runner
	{
		 get { } //Length: 8
	}

	private Simulation Simulation
	{
		private get { } //Length: 124
	}

	public PlayerRef StateAuthority
	{
		 get { } //Length: 132
	}

	public NetworkObject() { }

	public void AssignInputAuthority(PlayerRef player) { }

	protected override void Awake() { }

	public void CopyStateFrom(NetworkObjectHeaderPtr source) { }

	public void CopyStateFrom(NetworkObject source) { }

	[Conditional("DEBUG")]
	internal void DebugNotifyDespawning() { }

	[Conditional("DEBUG")]
	internal void DebugNotifySpawned() { }

	internal void Defaults() { }

	internal Int32* get_BehaviourChangedTickArray() { }

	public bool get_HasInputAuthority() { }

	public bool get_HasStateAuthority() { }

	internal NetworkObjectHeader* get_Header() { }

	public NetworkId get_Id() { }

	public PlayerRef get_InputAuthority() { }

	public bool get_IsInSimulation() { }

	public bool get_IsProxy() { }

	public bool get_IsSpawnable() { }

	public bool get_IsValid() { }

	public Tick get_LastReceiveTick() { }

	public string get_Name() { }

	public RenderSource get_RenderSource() { }

	public float get_RenderTime() { }

	public RenderTimeframe get_RenderTimeframe() { }

	public NetworkRunner get_Runner() { }

	private Simulation get_Simulation() { }

	public PlayerRef get_StateAuthority() { }

	protected private virtual void GetDumpString(StringBuilder builder) { }

	public int GetLocalAuthorityMask() { }

	internal int GetRpcSourceAuthorityMask(PlayerRef player) { }

	public static int GetWordCount(NetworkObject obj) { }

	internal void MakeOwned(NetworkRunner runner) { }

	internal void MakeUnowned() { }

	[NetworkDeserializeMethod]
	public static void NetworkUnwrap(NetworkRunner runner, NetworkId wrapper, ref NetworkObject result) { }

	[NetworkSerializeMethod]
	public static NetworkId NetworkWrap(NetworkObject obj) { }

	[Obsolete("Use NetworkWrap(NetworkObject) instead")]
	public static NetworkId NetworkWrap(NetworkRunner runner, NetworkObject obj) { }

	protected override void OnDestroy() { }

	private void OnDestroyInternal() { }

	internal void OnDestroyNeverActive() { }

	public static NetworkId op_Implicit(NetworkObject obj) { }

	internal void PrepareBehaviourOrder() { }

	public void ReleaseStateAuthority() { }

	public void RemoveInputAuthority() { }

	public void RequestStateAuthority() { }

	internal void ResetNetworkState() { }

	public void set_IsSpawnable(bool value) { }

	public void set_RenderSource(RenderSource value) { }

	public void SetPlayerAlwaysInterested(PlayerRef player, bool alwaysInterested) { }

}

