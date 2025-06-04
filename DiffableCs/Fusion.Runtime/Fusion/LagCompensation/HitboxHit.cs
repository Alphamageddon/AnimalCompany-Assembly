namespace Fusion.LagCompensation;

internal struct HitboxHit
{
	public Vector3 Point; //Field offset: 0x0
	public Vector3 Normal; //Field offset: 0xC
	public float Distance; //Field offset: 0x18
	public Hitbox Hitbox; //Field offset: 0x20
	public Vector3 DebugPosition; //Field offset: 0x28
	public Quaternion DebugRotation; //Field offset: 0x34
	public int DebugTick; //Field offset: 0x44
	public float Alpha; //Field offset: 0x48

}

