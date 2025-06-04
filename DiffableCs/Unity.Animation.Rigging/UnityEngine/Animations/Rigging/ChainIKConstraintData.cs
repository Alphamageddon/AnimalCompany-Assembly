namespace UnityEngine.Animations.Rigging;

public struct ChainIKConstraintData : IAnimationJobData, IChainIKConstraintData
{
	internal const int k_MinIterations = 1; //Field offset: 0x0
	internal const int k_MaxIterations = 50; //Field offset: 0x0
	internal const float k_MinTolerance = 0; //Field offset: 0x0
	internal const float k_MaxTolerance = 0.01; //Field offset: 0x0
	[SerializeField]
	private Transform m_Root; //Field offset: 0x0
	[SerializeField]
	private Transform m_Tip; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_Target; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_ChainRotationWeight; //Field offset: 0x18
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_TipRotationWeight; //Field offset: 0x1C
	[NotKeyable]
	[Range(1, 50)]
	[SerializeField]
	private int m_MaxIterations; //Field offset: 0x20
	[NotKeyable]
	[Range(0, 0.01)]
	[SerializeField]
	private float m_Tolerance; //Field offset: 0x24
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainTargetPositionOffset; //Field offset: 0x28
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainTargetRotationOffset; //Field offset: 0x29

	public float chainRotationWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override bool maintainTargetPositionOffset
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool maintainTargetRotationOffset
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override int maxIterations
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override Transform root
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform target
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform tip
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float tipRotationWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override float tolerance
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	private override string UnityEngine.Animations.Rigging.IChainIKConstraintData.chainRotationWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IChainIKConstraintData.tipRotationWeightFloatProperty
	{
		private get { } //Length: 64
	}

	public float get_chainRotationWeight() { }

	public override bool get_maintainTargetPositionOffset() { }

	public override bool get_maintainTargetRotationOffset() { }

	public override int get_maxIterations() { }

	public override Transform get_root() { }

	public override Transform get_target() { }

	public override Transform get_tip() { }

	public float get_tipRotationWeight() { }

	public override float get_tolerance() { }

	public void set_chainRotationWeight(float value) { }

	public void set_maintainTargetPositionOffset(bool value) { }

	public void set_maintainTargetRotationOffset(bool value) { }

	public void set_maxIterations(int value) { }

	public void set_root(Transform value) { }

	public void set_target(Transform value) { }

	public void set_tip(Transform value) { }

	public void set_tipRotationWeight(float value) { }

	public void set_tolerance(float value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IChainIKConstraintData.get_chainRotationWeightFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IChainIKConstraintData.get_tipRotationWeightFloatProperty() { }

}

