namespace AnimalCompany;

[DefaultExecutionOrder(101)]
[NetworkBehaviourWeaved(26)]
public class NetPlayer : NetworkBehaviour, IDamageable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NetPlayer, Boolean> <>9__50_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_localPlayer>b__50_0(NetPlayer p) { }

	}

	[CompilerGenerated]
	private sealed class <RemoteVoiceVolumeUpdater>d__86 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetPlayer <>4__this; //Field offset: 0x20
		private Single[] <sampleData>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <RemoteVoiceVolumeUpdater>d__86(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <VoiceVolumeUpdater>d__85 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NetPlayer <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <VoiceVolumeUpdater>d__85(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const string EDITOR_PREFS_MIC_ENABLED = "AC_MIC_ENABLED"; //Field offset: 0x0
	private const float VOICE_VOLUME_DETECTION_MULT = 5; //Field offset: 0x0
	private static Dictionary<UInt32, NetPlayer> _spawnedPlayers; //Field offset: 0x0
	public const int EXECUTION_ORDER = 101; //Field offset: 0x0
	private static NetPlayer _localPlayer; //Field offset: 0x8
	public VoiceNetworkObject voiceNetworkObject; //Field offset: 0x80
	public Transform head; //Field offset: 0x88
	public Transform handLeft; //Field offset: 0x90
	public Transform handRight; //Field offset: 0x98
	public Transform backAttachAnchor; //Field offset: 0xA0
	[SerializeField]
	private PlayerView _view; //Field offset: 0xA8
	[SerializeField]
	private Recorder _recorder; //Field offset: 0xB0
	[SerializeField]
	private Speaker _speaker; //Field offset: 0xB8
	[SerializeField]
	private HandInteractor[] _interactors; //Field offset: 0xC0
	[SerializeField]
	private AttachedItemAnchor[] _attachedItemAnchors; //Field offset: 0xC8
	[SerializeField]
	private Nametag _nametag; //Field offset: 0xD0
	[DefaultForProperty("Token", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _Token; //Field offset: 0xD8
	[DefaultForProperty("playerColor", 1, 4)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private Color _playerColor; //Field offset: 0xDC
	[DefaultForProperty("isDie", 5, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isDie; //Field offset: 0xEC
	[DefaultForProperty("displayName", 6, 18)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private string _displayName; //Field offset: 0xF0
	[DefaultForProperty("channel", 24, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _channel; //Field offset: 0xF8
	[DefaultForProperty("playerVolume", 25, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private float _playerVolume; //Field offset: 0xFC
	private ChangeDetector _changeDetector; //Field offset: 0x100
	private float _voiceVolume; //Field offset: 0x108
	private float _handstepVolume; //Field offset: 0x10C
	private Coroutine _voiceVolumeUpdater; //Field offset: 0x110
	[CompilerGenerated]
	private AttachedItemAnchor <backItemAttachAnchor>k__BackingField; //Field offset: 0x118
	private int _handCollidedCounter; //Field offset: 0x120
	private AudioSource _speakerAudioSource; //Field offset: 0x128
	[PreserveInPlugin]
	[WeaverGenerated]
	private string cache_displayName; //Field offset: 0x130

	public AttachedItemAnchor[] anchors
	{
		 get { } //Length: 8
	}

	public private AttachedItemAnchor backItemAttachAnchor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(24, 1)]
	[OnChangedRender("HandleChannelChanged")]
	public int channel
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(6, 18)]
	[OnChangedRender("HandleDisplayNameChanged")]
	public string displayName
	{
		 get { } //Length: 120
		 set { } //Length: 112
	}

	[Networked]
	[NetworkedWeaved(5, 1)]
	[OnChangedRender("HandleIsDeadChanged")]
	public bool isDie
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public bool IsMine
	{
		 get { } //Length: 28
	}

	public static NetPlayer localPlayer
	{
		 get { } //Length: 480
	}

	public static uint localPlayerID
	{
		 get { } //Length: 268
	}

	[Networked]
	[NetworkedWeaved(1, 4)]
	[OnChangedRender("HandleColorChanged")]
	public Color playerColor
	{
		 get { } //Length: 100
		 set { } //Length: 100
	}

	public uint playerID
	{
		 get { } //Length: 44
	}

	[Networked]
	[NetworkedWeaved(25, 1)]
	public float playerVolume
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public static Dictionary<UInt32, NetPlayer> spawnedPlayers
	{
		 get { } //Length: 88
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	public int Token
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	private static NetPlayer() { }

	public NetPlayer() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public void DropItemIfHolding(AttachedLocation handSide) { }

	public void DropItemsIfHolding() { }

	public virtual void FixedUpdateNetwork() { }

	public AttachedItemAnchor[] get_anchors() { }

	[CompilerGenerated]
	public AttachedItemAnchor get_backItemAttachAnchor() { }

	public int get_channel() { }

	public string get_displayName() { }

	public bool get_isDie() { }

	public bool get_IsMine() { }

	public static NetPlayer get_localPlayer() { }

	public static uint get_localPlayerID() { }

	public Color get_playerColor() { }

	public uint get_playerID() { }

	public float get_playerVolume() { }

	public static Dictionary<UInt32, NetPlayer> get_spawnedPlayers() { }

	public int get_Token() { }

	private void HandleChannelChanged() { }

	private void HandleColorChanged() { }

	private void HandleDisplayNameChanged() { }

	private void HandleGrabbedItemWeightChanged(AttachedLocation location, GrabbableItem item) { }

	private void HandleHandStep(HandSide side, float intensity01) { }

	private void HandleIsDeadChanged() { }

	private void HandleItemCollision(AttachedLocation location, Collision collision, Vector3 velocity) { }

	private void HandleLocalPlayerChannelChanged(int playerChannel) { }

	private void HandleLocalPlayerDisplayNameStateChanged(StateChangedEventArgs args) { }

	private void HandlePlayerDie(bool isDie) { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private void LateUpdate() { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, PrefabType prefabType, string hitName) { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, string hitName) { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName) { }

	private void PropagateLocalPlayerColor() { }

	[IteratorStateMachine(typeof(<RemoteVoiceVolumeUpdater>d__86))]
	private IEnumerator RemoteVoiceVolumeUpdater() { }

	public void RepositionItemsIfHolding() { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_DoHandstep(HandSide side, float intensity01) { }

	[NetworkRpcWeavedInvoker(2, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_DoHandstep@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_DoPlayerDie(bool isDie) { }

	[NetworkRpcWeavedInvoker(3, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_DoPlayerDie@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, string hitName) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, Vector3 force, string hitName) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, PrefabType prefabType, string hitName) { }

	[NetworkRpcWeavedInvoker(5, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[NetworkRpcWeavedInvoker(6, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker2(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[NetworkRpcWeavedInvoker(7, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker3(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_SetPlayerColor(Color color) { }

	[NetworkRpcWeavedInvoker(1, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetPlayerColor@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_SetVoiceVolume(float volume) { }

	[NetworkRpcWeavedInvoker(4, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_SetVoiceVolume@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[CompilerGenerated]
	private void set_backItemAttachAnchor(AttachedItemAnchor value) { }

	public void set_channel(int value) { }

	public void set_displayName(string value) { }

	public void set_isDie(bool value) { }

	public void set_playerColor(Color value) { }

	public void set_playerVolume(float value) { }

	public void set_Token(int value) { }

	public virtual void Spawned() { }

	public static bool TryGetPlayerByID(uint id, out NetPlayer player) { }

	[IteratorStateMachine(typeof(<VoiceVolumeUpdater>d__85))]
	private IEnumerator VoiceVolumeUpdater() { }

}

