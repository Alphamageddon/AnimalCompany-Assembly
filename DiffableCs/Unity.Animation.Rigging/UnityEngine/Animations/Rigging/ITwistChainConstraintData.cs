namespace UnityEngine.Animations.Rigging;

public interface ITwistChainConstraintData
{

	public AnimationCurve curve
	{
		 get { } //Length: 0
	}

	public Transform root
	{
		 get { } //Length: 0
	}

	public Transform rootTarget
	{
		 get { } //Length: 0
	}

	public Transform tip
	{
		 get { } //Length: 0
	}

	public Transform tipTarget
	{
		 get { } //Length: 0
	}

	public AnimationCurve get_curve() { }

	public Transform get_root() { }

	public Transform get_rootTarget() { }

	public Transform get_tip() { }

	public Transform get_tipTarget() { }

}

