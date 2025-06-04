namespace UnityEngine.Animations.Rigging;

public struct OverrideTransformData : IAnimationJobData, IOverrideTransformData
{
	internal enum Space
	{
		World = 0,
		Local = 1,
		Pivot = 2,
	}

	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_OverrideSource; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	private Vector3 m_OverridePosition; //Field offset: 0x10
	[SerializeField]
	[SyncSceneToStream]
	private Vector3 m_OverrideRotation; //Field offset: 0x1C
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_PositionWeight; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_RotationWeight; //Field offset: 0x2C
	[NotKeyable]
	[SerializeField]
	private Space m_Space; //Field offset: 0x30

	public override Transform constrainedObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 position
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public float positionWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public Vector3 rotation
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public float rotationWeight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override Transform sourceObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Space space
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.positionVector3Property
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.positionWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.rotationVector3Property
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.rotationWeightFloatProperty
	{
		private get { } //Length: 64
	}

	private override int UnityEngine.Animations.Rigging.IOverrideTransformData.space
	{
		private get { } //Length: 8
	}

	public override Transform get_constrainedObject() { }

	public Vector3 get_position() { }

	public float get_positionWeight() { }

	public Vector3 get_rotation() { }

	public float get_rotationWeight() { }

	public override Transform get_sourceObject() { }

	public Space get_space() { }

	public void set_constrainedObject(Transform value) { }

	public void set_position(Vector3 value) { }

	public void set_positionWeight(float value) { }

	public void set_rotation(Vector3 value) { }

	public void set_rotationWeight(float value) { }

	public void set_sourceObject(Transform value) { }

	public void set_space(Space value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionVector3Property() { }

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.get_positionWeightFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationVector3Property() { }

	private override string UnityEngine.Animations.Rigging.IOverrideTransformData.get_rotationWeightFloatProperty() { }

	private override int UnityEngine.Animations.Rigging.IOverrideTransformData.get_space() { }

}

