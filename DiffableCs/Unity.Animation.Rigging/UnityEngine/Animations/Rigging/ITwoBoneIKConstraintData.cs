namespace UnityEngine.Animations.Rigging;

public interface ITwoBoneIKConstraintData
{

	public Transform hint
	{
		 get { } //Length: 0
	}

	public string hintWeightFloatProperty
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

	public Transform mid
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

	public string targetPositionWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public string targetRotationWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public Transform tip
	{
		 get { } //Length: 0
	}

	public Transform get_hint() { }

	public string get_hintWeightFloatProperty() { }

	public bool get_maintainTargetPositionOffset() { }

	public bool get_maintainTargetRotationOffset() { }

	public Transform get_mid() { }

	public Transform get_root() { }

	public Transform get_target() { }

	public string get_targetPositionWeightFloatProperty() { }

	public string get_targetRotationWeightFloatProperty() { }

	public Transform get_tip() { }

}

