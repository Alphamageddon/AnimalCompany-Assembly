namespace Fusion;

[HelpURL("https://doc.photonengine.com/fusion/current/manual/network-object#networkbehaviour")]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Blue (2))]
public abstract class NetworkBehaviour : SimulationBehaviour, ISpawned, IDespawned
{
	internal struct ArrayReader
	{
		internal PropertyReaderData Data; //Field offset: 0x0
		internal IElementReaderWriter<T> ReaderWriter; //Field offset: 0x0

		public NetworkArrayReadOnly<T> Read(NetworkBehaviourBuffer first) { }

	}

	internal struct BehaviourReader
	{
		internal NetworkRunner Runner; //Field offset: 0x0
		internal PropertyReader<NetworkBehaviourId> Reader; //Field offset: 0x0

		public T Read(NetworkBehaviourBuffer first) { }

		public ValueTuple<T, T> Read(NetworkBehaviourBuffer first, NetworkBehaviourBuffer second) { }

	}

	internal class ChangeDetector
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public OnChangedCallback<T> callback; //Field offset: 0x0

			public <>c__DisplayClass10_0`1() { }

			internal void <GetWrapper>b__0(NetworkBehaviour behaviour) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public OnChangedPrevCallback<T> callback; //Field offset: 0x0

			public <>c__DisplayClass9_0`1() { }

