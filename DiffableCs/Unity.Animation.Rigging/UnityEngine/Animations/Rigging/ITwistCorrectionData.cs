namespace UnityEngine.Animations.Rigging;

public interface ITwistCorrectionData
{

	public Transform source
	{
		 get { } //Length: 0
	}

	public Vector3 twistAxis
	{
		 get { } //Length: 0
	}

	public WeightedTransformArray twistNodes
	{
		 get { } //Length: 0
	}

	public string twistNodesProperty
	{
		 get { } //Length: 0
	}

	public Transform get_source() { }

	public Vector3 get_twistAxis() { }

	public WeightedTransformArray get_twistNodes() { }

	public string get_twistNodesProperty() { }

}

