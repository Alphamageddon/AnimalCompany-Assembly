namespace UnityEngine.Animations.Rigging;

public struct MultiPositionConstraintData : IAnimationJobData, IMultiPositionConstraintData
{
	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	[WeightRange(0, 1)]
	private WeightedTransformArray m_SourceObjects; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Vector3 m_Offset; //Field offset: 0x90
	[NotKeyable]
	[SerializeField]
	private Vector3Bool m_ConstrainedAxes; //Field offset: 0x9C
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainOffset; //Field offset: 0x9F

	public override Transform constrainedObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override bool constrainedXAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedYAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool constrainedZAxis
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override bool maintainOffset
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Vector3 offset
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public override WeightedTransformArray sourceObjects
	{
		 get { } //Length: 16
		 set { } //Length: 24
	}

	private override string UnityEngine.Animations.Rigging.IMultiPositionConstraintData.offsetVector3Property
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IMultiPositionConstraintData.sourceObjectsProperty
	{
		private get { } //Length: 64
	}

	public override Transform get_constrainedObject() { }

	public override bool get_constrainedXAxis() { }

	public override bool get_constrainedYAxis() { }

	public override bool get_constrainedZAxis() { }

	public override bool get_maintainOffset() { }

	public Vector3 get_offset() { }

	public override WeightedTransformArray get_sourceObjects() { }

	public void set_constrainedObject(Transform value) { }

	public void set_constrainedXAxis(bool value) { }

	public void set_constrainedYAxis(bool value) { }

	public void set_constrainedZAxis(bool value) { }

	public void set_maintainOffset(bool value) { }

	public void set_offset(Vector3 value) { }

	public void set_sourceObjects(WeightedTransformArray value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_offsetVector3Property() { }

	private override string UnityEngine.Animations.Rigging.IMultiPositionConstraintData.get_sourceObjectsProperty() { }

}

