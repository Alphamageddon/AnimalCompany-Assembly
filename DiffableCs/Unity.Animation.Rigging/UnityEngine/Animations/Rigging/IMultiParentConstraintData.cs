namespace UnityEngine.Animations.Rigging;

public interface IMultiParentConstraintData
{

	public Transform constrainedObject
	{
		 get { } //Length: 0
	}

	public bool constrainedPositionXAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedPositionYAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedPositionZAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedRotationXAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedRotationYAxis
	{
		 get { } //Length: 0
	}

	public bool constrainedRotationZAxis
	{
		 get { } //Length: 0
	}

	public bool maintainPositionOffset
	{
		 get { } //Length: 0
	}

	public bool maintainRotationOffset
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

	public bool get_constrainedPositionXAxis() { }

	public bool get_constrainedPositionYAxis() { }

	public bool get_constrainedPositionZAxis() { }

	public bool get_constrainedRotationXAxis() { }

	public bool get_constrainedRotationYAxis() { }

	public bool get_constrainedRotationZAxis() { }

	public bool get_maintainPositionOffset() { }

	public bool get_maintainRotationOffset() { }

	public WeightedTransformArray get_sourceObjects() { }

	public string get_sourceObjectsProperty() { }

}

