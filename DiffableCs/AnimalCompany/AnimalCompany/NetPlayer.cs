namespace AnimalCompany;

[DefaultExecutionOrder(101)]
[NetworkBehaviourWeaved(56)]
public class NetPlayer : NetworkBehaviour, IDamageable, IStunnable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NetPlayer, Boolean> <>9__65_0; //Field offset: 0x8
		public static Func<FriendState, Boolean> <>9__105_0; //Field offset: 0x10
		public static Func<FriendState, String> <>9__105_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_localPlayer>b__65_0(NetPlayer p) { }

		internal bool <HandleLocalBlockedPlayersChanged>b__105_0(FriendState f) { }

		internal string <HandleLocalBlockedPlayersChanged>b__105_1(FriendState f) { }

	}

	[CompilerGenerated]
	private sealed class <GetUserIDAndRegister>d__102 : IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		public NetPlayer <>4__this; //Field offset: 0x20

		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
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
		public <GetUserIDAndRegister>d__102(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <RemoteVoiceVolumeUpdater>d__132 : IEnumerator<Object>, IEnumerator, IDisposable
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
		public <RemoteVoiceVolumeUpdater>d__132(int <>1__state) { }

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
	private sealed class <VoiceVolumeUpdater>d__131 : IEnumerator<Object>, IEnumerator, IDisposable
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
		public <VoiceVolumeUpdater>d__131(int <>1__state) { }

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

	internal class Rig
	{
		public Transform bodyRoot; //Field offset: 0x10
		public Transform head; //Field offset: 0x18
		public Transform rightHand; //Field offset: 0x20
		public Transform leftHand; //Field offset: 0x28

		public Rig() { }

	}

	public const string EDITOR_PREFS_MIC_ENABLED = "AC_MIC_ENABLED"; //Field offset: 0x0
	private static Dictionary<UInt32, NetPlayer> _spawnedPlayers; //Field offset: 0x0
	private const float COARSE_DIST_UPDATE = 0.075; //Field offset: 0x0
	private const float COARSE_DIST_UPDATE_SQR = 0.005625; //Field offset: 0x0
	private const float COARSE_ROT_UPDATE = 20; //Field offset: 0x0
	private const float FINE_DIST_UPDATE = 0.005; //Field offset: 0x0
	private const float FINE_DIST_UPDATE_SQR = 2.5E-05; //Field offset: 0x0
	private const float FINE_ROT_UPDATE = 0.5; //Field offset: 0x0
	private const float VOICE_VOLUME_DETECTION_MULT = 5; //Field offset: 0x0
	public const int EXECUTION_ORDER = 101; //Field offset: 0x0
	private static NetPlayer _localPlayer; //Field offset: 0x8
	public VoiceNetworkObject voiceNetworkObject; //Field offset: 0x80
	public Transform avatarRoot; //Field offset: 0x88
	public Transform head; //Field offset: 0x90
	public Transform handLeft; //Field offset: 0x98
	public Transform handRight; //Field offset: 0xA0
	public Transform backAttachAnchor; //Field offset: 0xA8
	public Rig fineRig; //Field offset: 0xB0
	public Rig coarseRig; //Field offset: 0xB8
	[SerializeField]
	private NetworkObject _fineRigObj; //Field offset: 0xC0
	[SerializeField]
	private PlayerView _view; //Field offset: 0xC8
	[SerializeField]
	private Recorder _recorder; //Field offset: 0xD0
	[SerializeField]
	private Speaker _speaker; //Field offset: 0xD8
	[SerializeField]
	private HandInteractor[] _interactors; //Field offset: 0xE0
	[SerializeField]
	private AttachedItemAnchor[] _attachedItemAnchors; //Field offset: 0xE8
	[SerializeField]
	private Nametag _nametag; //Field offset: 0xF0
	[SerializeField]
	private NetHand _netLeftHand; //Field offset: 0xF8
	[SerializeField]
	private NetHand _netRightHand; //Field offset: 0x100
	[DefaultForProperty("isDie", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isDie; //Field offset: 0x108
	[DefaultForProperty("displayName", 1, 18)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private string _displayName; //Field offset: 0x110
	[DefaultForProperty("channel", 19, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private int _channel; //Field offset: 0x118
	[DefaultForProperty("fingerValues", 20, 6)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private FingerValues _fingerValues; //Field offset: 0x11C
	[DefaultForProperty("rigData", 26, 12)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private NetRigData _rigData; //Field offset: 0x134
	[DefaultForProperty("blockedPlayers", 38, 18)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private string _blockedPlayers; //Field offset: 0x168
	private bool _blockedLocalPlayer; //Field offset: 0x170
	[CompilerGenerated]
	private float <playerVolume>k__BackingField; //Field offset: 0x174
	private ChangeDetector _changeDetector; //Field offset: 0x178
	private float _voiceVolume; //Field offset: 0x180
	private Coroutine _voiceVolumeUpdater; //Field offset: 0x188
	private Nullable<Int32> _actorID; //Field offset: 0x190
	private string _userID; //Field offset: 0x198
	[CompilerGenerated]
	private AttachedItemAnchor <backItemAttachAnchor>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Color <playerColor>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private Rig <renderRig>k__BackingField; //Field offset: 0x1B8
	private int _handCollidedCounter; //Field offset: 0x1C0
	private AudioSource _speakerAudioSource; //Field offset: 0x1C8
	private float _rigDataChangedTime; //Field offset: 0x1D0
	private CommandHandle _getUserIDCommandHandle; //Field offset: 0x1D8
	[PreserveInPlugin]
	[WeaverGenerated]
	private string cache_displayName; //Field offset: 0x1E0
	[PreserveInPlugin]
	[WeaverGenerated]
	private string cache_blockedPlayers; //Field offset: 0x1E8

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
	[NetworkedWeaved(38, 18)]
	[OnChangedRender("HandleBlockedPlayersChanged")]
	public string blockedPlayers
	{
		 get { } //Length: 120
		 set { } //Length: 112
	}

	[Networked]
	[NetworkedWeaved(19, 1)]
	[OnChangedRender("HandleChannelChanged")]
	public int channel
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 18)]
	[OnChangedRender("HandleDisplayNameChanged")]
	public string displayName
	{
		 get { } //Length: 120
		 set { } //Length: 112
	}

	[Networked]
	[NetworkedWeaved(20, 6)]
	[OnChangedRender("HandleFingerValuesChanged")]
	public FingerValues fingerValues
	{
		 get { } //Length: 108
		 set { } //Length: 108
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsDeadChanged")]
	public bool isDie
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public bool isDieSafe
	{
		 get { } //Length: 56
	}

	public bool IsMine
	{
		 get { } //Length: 28
	}

	public bool isMuted
	{
		 get { } //Length: 428
	}

	private bool isSpawned
	{
		private get { } //Length: 28
	}

	public static uint localObjectID
	{
		 get { } //Length: 268
	}

	public static NetPlayer localPlayer
	{
		 get { } //Length: 480
	}

	public uint objectID
	{
		 get { } //Length: 44
	}

	public private Color playerColor
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public float playerVolume
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private Rig renderRig
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(26, 12)]
	[OnChangedRender("UpdateRigFromData")]
	public NetRigData rigData
	{
		 get { } //Length: 112
		 set { } //Length: 112
	}

	public static Dictionary<UInt32, NetPlayer> spawnedPlayers
	{
		 get { } //Length: 88
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

	public string get_blockedPlayers() { }

	public int get_channel() { }

	public string get_displayName() { }

	public FingerValues get_fingerValues() { }

	public bool get_isDie() { }

	public bool get_isDieSafe() { }

	public bool get_IsMine() { }

	public bool get_isMuted() { }

	private bool get_isSpawned() { }

	public static uint get_localObjectID() { }

	public static NetPlayer get_localPlayer() { }

	public uint get_objectID() { }

	[CompilerGenerated]
	public Color get_playerColor() { }

	[CompilerGenerated]
	public float get_playerVolume() { }

	[CompilerGenerated]
	public Rig get_renderRig() { }

	public NetRigData get_rigData() { }

	public static Dictionary<UInt32, NetPlayer> get_spawnedPlayers() { }

	[IteratorStateMachine(typeof(<GetUserIDAndRegister>d__102))]
	private IEnumerator<Command> GetUserIDAndRegister() { }

	private void HandleBlockedPlayersChanged() { }

	private void HandleChannelChanged() { }

	private void HandleDisplayNameChanged() { }

	private void HandleFingerValuesChanged() { }

	private void HandleFriendsChanged(StateChangedEventArgs args) { }

	private void HandleGrabbedItemWeightChanged(AttachedLocation location, GrabbableItem item) { }

	private void HandleHandStep(HandSide side, RandomSFX sfx, float intensity01) { }

	private void HandleIsDeadChanged() { }

	private void HandleItemCollision(AttachedLocation location, Collision collision, Vector3 velocity) { }

	private void HandleLocalAvatarChanged(StateChangedEventArgs args) { }

	private void HandleLocalBlockedPlayersChanged(StateChangedEventArgs args) { }

	private void HandleLocalPlayerChannelChanged(int playerChannel) { }

	private void HandleLocalPlayerDisplayNameStateChanged(StateChangedEventArgs args) { }

	private void HandleLocalPlayerFingerValuesChanged(Single[] fingerValues) { }

	private void HandleMutedPlayersUserIDsChanged(StateChangedEventArgs args) { }

	private void HandlePlayerDie(bool isDie) { }

	private void HandleRemoteAvatarChanged(StateChangedEventArgs args) { }

	public override void Hit(int damage, Vector3 position, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	public static bool IsPVPSource(NetworkRunner runner, NetworkBehaviourId source) { }

	private void LateUpdate() { }

	private void LerpFromRigData(Transform viewTransform, Transform srcTransform) { }

	private void OnDestroy() { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, PrefabType prefabType, string hitName, NetworkBehaviourId source) { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	public void PlayerHit(int damage, Transform hitTransform, RandomSFX hitSound, RandomSFX killSound, string hitName, NetworkBehaviourId source) { }

	[IteratorStateMachine(typeof(<RemoteVoiceVolumeUpdater>d__132))]
	private IEnumerator RemoteVoiceVolumeUpdater() { }

	public virtual void Render() { }

	public void RepositionItemsIfHolding() { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_DoPlayerDie(bool isDie) { }

	[NetworkRpcWeavedInvoker(1, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_DoPlayerDie@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::InputAuthority (2), RpcTargets::StateAuthority (1))]
	public void RPC_PlayerFingerValuesChanged(Single[] fingerValues) { }

	[NetworkRpcWeavedInvoker(2, 2, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerFingerValuesChanged@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, Vector3 force, string hitName, NetworkBehaviourId source) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, string hitName, NetworkBehaviourId source) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerHit(int damage, Vector3 position, Quaternion rotation, string hitSound, string killSound, PrefabType prefabType, string hitName, NetworkBehaviourId source) { }

	[NetworkRpcWeavedInvoker(3, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[NetworkRpcWeavedInvoker(4, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker2(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[NetworkRpcWeavedInvoker(5, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerHit@Invoker3(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::All (7), RpcTargets::InputAuthority (2))]
	public void RPC_PlayerStun(Vector3 position, float stunRange, float duration, string hitName, NetworkBehaviourId source, AttenuationType attenType) { }

	[NetworkRpcWeavedInvoker(7, 7, 2)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_PlayerStun@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[Rpc(RpcSources::StateAuthority (1), RpcTargets::All (7))]
	public void RPC_RequestAvatarRefresh(string userID) { }

	[NetworkRpcWeavedInvoker(6, 1, 7)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_RequestAvatarRefresh@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	[CompilerGenerated]
	private void set_backItemAttachAnchor(AttachedItemAnchor value) { }

	public void set_blockedPlayers(string value) { }

	public void set_channel(int value) { }

	public void set_displayName(string value) { }

	public void set_fingerValues(FingerValues value) { }

	public void set_isDie(bool value) { }

	[CompilerGenerated]
	private void set_playerColor(Color value) { }

	[CompilerGenerated]
	public void set_playerVolume(float value) { }

	[CompilerGenerated]
	private void set_renderRig(Rig value) { }

	public void set_rigData(NetRigData value) { }

	public bool ShouldApplyHit(NetworkBehaviourId source) { }

	public virtual void Spawned() { }

	public override void Stun(Vector3 position, float stunRange, float duration = 3, string hitName = "", NetworkBehaviourId source = null, AttenuationType attenType = 0) { }

	public static bool TryGetPlayerByID(uint id, out NetPlayer player) { }

	public void UpdateFromInput(NetPlayerInput input) { }

	public void UpdateRigFromData() { }

	private void UpdateSpeakerAudioSourceVolume() { }

	private void UpdateTransformWithThreshold(Transform rigTransform, Vector3 pos, Quaternion rot, float moveThreshold, float rotateThreshold) { }

	[IteratorStateMachine(typeof(<VoiceVolumeUpdater>d__131))]
	private IEnumerator VoiceVolumeUpdater() { }

}

