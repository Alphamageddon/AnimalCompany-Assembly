namespace UnityEngine.Animations.Rigging;

public interface IBlendConstraintData
{

	public string blendPositionBoolProperty
	{
		 get { } //Length: 0
	}

	public string blendRotationBoolProperty
	{
		 get { } //Length: 0
	}

	public Transform constrainedObject
	{
		 get { } //Length: 0
	}

	public bool maintainPositionOffsets
	{
		 get { } //Length: 0
	}

	public bool maintainRotationOffsets
	{
		 get { } //Length: 0
	}

	public string positionWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public string rotationWeightFloatProperty
	{
		 get { } //Length: 0
	}

	public Transform sourceObjectA
	{
		 get { } //Length: 0
	}

	public Transform sourceObjectB
	{
		 get { } //Length: 0
	}

	public string get_blendPositionBoolProperty() { }

	public string get_blendRotationBoolProperty() { }

	public Transform get_constrainedObject() { }

	public bool get_maintainPositionOffsets() { }

	public bool get_maintainRotationOffsets() { }

	public string get_positionWeightFloatProperty() { }

	public string get_rotationWeightFloatProperty() { }

	public Transform get_sourceObjectA() { }

	public Transform get_sourceObjectB() { }

}

