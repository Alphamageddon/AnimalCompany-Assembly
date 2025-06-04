namespace UnityEngine.Animations.Rigging;

public struct MultiParentConstraintData : IAnimationJobData, IMultiParentConstraintData
{
	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	[WeightRange(0, 1)]
	private WeightedTransformArray m_SourceObjects; //Field offset: 0x8
	[NotKeyable]
	[SerializeField]
	private Vector3Bool m_ConstrainedPositionAxes; //Field offset: 0x90
	[NotKeyable]
	[SerializeField]
	private Vector3Bool m_ConstrainedRotationAxes; //Field offset: 0x93
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainPositionOffset; //Field offset: 0x96
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainRotationOffset; //Field offset: 0x97

	public override Transform constrainedObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override bool constrainedPositionXAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedPositionYAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedPositionZAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedRotationXAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedRotationYAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedRotationZAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool maintainPositionOffset
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool maintainRotationOffset
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override WeightedTransformArray sourceObjects
	{
		 get { } //Length: 16
		 set { } //Length: 24
	}

	private override string UnityEngine.Animations.Rigging.IMultiParentConstraintData.sourceObjectsProperty
	{
		private get { } //Length: 64
	}

	public override Transform get_constrainedObject() { }

	public override bool get_constrainedPositionXAxis() { }

	public override bool get_constrainedPositionYAxis() { }

	public override bool get_constrainedPositionZAxis() { }

	public override bool get_constrainedRotationXAxis() { }

	public override bool get_constrainedRotationYAxis() { }

	public override bool get_constrainedRotationZAxis() { }

	public override bool get_maintainPositionOffset() { }

	public override bool get_maintainRotationOffset() { }

	public override WeightedTransformArray get_sourceObjects() { }

	public void set_constrainedObject(Transform value) { }

	public void set_constrainedPositionXAxis(bool value) { }

	public void set_constrainedPositionYAxis(bool value) { }

	public void set_constrainedPositionZAxis(bool value) { }

	public void set_constrainedRotationXAxis(bool value) { }

	public void set_constrainedRotationYAxis(bool value) { }

	public void set_constrainedRotationZAxis(bool value) { }

	public void set_maintainPositionOffset(bool value) { }

	public void set_maintainRotationOffset(bool value) { }

	public void set_sourceObjects(WeightedTransformArray value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IMultiParentConstraintData.get_sourceObjectsProperty() { }

}

