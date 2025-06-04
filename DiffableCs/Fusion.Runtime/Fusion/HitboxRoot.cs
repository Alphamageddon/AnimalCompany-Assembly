namespace Fusion;

[AddComponentMenu("Fusion/Lag Compensation/Hitbox Root")]
[DisallowMultipleComponent]
[NetworkBehaviourWeaved(1)]
public class HitboxRoot : NetworkBehaviour
{
	[Flags]
	internal enum ConfigFlags
	{
		ReinitializeHitboxesBeforeRegistration = 1,
		IncludeInactiveHitboxes = 2,
		Legacy = 1,
		Default = 3,
	}

	public class HitboxComparerX : IComparer<HitboxRoot>
	{

		public HitboxComparerX() { }

		public override int Compare(HitboxRoot a, HitboxRoot b) { }

	}

	public class HitboxComparerY : IComparer<HitboxRoot>
	{

		public HitboxComparerY() { }

		public override int Compare(HitboxRoot a, HitboxRoot b) { }

	}

	public class HitboxComparerZ : IComparer<HitboxRoot>
	{

		public HitboxComparerZ() { }

		public override int Compare(HitboxRoot a, HitboxRoot b) { }

	}

	private const int WORD_COUNT = 1; //Field offset: 0x0
	public const int MAX_HITBOXES = 31; //Field offset: 0x0
	[InlineHelp]
	public ConfigFlags Config; //Field offset: 0x80
	[InlineHelp]
	[Unit(Units::Units (16))]
	public float BroadRadius; //Field offset: 0x84
	[InlineHelp]
	public Vector3 Offset; //Field offset: 0x88
	[InlineHelp]
	public Color GizmosColor; //Field offset: 0x94
	[InlineHelp]
	[Space(4)]
	public Hitbox[] Hitboxes; //Field offset: 0xA8
	[CompilerGenerated]
	private HitboxManager <Manager>k__BackingField; //Field offset: 0xB0
	internal Transform CachedTransform; //Field offset: 0xB8

	public bool HitboxRootActive
	{
		 get { } //Length: 92
		 set { } //Length: 108
	}

	public bool InInterest
	{
		 get { } //Length: 160
	}

	public internal HitboxManager Manager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal bool Registered
	{
		internal get { } //Length: 32
	}

	public HitboxRoot() { }

	private void Awake() { }

	internal void DeregisterColliders(IHitboxColliderContainer container) { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	protected override void DrawGizmos(Color color, ref Matrix4x4 localToWorldMatrix) { }

	public bool get_HitboxRootActive() { }

	public bool get_InInterest() { }

	[CompilerGenerated]
	public HitboxManager get_Manager() { }

	internal bool get_Registered() { }

	internal Bounds GetBounds() { }

	[EditorButton("Find Hitboxes", EditorButtonVisibility::EditMode (1), 0, False)]
	public void InitHitboxes() { }

	public bool IsHitboxActive(Hitbox hitbox) { }

	internal bool IsHitboxActiveFastUnchecked(Hitbox hitbox) { }

	public void OnDrawGizmos() { }

	internal void RegisterColliders(IHitboxColliderContainer container, int tick) { }

	public void set_HitboxRootActive(bool value) { }

	[CompilerGenerated]
	internal void set_Manager(HitboxManager value) { }

	public void SetHitboxActive(Hitbox hitbox, bool setActive) { }

	internal void SetHitboxActiveFastUnchecked(Hitbox hitbox, bool setActive) { }

	[EditorButton("Quick Set BroadRadius", EditorButtonVisibility::Always (2), 0, True)]
	public void SetMinBoundingRadius() { }

}

