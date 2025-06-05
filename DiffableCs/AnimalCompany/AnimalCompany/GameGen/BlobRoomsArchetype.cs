namespace AnimalCompany.GameGen;

public class BlobRoomsArchetype : Archetype, IGenerationNode, IForceNodeIcon, IForceNodeTitle
{
	private const int MAX_FAILURES = 50; //Field offset: 0x0
	private const int MAX_FAILURES_IN_A_ROW = 6; //Field offset: 0x0
	public string label; //Field offset: 0x28
	[Space]
	public List<Tileset> tilesets; //Field offset: 0x30
	[Header("Generation")]
	[Space]
	public int roomCount; //Field offset: 0x38
	[Tooltip("If true the generator will place more tiles close together, creating less long corridors. This REDUCES fail rate by being less strict with bounds checks.")]
	public bool moreBlobby; //Field offset: 0x3C
	private List<WeightedRoomTile> _weightedTiles; //Field offset: 0x40

	public override string NodeIcon
	{
		 get { } //Length: 88
	}

	public override string NodeTitle
	{
		 get { } //Length: 88
	}

	public BlobRoomsArchetype() { }

	private bool CustomBoundsCheck(Bounds a, Bounds b, float error = 0.01) { }

	public override NodeGenerationResponse Generate(Socket source, Generator generator) { }

	public override string get_NodeIcon() { }

	public override string get_NodeTitle() { }

	private Tile PickTileWithDepth(float depth) { }

	private bool ValidateBounds(Bounds newB, List<Bounds> localBounds, List<Bounds> globalBounds, Bounds ignore) { }

}

