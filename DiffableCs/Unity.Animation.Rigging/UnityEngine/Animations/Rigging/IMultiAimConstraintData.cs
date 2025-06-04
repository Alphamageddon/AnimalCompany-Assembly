namespace UnityEngine.Animations.Rigging;

public interface IMultiAimConstraintData
{

	public Vector3 aimAxis
	{
		 get { } //Length: 0
	}

	public Transform constrainedObject
	{
		 get { } //Length: 0
	}

	public bool constrainedXAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedYAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedZAxis
	{
		 get { } //Length: 0
	}

	public bool maintainOffset
	{
		 get { } //Length: 0
	}

	public string maxLimitFloatProperty
	{
		 get { } //Length: 0
	}

	public string minLimitFloatProperty
	{
		 get { } //Length: 0
	}

	public string offsetVector3Property
	{
		 get { } //Length: 0
	}

	public WeightedTransformArray sourceObjects
	{
		 get { } //Length: 0
	}

	public string sourceObjectsProperty
	{
		 get { } //Length: 0
	}

	public Vector3 upAxis
	{
		 get { } //Length: 0
	}

	public Vector3 worldUpAxis
	{
		 get { } //Length: 0
	}

	public Transform worldUpObject
	{
		 get { } //Length: 0
	}

	public int worldUpType
	{
		 get { } //Length: 0
	}

	public Vector3 get_aimAxis() { }

	public Transform get_constrainedObject() { }

	public bool get_constrainedXAxis() { }

	public bool get_constrainedYAxis() { }

	public bool get_constrainedZAxis() { }

	public bool get_maintainOffset() { }

	public string get_maxLimitFloatProperty() { }

	public string get_minLimitFloatProperty() { }

	public string get_offsetVector3Property() { }

	public WeightedTransformArray get_sourceObjects() { }

	public string get_sourceObjectsProperty() { }

	public Vector3 get_upAxis() { }

	public Vector3 get_worldUpAxis() { }

	public Transform get_worldUpObject() { }

	public int get_worldUpType() { }

}

