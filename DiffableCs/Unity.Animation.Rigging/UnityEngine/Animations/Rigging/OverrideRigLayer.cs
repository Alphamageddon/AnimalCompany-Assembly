namespace UnityEngine.Animations.Rigging;

public class OverrideRigLayer : IRigLayer
{
	[FormerlySerializedAs("rig")]
	[SerializeField]
	private Rig m_Rig; //Field offset: 0x10
	[FormerlySerializedAs("active")]
	[SerializeField]
	private bool m_Active; //Field offset: 0x18
	private IRigConstraint[] m_Constraints; //Field offset: 0x20
	private IAnimationJob[] m_Jobs; //Field offset: 0x28
	[CompilerGenerated]
	private bool <isInitialized>k__BackingField; //Field offset: 0x30

	public override bool active
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override IRigConstraint[] constraints
	{
		 get { } //Length: 24
	}

	public private bool isInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public override IAnimationJob[] jobs
	{
		 get { } //Length: 24
	}

	public override string name
	{
		 get { } //Length: 168
	}

	public private override Rig rig
	{
		 get { } //Length: 8
		private set { } //Length: 8
	}

	public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true) { }

	public override bool get_active() { }

	public override IRigConstraint[] get_constraints() { }

	[CompilerGenerated]
	public bool get_isInitialized() { }

	public override IAnimationJob[] get_jobs() { }

	public override string get_name() { }

	public override Rig get_rig() { }

	public override bool Initialize(Animator animator) { }

	public override bool IsValid() { }

	public override void Reset() { }

	public void set_active(bool value) { }

	[CompilerGenerated]
	private void set_isInitialized(bool value) { }

	private void set_rig(Rig value) { }

	public override void Update() { }

}

