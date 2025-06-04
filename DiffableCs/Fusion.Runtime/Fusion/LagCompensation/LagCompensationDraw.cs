namespace Fusion.LagCompensation;

public class LagCompensationDraw
{
	public SnapshotHistoryDraw SnapshotHistoryDraw; //Field offset: 0x10
	public BVHDraw BVHDraw; //Field offset: 0x18

	internal LagCompensationDraw(HitboxBuffer _buffer) { }

	public static void GizmosDrawWireCapsule(Vector3 topCenter, Vector3 bottomCenter, float capsuleRadius) { }

}

