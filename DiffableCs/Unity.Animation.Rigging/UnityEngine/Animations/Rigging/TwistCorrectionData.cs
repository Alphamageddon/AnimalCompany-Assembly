namespace UnityEngine.Animations.Rigging;

public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData
{
	internal enum Axis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[SerializeField]
	[SyncSceneToStream]
	private Transform m_Source; //Field offset: 0x0
	[NotKeyable]
	[SerializeField]
	private Axis m_TwistAxis; //Field offset: 0x8
	[SerializeField]
	[SyncSceneToStream]
	[WeightRange(-1, 1)]
	private WeightedTransformArray m_TwistNodes; //Field offset: 0x10

	public Transform sourceObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Axis twistAxis
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override WeightedTransformArray twistNodes
	{
		 get { } //Length: 16
		 set { } //Length: 24
	}

	private override Transform UnityEngine.Animations.Rigging.ITwistCorrectionData.source
	{
		private get { } //Length: 8
	}

	private override Vector3 UnityEngine.Animations.Rigging.ITwistCorrectionData.twistAxis
	{
		private get { } //Length: 8
	}

	private override string UnityEngine.Animations.Rigging.ITwistCorrectionData.twistNodesProperty
	{
		private get { } //Length: 64
	}

	private static Vector3 Convert(Axis axis) { }

	public Transform get_sourceObject() { }

	public Axis get_twistAxis() { }

	public override WeightedTransformArray get_twistNodes() { }

	public void set_sourceObject(Transform value) { }

	public void set_twistAxis(Axis value) { }

	public void set_twistNodes(WeightedTransformArray value) { }

	private override bool UnityEngine.Animations.Rigging.IAnimationJobData.IsValid() { }

	private override void UnityEngine.Animations.Rigging.IAnimationJobData.SetDefaultValues() { }

	private override Transform UnityEngine.Animations.Rigging.ITwistCorrectionData.get_source() { }

	private override Vector3 UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistAxis() { }

	private override string UnityEngine.Animations.Rigging.ITwistCorrectionData.get_twistNodesProperty() { }

}

