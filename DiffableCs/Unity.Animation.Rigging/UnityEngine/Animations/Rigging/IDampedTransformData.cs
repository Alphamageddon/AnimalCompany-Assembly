namespace UnityEngine.Animations.Rigging;

public interface IDampedTransformData
{

	public Transform constrainedObject
	{
		 get { } //Length: 0
	}

	public string dampPositionFloatProperty
	{
		 get { } //Length: 0
	}

	public string dampRotationFloatProperty
	{
		 get { } //Length: 0
	}

	public bool maintainAim
	{
		 get { } //Length: 0
	}

	public Transform sourceObject
	{
		 get { } //Length: 0
	}

	public Transform get_constrainedObject() { }

	public string get_dampPositionFloatProperty() { }

	public string get_dampRotationFloatProperty() { }

	public bool get_maintainAim() { }

	public Transform get_sourceObject() { }

}

