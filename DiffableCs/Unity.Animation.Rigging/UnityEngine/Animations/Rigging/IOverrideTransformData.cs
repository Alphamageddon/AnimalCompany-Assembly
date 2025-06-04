namespace UnityEngine.Animations.Rigging;

public interface IOverrideTransformData
{

	public Transform constrainedObject
	{
		 get { } //Length: 0
	}

	public string positionVector3Property
	{
		 get { } //Length: 0
	}

	public string positionWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public string rotationVector3Property
	{
		 get { } //Length: 0
	}

	public string rotationWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public Transform sourceObject
	{
		 get { } //Length: 0
	}

	public int space
	{
		 get { } //Length: 0
	}

	public Transform get_constrainedObject() { }

	public string get_positionVector3Property() { }

	public string get_positionWeightFloatProperty() { }

	public string get_rotationVector3Property() { }

	public string get_rotationWeightFloatProperty() { }

	public Transform get_sourceObject() { }

	public int get_space() { }

}

