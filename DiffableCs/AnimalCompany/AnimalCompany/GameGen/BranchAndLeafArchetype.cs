namespace AnimalCompany.GameGen;

public class BranchAndLeafArchetype : Archetype, IGenerationNode, IForceNodeIcon, IForceNodeTitle
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Socket, Boolean> <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Generate>b__25_0(Socket s) { }

	}

	private const int MAX_FAILURES = 50; //Field offset: 0x0
	private const int MAX_FAILURES_IN_A_ROW = 6; //Field offset: 0x0
	private const int MAX_FAILS_PER_LEAF = 4; //Field offset: 0x0
	public string label; //Field offset: 0x38
	[HideArrayElementLabel]
	[Space]
	public List<Tileset> branchTilesets; //Field offset: 0x40
	[HideArrayElementLabel]
	public List<Tileset> leafTilesets; //Field offset: 0x48
	[Space]
	public int branchRooms; //Field offset: 0x50
	[Tooltip("If tryEveryLeaf is false, try to place this amount of leaves")]
	public int leafRooms; //Field offset: 0x54
	[Space]
	[Tooltip("if true the generator can connect child archetypes to a branch room")]
	public bool outerSocketCanBeBranch; //Field offset: 0x58
	[Tooltip("if true the generator can connect child archetypes to a leaf room")]
	public bool outerSocketCanBeLeaf; //Field offset: 0x59
	private List<WeightedRoomTile> _weightedBranchTiles; //Field offset: 0x60
	private List<WeightedRoomTile> _weightedLeafTiles; //Field offset: 0x68
	private Tile firstTile; //Field offset: 0x70
	private List<Socket> availableSockets; //Field offset: 0x78
	private List<Bounds> localBounds; //Field offset: 0x80
	private Transform nodeParent; //Field offset: 0x88
	private NodeGenerationResponse resp; //Field offset: 0x90
	private Generator generator; //Field offset: 0xB0
	private List<Socket> availableLeafSockets; //Field offset: 0xB8
	private int failures; //Field offset: 0xC0
	private int failuresInARow; //Field offset: 0xC4

	public override string NodeIcon
	{
		 get { } //Length: 88
	}

	public override string NodeTitle
	{
		 get { } //Length: 88
	}

	public BranchAndLeafArchetype() { }

	public override NodeGenerationResponse Generate(Socket source, Generator gen) { }

	private bool GenerateLeaves() { }

	public override string get_NodeIcon() { }

	public override string get_NodeTitle() { }

}

