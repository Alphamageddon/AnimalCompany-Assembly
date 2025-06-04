namespace Fusion;

[AddComponentMenu("Fusion/Lag Compensation/Hitbox")]
public class Hitbox : Behaviour
{
	[InlineHelp]
	public HitboxTypes Type; //Field offset: 0x20
	[DrawIf("Type", 2, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	[Unit(Units::Units (16))]
	public float SphereRadius; //Field offset: 0x24
	[DrawIf("Type", 3, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	[Unit(Units::Units (16))]
	public float CapsuleRadius; //Field offset: 0x28
	[DrawIf("Type", 1, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	public Vector3 BoxExtents; //Field offset: 0x2C
	[DrawIf("Type", 3, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	[Unit(Units::Units (16))]
	public float CapsuleExtents; //Field offset: 0x38
	[DrawIf("Type", Hide = True)]
	public Vector3 Offset; //Field offset: 0x3C
	[HideInInspector]
	public HitboxRoot Root; //Field offset: 0x48
	internal int _hitboxIndex; //Field offset: 0x50
	[CompilerGenerated]
	private int <ColliderIndex>k__BackingField; //Field offset: 0x54
	[InlineHelp]
	public Color GizmosColor; //Field offset: 0x58
	private int _cachedLayerMask; //Field offset: 0x68
	private Transform _cachedTransform; //Field offset: 0x70

	internal Vector3 AbsBoxExtents
	{
		internal get { } //Length: 24
	}

	internal float AbsCapsuleRadius
	{
		internal get { } //Length: 12
	}

	internal float AbsSphereRadius
	{
		internal get { } //Length: 12
	}

	internal Vector3 CapsuleBottomCenter
	{
		internal get { } //Length: 148
	}

	internal Vector3 CapsuleTopCenter
	{
		internal get { } //Length: 148
	}

	public internal int ColliderIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public bool HitboxActive
	{
		 get { } //Length: 32
		 set { } //Length: 36
	}

	public int HitboxIndex
	{
		 get { } //Length: 8
	}

	internal uint HitboxMask
	{
		internal get { } //Length: 20
	}

	public Vector3 Position
	{
		 get { } //Length: 120
	}

	public Hitbox() { }

	private void Awake() { }

	internal void CacheInfo() { }

	protected override void DrawGizmos(Color color, ref Matrix4x4 localToWorldMatrix) { }

	internal Vector3 get_AbsBoxExtents() { }

	internal float get_AbsCapsuleRadius() { }

	internal float get_AbsSphereRadius() { }

	internal Vector3 get_CapsuleBottomCenter() { }

	internal Vector3 get_CapsuleTopCenter() { }

	[CompilerGenerated]
	public int get_ColliderIndex() { }

	public bool get_HitboxActive() { }

	public int get_HitboxIndex() { }

	internal uint get_HitboxMask() { }

	public Vector3 get_Position() { }

	public void OnDrawGizmos() { }

	[CompilerGenerated]
	internal void set_ColliderIndex(int value) { }

	public void set_HitboxActive(bool value) { }

	internal void SetColliderData(ref HitboxCollider c, int tick) { }

	public void SetLayer(int layer) { }

}

