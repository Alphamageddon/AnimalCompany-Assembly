namespace UnityEngine.Animations.Rigging;

public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData
{
	[SerializeField]
	[SyncSceneToStream]
	private int m_Driver; //Field offset: 0x0
	[SerializeField]
	[SyncSceneToStream]
	private List<Transform> m_SourceObjects; //Field offset: 0x8

	public int driver
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	public List<Transform> sourceObjects
	{
		 get { } //Length: 120
		 set { } //Length: 104
	}

	private override string UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.driverIntProperty
	{
		private get { } //Length: 64
	}

	private override int UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.driverValue
	{
		private get { } //Length: 8
	}

	private override Transform[] UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.sourceObjects
	{
		private get { } //Length: 80
	}

	public int get_driver() { }

	public List<Transform> get_sourceObjects() { }

	public void set_driver(int value) { }

	public void set_sourceObjects(List<Transform> value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override string UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverIntProperty() { }

	private override int UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_driverValue() { }

	private override Transform[] UnityEngine.Animations.Rigging.IMultiReferentialConstraintData.get_sourceObjects() { }

	public void UpdateDriver() { }

}

