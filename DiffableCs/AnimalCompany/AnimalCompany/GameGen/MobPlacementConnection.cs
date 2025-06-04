namespace AnimalCompany.GameGen;

public class MobPlacementConnection : ForceConnection, IForceConnectionStyle
{

	public override Color ConnectionColor
	{
		 get { } //Length: 120
	}

	public override bool Dashed
	{
		 get { } //Length: 8
	}

	public MobPlacementConnection() { }

	public override Color get_ConnectionColor() { }

	public override bool get_Dashed() { }

	public ForceNode GetOtherNode(ForceNode node) { }

}

