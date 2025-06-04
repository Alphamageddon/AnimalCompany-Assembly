namespace AnimalCompany.GameGen;

public class TreeRoomsArchetype : Archetype, IGenerationNode, IForceNodeIcon, IForceNodeTitle
{
	public List<Tileset> tilesets; //Field offset: 0x38
	[Range(0, 1)]
	[Tooltip("[TODO] How likely is the generator to pick multiple rooms to branch to from a single room. Branch is tested per room until it fails or there are no more sockets. Branches do not affect the possible archetype connections which are always chosen by the remaining sockets after generation.")]
	public float branchChance; //Field offset: 0x40
	[Range(-1, 1)]
	[Tooltip("[TODO] How likely is the generator to try to pick new rooms in a straight line. With 0 the generator will pick random sockets, with 1 the it will always pick a straight line if possible, -1 it will always avoid a straight line if possible.")]
	public float straighten; //Field offset: 0x44

	public override string NodeIcon
	{
		 get { } //Length: 88
	}

	public override string NodeTitle
	{
		 get { } //Length: 64
	}

	public TreeRoomsArchetype() { }

	public override NodeGenerationResponse Generate(Socket source, Generator generator) { }

	public override string get_NodeIcon() { }

	public override string get_NodeTitle() { }

}

