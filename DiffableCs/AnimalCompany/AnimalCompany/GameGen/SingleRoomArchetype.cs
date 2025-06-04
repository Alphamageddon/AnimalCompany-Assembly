namespace AnimalCompany.GameGen;

public class SingleRoomArchetype : Archetype, IGenerationNode, IForceNodeIcon, IForceNodeTitle
{
	public string label; //Field offset: 0x38
	[Space]
	public Tile tile; //Field offset: 0x40

	public override string NodeIcon
	{
		 get { } //Length: 88
	}

	public override string NodeTitle
	{
		 get { } //Length: 88
	}

	public SingleRoomArchetype() { }

	public override NodeGenerationResponse Generate(Socket source, Generator generator) { }

	public override string get_NodeIcon() { }

	public override string get_NodeTitle() { }

	private bool ValidateBounds(Bounds newB, List<Bounds> localBounds, List<Bounds> globalBounds, Nullable<Bounds> ignore) { }

}

