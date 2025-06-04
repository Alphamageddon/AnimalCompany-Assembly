namespace UnityEngine.Animations.Rigging;

public struct BlendConstraintData : IAnimationJobData, IBlendConstraintData
{
	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_SourceA; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_SourceB; //Field offset: 0x10
	[SerializeField]
	[SyncSceneToStream]
	private bool m_BlendPosition; //Field offset: 0x18
	[SerializeField]
	[SyncSceneToStream]
	private bool m_BlendRotation; //Field offset: 0x19
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_PositionWeight; //Field offset: 0x1C
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_RotationWeight; //Field offset: 0x20
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainPositionOffsets; //Field offset: 0x24
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainRotationOffsets; //Field offset: 0x25

	public bool blendPosition
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool blendRotation
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override Transform constrainedObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override bool maintainPositionOffsets
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool maintainRotationOffsets
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float positionWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float rotationWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override Transform sourceObjectA
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform sourceObjectB
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.blendPositionBoolProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.blendRotationBoolProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.positionWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.rotationWeightFloatProperty
	{
		private get { } //Length: 64
	}

	public bool get_blendPosition() { }

	public bool get_blendRotation() { }

	public override Transform get_constrainedObject() { }

	public override bool get_maintainPositionOffsets() { }

	public override bool get_maintainRotationOffsets() { }

	public float get_positionWeight() { }

	public float get_rotationWeight() { }

	public override Transform get_sourceObjectA() { }

	public override Transform get_sourceObjectB() { }

	public void set_blendPosition(bool value) { }

	public void set_blendRotation(bool value) { }

	public void set_constrainedObject(Transform value) { }

	public void set_maintainPositionOffsets(bool value) { }

	public void set_maintainRotationOffsets(bool value) { }

	public void set_positionWeight(float value) { }

	public void set_rotationWeight(float value) { }

	public void set_sourceObjectA(Transform value) { }

	public void set_sourceObjectB(Transform value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendPositionBoolProperty() { }

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.get_blendRotationBoolProperty() { }

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.get_positionWeightFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IBlendConstraintData.get_rotationWeightFloatProperty() { }

}

