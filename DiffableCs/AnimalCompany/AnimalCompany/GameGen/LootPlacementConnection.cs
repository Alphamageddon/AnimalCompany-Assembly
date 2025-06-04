namespace AnimalCompany.GameGen;

public class LootPlacementConnection : ForceConnection, IForceConnectionStyle
{
	[Tooltip("When placing items, a node evaultes all its connection for every item and places into a node randomly based on the connection weights.")]
	public int weight; //Field offset: 0x28

	public override Color ConnectionColor
	{
		 get { } //Length: 128
	}

	public override bool Dashed
	{
		 get { } //Length: 8
	}

	public LootPlacementConnection() { }

	public override Color get_ConnectionColor() { }

	public override bool get_Dashed() { }

	public ForceNode GetOtherNode(ForceNode node) { }

}