			internal void <GetWrapperPrev>b__0(NetworkBehaviour behaviour, NetworkBehaviourBuffer prev) { }

		}

		internal struct Enumerable
		{
			private String[] _changed; //Field offset: 0x0
			private int _count; //Field offset: 0x8

			internal Enumerable(String[] changed, int count) { }

			public bool Changed(string name) { }

			public Enumerator GetEnumerator() { }

		}

		internal struct Enumerator
		{
			private String[] _changed; //Field offset: 0x0
			private int _count; //Field offset: 0x8
			private int _current; //Field offset: 0xC

			public string Current
			{
				 get { } //Length: 52
			}

			internal Enumerator(String[] changed, int count) { }

			public string get_Current() { }

			public bool MoveNext() { }

			public void Reset() { }

		}

		public sealed class OnChangedCallback : MulticastDelegate
		{

			public OnChangedCallback`1(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(T b, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(T b) { }

		}

		public sealed class OnChangedCallbackWrapper : MulticastDelegate
		{

			public OnChangedCallbackWrapper(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(NetworkBehaviour b, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(NetworkBehaviour b) { }

		}

		public sealed class OnChangedPrevCallback : MulticastDelegate
		{

			public OnChangedPrevCallback`1(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(T b, NetworkBehaviourBuffer prev, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(T b, NetworkBehaviourBuffer prev) { }

		}

		public sealed class OnChangedPrevCallbackWrapper : MulticastDelegate
		{

			public OnChangedPrevCallbackWrapper(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(NetworkBehaviour b, NetworkBehaviourBuffer prev, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(NetworkBehaviour b, NetworkBehaviourBuffer prev) { }

		}

		private struct PropertyData
		{
			public MemberInfo PropertyInfo; //Field offset: 0x0
			public NetworkedWeavedAttribute WeavedAttribute; //Field offset: 0x8
			public OnChangedCallbackWrapper OnChanged; //Field offset: 0x10
			public OnChangedPrevCallbackWrapper OnChangedPrev; //Field offset: 0x18

		}

		internal enum Source
		{
			SimulationState = 0,
			SnapshotFrom = 1,
			SnapshotTo = 2,
		}

		private static Dictionary<Type, PropertyData[]> _propertyMappings; //Field offset: 0x0
		private static Dictionary<Type, Boolean> _hasChangeCallbacks; //Field offset: 0x8
		private Nullable<Int32> _instance; //Field offset: 0x10
		private Int32[] _words; //Field offset: 0x18
		private Int32* _wordsPrevious; //Field offset: 0x20
		private Source _source; //Field offset: 0x28
		private Tick _sourceTick; //Field offset: 0x2C
		private String[] _changed; //Field offset: 0x30
		private PropertyData[] _changedProperty; //Field offset: 0x38
		internal bool InvokeCallbacks; //Field offset: 0x40

		private static ChangeDetector() { }

		public ChangeDetector() { }

		public Enumerable DetectChanges(NetworkBehaviour b, out NetworkBehaviourBuffer previous, out NetworkBehaviourBuffer current, bool copyChanges = true) { }

		public Enumerable DetectChanges(NetworkBehaviour b, bool copyChanges = true) { }

		private Enumerable DetectChangesInternal(NetworkBehaviour b, out NetworkBehaviourBuffer previous, out NetworkBehaviourBuffer current, bool copyChanges = true) { }

		protected virtual void Finalize() { }

		private static PropertyData[] GetPropertyMappping(Type type) { }

		private static OnChangedCallbackWrapper GetWrapper(MethodInfo methodInfo) { }

		private static OnChangedPrevCallbackWrapper GetWrapperPrev(MethodInfo methodInfo) { }

		internal static bool HasChangeCallbacks(Type type) { }

		public void Init(NetworkBehaviour networkBehaviour, Source source, bool copyInitial = true) { }

	}

	internal struct DictionaryReader
	{
		internal PropertyReaderData Data; //Field offset: 0x0
		internal IElementReaderWriter<K> KeyReaderWriter; //Field offset: 0x0
		internal IElementReaderWriter<V> ValueReaderWriter; //Field offset: 0x0

		public NetworkDictionaryReadOnly<K, V> Read(NetworkBehaviourBuffer first) { }

	}

	internal struct LinkListReader
	{
		internal PropertyReaderData Data; //Field offset: 0x0
		internal IElementReaderWriter<T> ReaderWriter; //Field offset: 0x0

		public NetworkLinkedListReadOnly<T> Read(NetworkBehaviourBuffer first) { }

	}

	internal struct PropertyReader
	{
		internal PropertyReaderData Data; //Field offset: 0x0

		internal PropertyReader`1(PropertyReaderData data) { }

		public PropertyReader`1(int offset) { }

		public T Read(NetworkBehaviourBuffer first) { }

		public ValueTuple<T, T> Read(NetworkBehaviourBuffer first, NetworkBehaviourBuffer second) { }

	}

	public struct PropertyReaderData
	{
		public int Offset; //Field offset: 0x0
		public Type Type; //Field offset: 0x8
		public CapacityAttribute Capacity; //Field offset: 0x10

	}

	private class ReadersForType
	{
		public PropertyInfo[] Properties; //Field offset: 0x10
		public Dictionary<String, PropertyReaderData> PropertyReaders; //Field offset: 0x18

		public ReadersForType() { }

	}

	private static Dictionary<Type, ReadersForType> _readersByType; //Field offset: 0x0
	private ReadersForType _readersForType; //Field offset: 0x48
	internal Int32* Ptr; //Field offset: 0x50
	internal bool InvokeRpc; //Field offset: 0x58
	internal RpcInvokeData[] RpcCache; //Field offset: 0x60
	internal int ObjectIndex; //Field offset: 0x68
	internal int WordOffset; //Field offset: 0x6C
	internal int WordCount; //Field offset: 0x70
	internal bool DefaultReplicated; //Field offset: 0x74
	private ChangeDetector _onRenderCallbacksDetector; //Field offset: 0x78

	public Tick ChangedTick
	{
		 get { } //Length: 48
	}

	public override Nullable<Int32> DynamicWordCount
	{
		 get { } //Length: 8
	}

	public bool HasInputAuthority
	{
		 get { } //Length: 32
	}

	public bool HasStateAuthority
	{
		 get { } //Length: 32
	}

	public NetworkBehaviourId Id
	{
		 get { } //Length: 36
	}

	internal bool IsEditorWritable
	{
		internal get { } //Length: 72
	}

	public bool IsProxy
	{
		 get { } //Length: 32
	}

	public NetworkBehaviourBuffer StateBuffer
	{
		 get { } //Length: 48
	}

	public bool StateBufferIsValid
	{
		 get { } //Length: 16
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"offset", "count"}])]
	public ValueTuple<Int32, Int32> WordInfo
	{
		 get { } //Length: 96
	}

	protected NetworkBehaviour() { }

	public override void CopyBackingFieldsToState(bool firstTime) { }

	public void CopyStateFrom(NetworkBehaviour source) { }

	public override void CopyStateToBackingFields() { }

	public override void Despawned(NetworkRunner runner, bool hasState) { }

	public virtual void FixedUpdateNetwork() { }

	public Tick get_ChangedTick() { }

	public override Nullable<Int32> get_DynamicWordCount() { }

	public bool get_HasInputAuthority() { }

	public bool get_HasStateAuthority() { }

	public NetworkBehaviourId get_Id() { }

	internal bool get_IsEditorWritable() { }

	public bool get_IsProxy() { }

	public NetworkBehaviourBuffer get_StateBuffer() { }

	public bool get_StateBufferIsValid() { }

	public ValueTuple<Int32, Int32> get_WordInfo() { }

	public ArrayReader<T> GetArrayReader(string property) { }

	public static ArrayReader<T> GetArrayReader(Type behaviourType, string property, IElementReaderWriter<T> readerWriter = null) { }

	public BehaviourReader<T> GetBehaviourReader(string property) { }

	public static BehaviourReader<T> GetBehaviourReader(NetworkRunner runner, Type behaviourType, string property) { }

	public static BehaviourReader<TProperty> GetBehaviourReader(NetworkRunner runner, string property) { }

	public ChangeDetector GetChangeDetector(Source source, bool copyInitial = true) { }

	public static DictionaryReader<K, V> GetDictionaryReader(Type behaviourType, string property, IElementReaderWriter<K> keyReaderWriter = null, IElementReaderWriter<V> valueReaderWriter = null) { }

	public DictionaryReader<K, V> GetDictionaryReader(string property) { }

	public bool GetInput(out T input) { }

	public Nullable<T> GetInput() { }

	public LinkListReader<T> GetLinkListReader(string property) { }

	public static LinkListReader<T> GetLinkListReader(Type behaviourType, string property, IElementReaderWriter<T> readerWriter = null) { }

	public int GetLocalAuthorityMask() { }

	public PropertyReader<T> GetPropertyReader(string property) { }

	public static PropertyReader<T> GetPropertyReader(Type behaviourType, string property) { }

	public static PropertyReader<TProperty> GetPropertyReader(string property) { }

	private static PropertyReader<T> GetPropertyReader(ReadersForType readersForType, string property) { }

	private static PropertyReaderData GetPropertyReaderData(ReadersForType readersForType, string property, Type typeExpected) { }

	private static ReadersForType GetReadersForType(Type type) { }

	protected private static void InvokeWeavedCode() { }

	private static bool IsArray(Type type) { }

	private static bool IsDict(Type type) { }

	private static bool IsList(Type type) { }

	public static ArrayInitializer<T> MakeInitializer(T[] array) { }

	public static DictionaryInitializer<K, V> MakeInitializer(Dictionary<K, V> dictionary) { }

	internal void MakeOwned(NetworkRunner runner, NetworkObject obj, int index) { }

	public static T* MakePtr() { }

	public static T* MakePtr(T defaultValue) { }

	public static T MakeRef(T defaultValue) { }

	public static T MakeRef() { }

	internal void MakeUnowned() { }

	[NetworkDeserializeMethod]
	public static int NetworkDeserialize(NetworkRunner runner, Byte* data, ref NetworkBehaviour result) { }

	[NetworkSerializeMethod(MaxSize = 8)]
	public static int NetworkSerialize(NetworkBehaviour obj, Byte* data) { }

	[Obsolete("Use NetworkSerialize(NetworkBehaviour, byte*) instead")]
	public static int NetworkSerialize(NetworkRunner runner, NetworkBehaviour obj, Byte* data) { }

	public static NetworkBehaviour NetworkUnwrap(NetworkRunner runner, NetworkBehaviourId wrapper) { }

	public static NetworkBehaviourId NetworkWrap(NetworkRunner runner, NetworkBehaviour obj) { }

	public static NetworkBehaviourId op_Implicit(NetworkBehaviour behaviour) { }

	internal virtual void PreRender() { }

	internal void PreSpawned() { }

	public T ReinterpretState(int offset = 0) { }

	public void ReplicateTo(PlayerRef player, bool replicate) { }

	[Obsolete("Not called anymore, used ReplicateTo(PlayerRef, bool) instead")]
	protected override bool ReplicateTo(PlayerRef player) { }

	public void ReplicateToAll(bool replicate) { }

	public void ResetState() { }

	public override void Spawned() { }

	public bool TryGetSnapshotsBuffers(out NetworkBehaviourBuffer from, out NetworkBehaviourBuffer to, out float alpha) { }

}

