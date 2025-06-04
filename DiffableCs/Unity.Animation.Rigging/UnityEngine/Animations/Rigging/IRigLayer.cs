namespace UnityEngine.Animations.Rigging;

public interface IRigLayer
{

	public bool active
	{
		 get { } //Length: 0
	}

	public IRigConstraint[] constraints
	{
		 get { } //Length: 0
	}

	public IAnimationJob[] jobs
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public Rig rig
	{
		 get { } //Length: 0
	}

	public bool get_active() { }

	public IRigConstraint[] get_constraints() { }

	public IAnimationJob[] get_jobs() { }

	public string get_name() { }

	public Rig get_rig() { }

	public bool Initialize(Animator animator) { }

	public bool IsValid() { }

	public void Reset() { }

	public void Update() { }

}

