namespace UnityEngine.Animations.Rigging;

public struct MultiAimConstraintData : IAnimationJobData, IMultiAimConstraintData
{
	internal enum Axis
	{
		X = 0,
		X_NEG = 1,
		Y = 2,
		Y_NEG = 3,
		Z = 4,
		Z_NEG = 5,
	}

	internal enum WorldUpType
	{
		None = 0,
		SceneUp = 1,
		ObjectUp = 2,
		ObjectRotationUp = 3,
		Vector = 4,
	}

	internal const float k_MinAngularLimit = -180; //Field offset: 0x0
	internal const float k_MaxAngularLimit = 180; //Field offset: 0x0
	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	[WeightRange(0, 1)]
	private WeightedTransformArray m_SourceObjects; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Vector3 m_Offset; //Field offset: 0x90
	[Range(-180, 180)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_MinLimit; //Field offset: 0x9C
	[Range(-180, 180)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_MaxLimit; //Field offset: 0xA0
	[NotKeyable]
	[SerializeField]
	private Axis m_AimAxis; //Field offset: 0xA4
	[NotKeyable]
	[SerializeField]
	private Axis m_UpAxis; //Field offset: 0xA8
	[NotKeyable]
	[SerializeField]
	private WorldUpType m_WorldUpType; //Field offset: 0xAC
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_WorldUpObject; //Field offset: 0xB0
	[NotKeyable]
	[SerializeField]
	private Axis m_WorldUpAxis; //Field offset: 0xB8
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainOffset; //Field offset: 0xBC
	[NotKeyable]
	[SerializeField]
	private Vector3Bool m_ConstrainedAxes; //Field offset: 0xBD

	public Axis aimAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

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

	public Vector2 limits
	{
		 get { } //Length: 8
		 set { } //Length: 48
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

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.aimAxis
	{
		private get { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.maxLimitFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.minLimitFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.offsetVector3Property
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.sourceObjectsProperty
	{
		private get { } //Length: 64
	}

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.upAxis
	{
		private get { } //Length: 8
	}

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.worldUpAxis
	{
		private get { } //Length: 8
	}

	private override int UnityEngine.Animations.Rigging.IMultiAimConstraintData.worldUpType
	{
		private get { } //Length: 8
	}

	public Axis upAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Axis worldUpAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override Transform worldUpObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public WorldUpType worldUpType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static Vector3 Convert(Axis axis) { }

	public Axis get_aimAxis() { }

	public override Transform get_constrainedObject() { }

	public override bool get_constrainedXAxis() { }

	public override bool get_constrainedYAxis() { }

	public override bool get_constrainedZAxis() { }

	public Vector2 get_limits() { }

	public override bool get_maintainOffset() { }

	public Vector3 get_offset() { }

	public override WeightedTransformArray get_sourceObjects() { }

	public Axis get_upAxis() { }

	public Axis get_worldUpAxis() { }

	public override Transform get_worldUpObject() { }

	public WorldUpType get_worldUpType() { }

	public void set_aimAxis(Axis value) { }

	public void set_constrainedObject(Transform value) { }

	public void set_constrainedXAxis(bool value) { }

	public void set_constrainedYAxis(bool value) { }

	public void set_constrainedZAxis(bool value) { }

	public void set_limits(Vector2 value) { }

	public void set_maintainOffset(bool value) { }

	public void set_offset(Vector3 value) { }

	public void set_sourceObjects(WeightedTransformArray value) { }

	public void set_upAxis(Axis value) { }

	public void set_worldUpAxis(Axis value) { }

	public void set_worldUpObject(Transform value) { }

	public void set_worldUpType(WorldUpType value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_aimAxis() { }

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_maxLimitFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_minLimitFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_offsetVector3Property() { }

	private override string UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_sourceObjectsProperty() { }

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_upAxis() { }

	private override Vector3 UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpAxis() { }

	private override int UnityEngine.Animations.Rigging.IMultiAimConstraintData.get_worldUpType() { }

}

