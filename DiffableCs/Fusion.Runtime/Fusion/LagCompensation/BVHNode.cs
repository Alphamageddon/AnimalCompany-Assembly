namespace Fusion.LagCompensation;

internal struct BVHNode
{
	public enum Rot
	{
		NONE = 0,
		L_RL = 1,
		L_RR = 2,
		R_LL = 3,
		R_LR = 4,
		LL_RR = 5,
		LL_RL = 6,
	}

	internal const int MaxEntriesPerNode = 1; //Field offset: 0x0
	internal const int RootNodeIndex = 1; //Field offset: 0x0
	private static readonly HitboxComparerX ComparerX; //Field offset: 0x0
	private static readonly HitboxComparerY ComparerY; //Field offset: 0x8
	private static readonly HitboxComparerZ ComparerZ; //Field offset: 0x10
	public Bounds Box; //Field offset: 0x0
	internal AABB _cachedBounds; //Field offset: 0x18
	private int _nodeIndex; //Field offset: 0x48
	private int _parentIndex; //Field offset: 0x4C
	private int _leftIndex; //Field offset: 0x50
	private int _rightIndex; //Field offset: 0x54
	internal bool Active; //Field offset: 0x58
	internal int Depth; //Field offset: 0x5C
	internal bool Used; //Field offset: 0x60
	internal int Next; //Field offset: 0x64
	internal HitboxRoot _root; //Field offset: 0x68
	internal bool _isLeaf; //Field offset: 0x70

	internal bool HasLeft
	{
		internal get { } //Length: 16
	}

	internal bool HasParent
	{
		internal get { } //Length: 16
	}

	internal bool HasRight
	{
		internal get { } //Length: 16
	}

	internal bool HasValidRoot
	{
		internal get { } //Length: 48
	}

	internal int Index
	{
		internal get { } //Length: 8
	}

	internal bool IsLeaf
	{
		internal get { } //Length: 8
	}

	internal bool IsRootNode
	{
		internal get { } //Length: 16
	}

	internal bool IsValid
	{
		internal get { } //Length: 16
	}

	private static BVHNode() { }

	internal static Bounds AABBofPair(ref BVHNode nodea, ref BVHNode nodeb) { }

	internal static void Add(BVH bvh, ref BVHNode startNode, HitboxRoot entry, ref Bounds newObBox, float newObSah) { }

	private static void AddObjectPushdown(BVH bvh, ref BVHNode curNode, HitboxRoot entry) { }

	private void AssignVolume(Vector3 pos, float radius, ref Bounds bounds) { }

	private bool BoundsIntersectsSphere(Bounds bounds, Vector3 origin, float radius) { }

	public void BuildLog(StringBuilder builder) { }

	internal void ChildExpanded(BVH bvh, ref BVHNode child) { }

	internal void ChildRefit(BVH bvh, bool propagate = true) { }

	internal static void ChildRefit(BVH bvh, int nodeIndex, bool propagate = true) { }

	private Bounds ComputeMinVolume(BVH bvh) { }

	private void ComputeVolume(BVH bvh) { }

	private void ExpandVolume(BVH bvh, Vector3 objectpos, float radius, ref Bounds bounds, bool expandParent) { }

	internal void FindOverlappingLeaves(BVH bvh, Bounds aabb, List<BVHNode> overlapList) { }

	internal void FindOverlappingLeaves(BVH bvh, Vector3 origin, float radius, List<BVHNode> overlapList) { }

	internal bool get_HasLeft() { }

	internal bool get_HasParent() { }

	internal bool get_HasRight() { }

	internal bool get_HasValidRoot() { }

	internal int get_Index() { }

	internal bool get_IsLeaf() { }

	internal bool get_IsRootNode() { }

	internal bool get_IsValid() { }

	private static Bounds GetEntryBounds(HitboxRoot entry) { }

	internal BVHNode GetLeft(BVH bvh) { }

	internal BVHNode GetParent(BVH bvh) { }

	internal BVHNode GetRight(BVH bvh) { }

	internal static void InitNode(ref BVHNode node, BVH bvh, int index, int parentIndex, int curDepth, List<HitboxRoot> entries = null) { }

	internal int NodesCount(BVH bvh) { }

	internal void RefitObjectChanged(BVH bvh) { }

	private bool RefitVolume(BVH bvh) { }

	internal void Remove(BVH bvh, HitboxRoot entry) { }

	private void RemoveLeaf(BVH bvh, int removeIndex) { }

	internal static float SA(Bounds box) { }

	internal static float SA(ref Bounds box) { }

	internal static float SA(ref BVHNode node) { }

	private static float SAofList(List<HitboxRoot> entries) { }

	private void SetDepth(BVH bvh, int newdepth) { }

	internal void SplitNode(BVH bvh, List<HitboxRoot> entries) { }

	internal Bounds ToBounds() { }

	public virtual string ToString() { }

	private void UpdateBoundsCache() { }

}

