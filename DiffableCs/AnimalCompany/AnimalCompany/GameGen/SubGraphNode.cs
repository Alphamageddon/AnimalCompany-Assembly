namespace AnimalCompany.GameGen;

public class SubGraphNode : Archetype, IGenerationNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
{
	public GenGraph subGraph; //Field offset: 0x28

	public override Color NodeBackgroundColor
	{
		 get { } //Length: 116
	}

	public override string NodeIcon
	{
		 get { } //Length: 64
	}

	public override Color NodeLabelColor
	{
		 get { } //Length: 20
	}

	public override string NodeTitle
	{
		 get { } //Length: 156
	}

	public SubGraphNode() { }

	public override NodeGenerationResponse Generate(Socket source, Generator generator) { }

	public override Color get_NodeBackgroundColor() { }

	public override string get_NodeIcon() { }

	public override Color get_NodeLabelColor() { }

	public override string get_NodeTitle() { }

}

