namespace UnityEngine.Animations.Rigging;

public interface IMultiRotationConstraintData
{

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

	public Transform get_constrainedObject() { }

	public bool get_constrainedXAxis() { }

	public bool get_constrainedYAxis() { }

	public bool get_constrainedZAxis() { }

	public bool get_maintainOffset() { }

	public string get_offsetVector3Property() { }

	public WeightedTransformArray get_sourceObjects() { }

	public string get_sourceObjectsProperty() { }

}

