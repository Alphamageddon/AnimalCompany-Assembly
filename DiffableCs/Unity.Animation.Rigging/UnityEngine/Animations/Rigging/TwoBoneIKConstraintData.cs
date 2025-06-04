namespace UnityEngine.Animations.Rigging;

public struct TwoBoneIKConstraintData : IAnimationJobData, ITwoBoneIKConstraintData
{
	[SerializeField]
	private Transform m_Root; //Field offset: 0x0
	[SerializeField]
	private Transform m_Mid; //Field offset: 0x8
	[SerializeField]
	private Transform m_Tip; //Field offset: 0x10
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_Target; //Field offset: 0x18
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_Hint; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_TargetPositionWeight; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_TargetRotationWeight; //Field offset: 0x2C
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_HintWeight; //Field offset: 0x30
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainTargetPositionOffset; //Field offset: 0x34
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainTargetRotationOffset; //Field offset: 0x35

	public override Transform hint
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hintWeight
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

	public override Transform mid
	{
		 get { } //Length: 8
		 set { } //Length: 8
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

	public float targetPositionWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float targetRotationWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override Transform tip
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.hintWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.targetPositionWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.targetRotationWeightFloatProperty
	{
		private get { } //Length: 64
	}

	public override Transform get_hint() { }

	public float get_hintWeight() { }

	public override bool get_maintainTargetPositionOffset() { }

	public override bool get_maintainTargetRotationOffset() { }

	public override Transform get_mid() { }

	public override Transform get_root() { }

	public override Transform get_target() { }

	public float get_targetPositionWeight() { }

	public float get_targetRotationWeight() { }

	public override Transform get_tip() { }

	public void set_hint(Transform value) { }

	public void set_hintWeight(float value) { }

	public void set_maintainTargetPositionOffset(bool value) { }

	public void set_maintainTargetRotationOffset(bool value) { }

	public void set_mid(Transform value) { }

	public void set_root(Transform value) { }

	public void set_target(Transform value) { }

	public void set_targetPositionWeight(float value) { }

	public void set_targetRotationWeight(float value) { }

	public void set_tip(Transform value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_hintWeightFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetPositionWeightFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.ITwoBoneIKConstraintData.get_targetRotationWeightFloatProperty() { }

}

