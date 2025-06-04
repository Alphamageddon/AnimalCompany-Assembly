namespace Fusion;

public class NetworkObjectBaker
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<NetworkObject> <>9__12_0; //Field offset: 0x8
		public static Predicate<SimulationBehaviour> <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Bake>b__12_0(NetworkObject x) { }

		internal bool <Bake>b__12_1(SimulationBehaviour x) { }

	}

	internal struct Result
	{
		[CompilerGenerated]
		private readonly bool <HadChanges>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <ObjectCount>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private readonly int <BehaviourCount>k__BackingField; //Field offset: 0x8

		public int BehaviourCount
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public bool HadChanges
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public int ObjectCount
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 8
		}

		public Result(bool dirty, int objectCount, int behaviourCount) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_BehaviourCount() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_HadChanges() { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_ObjectCount() { }

	}

	[IsReadOnly]
	internal struct TransformPath
	{
		internal struct _Indices
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <Value>e__FixedBuffer
			{
				public ushort FixedElementField; //Field offset: 0x0

			}

			[FixedBuffer(typeof(ushort, 10)]
			public <Value>e__FixedBuffer Value; //Field offset: 0x0

		}

		public const int MaxDepth = 10; //Field offset: 0x0
		public readonly _Indices Indices; //Field offset: 0x0
		public readonly ushort Depth; //Field offset: 0x14
		public readonly ushort Next; //Field offset: 0x16

		internal TransformPath(ushort depth, ushort next, List<UInt16> indices, int offset, int count) { }

		public virtual string ToString() { }

	}

	internal sealed class TransformPathCache : IComparer<TransformPath>, IEqualityComparer<TransformPath>
	{
		private Dictionary<Transform, TransformPath> _cache; //Field offset: 0x10
		private List<UInt16> _siblingIndexStack; //Field offset: 0x18
		private List<TransformPath> _nexts; //Field offset: 0x20

		public TransformPathCache() { }

		public void Clear() { }

		public override int Compare(TransformPath x, TransformPath y) { }

		private int CompareToDepthUnchecked(in TransformPath x, in TransformPath y, int depth) { }

		public TransformPath Create(Transform transform) { }

		public string Dump(in TransformPath x) { }

		private void Dump(in TransformPath x, StringBuilder builder) { }

		public override bool Equals(TransformPath x, TransformPath y) { }

		public override int GetHashCode(TransformPath obj) { }

		private int GetHashCode(in TransformPath path, int hash) { }

		public bool IsAncestorOf(in TransformPath x, in TransformPath y) { }

		public bool IsEqualOrAncestorOf(in TransformPath x, in TransformPath y) { }

	}

	private List<NetworkObject> _allNetworkObjects; //Field offset: 0x10
	private List<TransformPath> _networkObjectsPaths; //Field offset: 0x18
	private List<SimulationBehaviour> _allSimulationBehaviours; //Field offset: 0x20
	private TransformPathCache _pathCache; //Field offset: 0x28
	private List<NetworkBehaviour> _arrayBufferNB; //Field offset: 0x30
	private List<NetworkObject> _arrayBufferNO; //Field offset: 0x38

	public NetworkObjectBaker() { }

	public Result Bake(GameObject root) { }

	protected override uint GetSortKey(NetworkObject obj) { }

	private bool Set(MonoBehaviour host, ref T field, T value) { }

	private bool Set(MonoBehaviour host, ref T[] field, List<T> value) { }

	protected override void SetDirty(MonoBehaviour obj) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	protected static void Trace(string msg) { }

	protected override bool TryGetExecutionOrder(MonoBehaviour obj, out int order) { }

	protected static void Warn(string msg, object context = null) { }

}

