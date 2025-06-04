namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Explosion : NetworkBehaviour
{
	[Flags]
	internal enum ExplosionImpactType
	{
		None = 0,
		Damage = 1,
		Stun = 2,
	}

	internal enum Shape
	{
		Sphere = 0,
		Capsule = 1,
	}

	[SerializeField]
	private string _name; //Field offset: 0x80
	[SerializeField]
	private Shape _shape; //Field offset: 0x88
	[SerializeField]
	private ExplosionImpactType _explosionImpactType; //Field offset: 0x8C
	[Header("Collision")]
	[SerializeField]
	private float radius; //Field offset: 0x90
	[SerializeField]
	private float height; //Field offset: 0x94
	[SerializeField]
	private Vector3 _offset; //Field offset: 0x98
	[SerializeField]
	private LayerMask _layers; //Field offset: 0xA4
	[Header("Damage")]
	[SerializeField]
	private int damage; //Field offset: 0xA8
	[SerializeField]
	private float force; //Field offset: 0xAC
	[Header("Stun")]
	[SerializeField]
	private AttenuationType attenuationType; //Field offset: 0xB0
	[SerializeField]
	private float stunDuration; //Field offset: 0xB4
	[Header("Effects")]
	[SerializeField]
	private RandomSFX _SFXBlast; //Field offset: 0xB8
	[SerializeField]
	private ParticleSystem _explosionEffect; //Field offset: 0xC0
	[SerializeField]
	private Transform _viewTransform; //Field offset: 0xC8
	[Header("PVP")]
	[SerializeField]
	private bool _isPVPSource; //Field offset: 0xD0
	[DefaultForProperty("life", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _life; //Field offset: 0xD4
	private List<IDamageable> _damageables; //Field offset: 0xD8
	private List<IStunnable> _stunnables; //Field offset: 0xE0

	private Vector3 _capsulePoint0
	{
		private get { } //Length: 200
	}

	private Vector3 _capsulePoint1
	{
		private get { } //Length: 200
	}

	public bool isPVPSource
	{
		 get { } //Length: 8
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer life
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	public Explosion() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private Vector3 get__capsulePoint0() { }

	private Vector3 get__capsulePoint1() { }

	public bool get_isPVPSource() { }

	private TickTimer get_life() { }

	private void OnDrawGizmos() { }

	public virtual void Render() { }

	private void set_life(TickTimer value) { }

	public virtual void Spawned() { }

}

