namespace Fusion.LagCompensation;

internal struct HitboxCollider
{
	internal HitboxTypes Type; //Field offset: 0x0
	private Matrix4x4 _cachedMatrix; //Field offset: 0x4
	private bool _matrixCalculated; //Field offset: 0x44
	internal Vector3 Offset; //Field offset: 0x48
	internal Vector3 BoxExtents; //Field offset: 0x54
	internal float Radius; //Field offset: 0x60
	internal float CapsuleExtents; //Field offset: 0x64
	internal bool Active; //Field offset: 0x68
	internal Hitbox Hitbox; //Field offset: 0x70
	internal int layerMask; //Field offset: 0x78
	internal int DebugTick; //Field offset: 0x7C
	internal bool Used; //Field offset: 0x80
	internal int Next; //Field offset: 0x84
	internal BoxNarrowData BoxNarrowData; //Field offset: 0x88
	[CompilerGenerated]
	private bool <IsBoxNarrowDataInitialized>k__BackingField; //Field offset: 0x1B4
	internal Vector3 Position; //Field offset: 0x1B8
	internal Quaternion Rotation; //Field offset: 0x1C4

	internal Vector3 CapsuleLocalBottomCenter
	{
		internal get { } //Length: 140
	}

	internal Vector3 CapsuleLocalTopCenter
	{
		internal get { } //Length: 140
	}

	internal bool IsBoxNarrowDataInitialized
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal Matrix4x4 LocalToWorld
	{
		internal get { } //Length: 240
	}

	private static void CustomTRS(ref Matrix4x4 res, Vector3 t, Quaternion r, Vector3 s) { }

	internal Vector3 get_CapsuleLocalBottomCenter() { }

	internal Vector3 get_CapsuleLocalTopCenter() { }

	[CompilerGenerated]
	internal bool get_IsBoxNarrowDataInitialized() { }

	internal Matrix4x4 get_LocalToWorld() { }

	internal void InitNarrowData() { }

	internal static void Lerp(ref HitboxCollider from, ref HitboxCollider to, float alpha, ref HitboxCollider result) { }

	internal void ResetCachedMatrix() { }

	[CompilerGenerated]
	internal void set_IsBoxNarrowDataInitialized(bool value) { }

}

