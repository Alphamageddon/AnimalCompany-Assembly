namespace Fusion.LagCompensation;

internal class BVH : ILagCompensationBroadphase
{
	private const float DEFAULT_EXPANSION_FACTOR = 0.15; //Field offset: 0x0
	private const int DEFAULT_PARENTS_TO_EXPAND = 3; //Field offset: 0x0
	internal BVHNode[] _nodes; //Field offset: 0x10
	internal Mapper Mapper; //Field offset: 0x18
	internal int maxDepth; //Field offset: 0x20
	internal HashSet<Int32> refitNodes; //Field offset: 0x28
	internal readonly List<HitboxRoot> ReusableList; //Field offset: 0x30
	private int _nodesCount; //Field offset: 0x38
	private int _usedNodesCount; //Field offset: 0x3C
	private int _freeNodesHead; //Field offset: 0x40
	internal float ExpansionFactor; //Field offset: 0x44
	internal int ParentsToExpand; //Field offset: 0x48

	internal BVHNode rootBVH
	{
		internal get { } //Length: 44
	}

	internal int UsedNodesCount
	{
		internal get { } //Length: 8
	}

	internal BVH(Mapper mapper, int nodesCapacity, List<HitboxRoot> initialEntries = null, float expansionFactor = 0.15, int parentsToExpand = 3) { }

	public override void Add(HitboxRoot root) { }

	internal static Bounds BoundsFromSphere(Vector3 pos, float radius) { }

	internal void BuildNodesLog(StringBuilder builder) { }

	public override void CopyFrom(ILagCompensationBroadphase other) { }

	internal void DisposeNode(int index) { }

	internal BVHNode get_rootBVH() { }

	internal int get_UsedNodesCount() { }

	internal BVHNode GetNextNode(out int index) { }

	internal BVHNode GetNode(int index) { }

	public void PosUpdateRefit() { }

	public override bool Remove(HitboxRoot root) { }

	private void ResizeNodesArray(int minimumIncrease) { }

	public override void Traverse(IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layerMask) { }

	private void TraverseInternal(ref BVHNode curNode, IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layermask) { }

	public override void Update(HitboxRoot changed, int tick) { }

}

