namespace UnityEngine.Animations.Rigging;

public interface IMultiReferentialConstraintData
{

	public string driverIntProperty
	{
		 get { } //Length: 0
	}

	public int driverValue
	{
		 get { } //Length: 0
	}

	public Transform[] sourceObjects
	{
		 get { } //Length: 0
	}

	public string get_driverIntProperty() { }

	public int get_driverValue() { }

	public Transform[] get_sourceObjects() { }

}

