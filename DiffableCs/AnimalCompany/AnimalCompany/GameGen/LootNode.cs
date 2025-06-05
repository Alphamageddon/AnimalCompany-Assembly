namespace AnimalCompany.GameGen;

public class LootNode : ForceNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
{
	public int value; //Field offset: 0x20
	public List<ItemSet> itemSets; //Field offset: 0x28

	public override Color NodeBackgroundColor
	{
		 get { } //Length: 128
	}

	public override string NodeIcon
	{
		 get { } //Length: 88
	}

	public override Color NodeLabelColor
	{
		 get { } //Length: 20
	}

	public override string NodeTitle
	{
		 get { } //Length: 132
	}

	public LootNode() { }

	public override Color get_NodeBackgroundColor() { }

	public override string get_NodeIcon() { }

	public override Color get_NodeLabelColor() { }

	public override string get_NodeTitle() { }

}

