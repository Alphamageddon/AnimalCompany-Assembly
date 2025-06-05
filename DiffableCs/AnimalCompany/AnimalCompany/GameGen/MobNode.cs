namespace AnimalCompany.GameGen;

public class MobNode : ForceNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
{
	public string label; //Field offset: 0x20
	public GameObject mob; //Field offset: 0x28
	public int spawnCount; //Field offset: 0x30

	public override Color NodeBackgroundColor
	{
		 get { } //Length: 120
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
		 get { } //Length: 4
	}

	public MobNode() { }

	public override Color get_NodeBackgroundColor() { }

	public override string get_NodeIcon() { }

	public override Color get_NodeLabelColor() { }

	public override string get_NodeTitle() { }

	private string GetTitle() { }

}

