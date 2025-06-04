namespace UnityEngine.Animations.Rigging;

public struct TwistChainConstraintData : IAnimationJobData, ITwistChainConstraintData
{
	[SerializeField]
	private Transform m_Root; //Field offset: 0x0
	[SerializeField]
	private Transform m_Tip; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_RootTarget; //Field offset: 0x10
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_TipTarget; //Field offset: 0x18
	[SerializeField]
	private AnimationCurve m_Curve; //Field offset: 0x20

	public override AnimationCurve curve
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform root
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform rootTarget
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform tip
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform tipTarget
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override AnimationCurve get_curve() { }

	public override Transform get_root() { }

	public override Transform get_rootTarget() { }

	public override Transform get_tip() { }

	public override Transform get_tipTarget() { }

	public void set_curve(AnimationCurve value) { }

	public void set_root(Transform value) { }

	public void set_rootTarget(Transform value) { }

	public void set_tip(Transform value) { }

	public void set_tipTarget(Transform value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

}

