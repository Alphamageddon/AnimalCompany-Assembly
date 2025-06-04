namespace UnityEngine.Animations.Rigging;

public struct DampedTransformData : IAnimationJobData, IDampedTransformData
{
	[SerializeField]
	private Transform m_ConstrainedObject; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	private Transform m_Source; //Field offset: 0x8
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_DampPosition; //Field offset: 0x10
	[Range(0, 1)]
	[SerializeField]
	[SyncSceneToStream]
	private float m_DampRotation; //Field offset: 0x14
	[NotKeyable]
	[SerializeField]
	private bool m_MaintainAim; //Field offset: 0x18

	public override Transform constrainedObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float dampPosition
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float dampRotation
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public override bool maintainAim
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public override Transform sourceObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.IDampedTransformData.dampPositionFloatProperty
	{
		private get { } //Length: 64
	}

	private override string UnityEngine.Animations.Rigging.IDampedTransformData.dampRotationFloatProperty
	{
		private get { } //Length: 64
	}

	public override Transform get_constrainedObject() { }

	public float get_dampPosition() { }

	public float get_dampRotation() { }

	public override bool get_maintainAim() { }

	public override Transform get_sourceObject() { }

	public void set_constrainedObject(Transform value) { }

	public void set_dampPosition(float value) { }

	public void set_dampRotation(float value) { }

	public void set_maintainAim(bool value) { }

	public void set_sourceObject(Transform value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IDampedTransformData.get_dampPositionFloatProperty() { }

	private override string UnityEngine.Animations.Rigging.IDampedTransformData.get_dampRotationFloatProperty() { }

}

