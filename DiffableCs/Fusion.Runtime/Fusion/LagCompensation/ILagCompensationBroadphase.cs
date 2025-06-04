namespace Fusion.LagCompensation;

internal interface ILagCompensationBroadphase
{

	public void Add(HitboxRoot root) { }

	public void CopyFrom(ILagCompensationBroadphase other) { }

	public bool Remove(HitboxRoot root) { }

	public void Traverse(IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layerMask) { }

	public void Update(HitboxRoot changed, int tick) { }

}

