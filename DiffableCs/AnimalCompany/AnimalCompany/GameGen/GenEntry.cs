namespace AnimalCompany.GameGen;

public class GenEntry : ForceNode, IForceNodeStyle, IForceNodeTitle, IForceNodeIcon
{
	[Tooltip("If a graph has multiple entry nodes one will be chosen at random to start the generation based off weight. If an entry node has multiple branches only one will be chosen at random.")]
	public float weight; //Field offset: 0x2C

	public override Color NodeBackgroundColor
	{
		 get { } //Length: 24
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
		 get { } //Length: 64
	}

	public GenEntry() { }

	public override Color get_NodeBackgroundColor() { }

	public override string get_NodeIcon() { }

	public override Color get_NodeLabelColor() { }

	public override string get_NodeTitle() { }

}

