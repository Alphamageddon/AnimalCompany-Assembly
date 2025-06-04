namespace Fusion;

public struct LagCompensatedHit
{
	public HitType Type; //Field offset: 0x0
	public GameObject GameObject; //Field offset: 0x8
	public Vector3 Normal; //Field offset: 0x10
	public Vector3 Point; //Field offset: 0x1C
	public Vector3 HitboxColliderPosition; //Field offset: 0x28
	public Quaternion HitboxColliderRotation; //Field offset: 0x34
	public float Distance; //Field offset: 0x44
	public Hitbox Hitbox; //Field offset: 0x48
	public Collider Collider; //Field offset: 0x50
	public Collider2D Collider2D; //Field offset: 0x58
	internal float _sortAux; //Field offset: 0x60

	internal static LagCompensatedHit FromHitboxHit(ref HitboxHit hitboxHit) { }

	public static LagCompensatedHit op_Explicit(RaycastHit raycastHit) { }

	public static LagCompensatedHit op_Explicit(RaycastHit2D raycastHit2D) { }

	internal static void QuickSort(List<LagCompensatedHit> hits, int low, int high) { }

	internal static void QuickSortDistance(List<LagCompensatedHit> hits, int low, int high) { }

}

