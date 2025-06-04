namespace Fusion;

public class NetworkPrefabTable
{
	[CompilerGenerated]
	private sealed class <GetEntries>d__12 : IEnumerable<ValueTuple`2<NetworkPrefabId, INetworkPrefabSource>>, IEnumerable, IEnumerator<ValueTuple`2<NetworkPrefabId, INetworkPrefabSource>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ValueTuple<NetworkPrefabId, INetworkPrefabSource> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public NetworkPrefabTable <>4__this; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38

		private override ValueTuple<NetworkPrefabId, INetworkPrefabSource> System.Collections.Generic.IEnumerator<System.ValueTuple<Fusion.NetworkPrefabId,Fusion.INetworkPrefabSource>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 12
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 92
		}

		[DebuggerHidden]
		public <GetEntries>d__12(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ValueTuple`2<NetworkPrefabId, INetworkPrefabSource>> System.Collections.Generic.IEnumerable<System.ValueTuple<Fusion.NetworkPrefabId,Fusion.INetworkPrefabSource>>.GetEnumerator() { }

		[DebuggerHidden]
		private override ValueTuple<NetworkPrefabId, INetworkPrefabSource> System.Collections.Generic.IEnumerator<System.ValueTuple<Fusion.NetworkPrefabId,Fusion.INetworkPrefabSource>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct PrefabAcquireData
	{
		public uint RawValue; //Field offset: 0x0

		public int InstanceCount
		{
			 get { } //Length: 12
			 set { } //Length: 16
		}

		public bool IsSynchronous
		{
			 get { } //Length: 12
			 set { } //Length: 28
		}

		public int get_InstanceCount() { }

		public bool get_IsSynchronous() { }

		public void set_InstanceCount(int value) { }

		public void set_IsSynchronous(bool value) { }

	}

	private const int BitsPerMask = 64; //Field offset: 0x0
	public NetworkPrefabTableOptions Options; //Field offset: 0x10
	private List<INetworkPrefabSource> _sources; //Field offset: 0x18
	private BitSet64[] _acquireMask; //Field offset: 0x20
	private PrefabAcquireData[] _acquireData; //Field offset: 0x28
	private Dictionary<NetworkObjectGuid, Int32> _guidToIndex; //Field offset: 0x30
	private int _version; //Field offset: 0x38

	public IReadOnlyList<INetworkPrefabSource> Prefabs
	{
		 get { } //Length: 8
	}

	public int Version
	{
		 get { } //Length: 8
	}

	public NetworkPrefabTable() { }

	public int AddInstance(NetworkPrefabId prefabId) { }

	public void AddSource(INetworkPrefabSource source) { }

	public void Clear() { }

	public bool Contains(NetworkPrefabId prefabId) { }

	private int DecodePrefabId(NetworkPrefabId prefabId) { }

	public IReadOnlyList<INetworkPrefabSource> get_Prefabs() { }

	public int get_Version() { }

	private int GetBitSetCapacity(int length) { }

	[IteratorStateMachine(typeof(<GetEntries>d__12))]
	public IEnumerable<ValueTuple`2<NetworkPrefabId, INetworkPrefabSource>> GetEntries() { }

	public NetworkObjectGuid GetGuid(NetworkPrefabId prefabId) { }

	public NetworkPrefabId GetId(NetworkObjectGuid guid) { }

	public int GetInstancesCount(NetworkPrefabId prefabId) { }

	public INetworkPrefabSource GetSource(NetworkObjectGuid guid) { }

	public INetworkPrefabSource GetSource(NetworkPrefabId prefabId) { }

	private bool IsAcquired(int index) { }

	public bool IsAcquired(NetworkPrefabId prefabId) { }

	public NetworkObject Load(NetworkPrefabId prefabId, bool isSynchronous) { }

	public int RemoveInstance(NetworkPrefabId prefabId) { }

	private void SetAcquired(int index, bool value) { }

	public bool TryAddSource(INetworkPrefabSource source, out NetworkPrefabId id) { }

	private bool TryDecodePrefabId(NetworkPrefabId prefabId, out int index) { }

	public bool Unload(NetworkPrefabId prefabId) { }

	public void UnloadAll() { }

	private void UnloadInternal(int index) { }

	public int UnloadUnreferenced(bool includeIncompleteLoads = false) { }

}

