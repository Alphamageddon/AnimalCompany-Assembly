namespace Fusion.LagCompensation;

internal interface IHitboxColliderContainer
{

	public HitboxCollider GetCollider(int index) { }

	public HitboxCollider GetNextCollider(out int index) { }

	public HitboxCollider GetNextTempCollider(out int tmpIndex) { }

	public void ReleaseCollider(int index) { }

	public void ReleaseTempColliders() { }

}

