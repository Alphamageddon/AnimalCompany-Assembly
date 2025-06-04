namespace UnityEngine.Animations.Rigging;

public interface IChainIKConstraintData
{

	public string chainRotationWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public bool maintainTargetPositionOffset
	{
		 get { } //Length: 0
	}

	public bool maintainTargetRotationOffset
	{
		 get { } //Length: 0
	}

	public int maxIterations
	{
		 get { } //Length: 0
	}

	public Transform root
	{
		 get { } //Length: 0
	}

	public Transform target
	{
		 get { } //Length: 0
	}

	public Transform tip
	{
		 get { } //Length: 0
	}

	public string tipRotationWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public float tolerance
	{
		 get { } //Length: 0
	}

	public string get_chainRotationWeightFloatProperty() { }

	public bool get_maintainTargetPositionOffset() { }

	public bool get_maintainTargetRotationOffset() { }

	public int get_maxIterations() { }

	public Transform get_root() { }

	public Transform get_target() { }

	public Transform get_tip() { }

	public string get_tipRotationWeightFloatProperty() { }

	public float get_tolerance() { }

}

