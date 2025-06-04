namespace AnimalCompany.GameGen;

public class Generator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ItemPoint, Boolean> <>9__27_1; //Field offset: 0x8
		public static Func<ValueTuple`2<Int32, List`1<ItemPoint>>, Int32> <>9__27_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <PickItems>b__27_0(ValueTuple<Int32, List`1<ItemPoint>> p) { }

		internal bool <PickItems>b__27_1(ItemPoint p) { }

	}

	public Generator parentGenerator; //Field offset: 0x10
	public GenGraph graph; //Field offset: 0x18
	public int nodeFailures; //Field offset: 0x20
	public int maxNodeFailures; //Field offset: 0x24
	public GraphGenerationResult generationResult; //Field offset: 0x28
	public List<Bounds> bounds; //Field offset: 0x30
	[CompilerGenerated]
	private Socket <origin>k__BackingField; //Field offset: 0x38
	public Transform mobsParent; //Field offset: 0x40
	public Transform itemsParent; //Field offset: 0x48
	public Transform netObjectsParent; //Field offset: 0x50

	public Generator activeGenerator
	{
		 get { } //Length: 16
	}

	public private Socket origin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Generator(GenGraph graph) { }

	private void CleanupHeirarchy() { }

	private void CreateNavZones(int navZoneOffset) { }

	private void DeleteOnFailure() { }

	private void FindObjects() { }

	public bool Generate(Socket origin, List<Bounds> bounds, int seed, int navZoneOffset, bool isMasterClientGen, bool deleteOnFailure = true) { }

	public bool GenerateAsSubNode(Socket origin, Generator mainGenerator) { }

	private bool GenerateTiles() { }

	public Generator get_activeGenerator() { }

	[CompilerGenerated]
	public Socket get_origin() { }

	public Bounds GetTotalBounds() { }

	private void MoveNetObjects() { }

	private bool PickItems() { }

	private bool PickMobs() { }

	private bool PickSockets() { }

	private bool RenderTiles() { }

	[CompilerGenerated]
	private void set_origin(Socket value) { }

	private void SetAllLayers() { }

	private void Shuffle(IList list) { }

}

