namespace AnimalCompany.GameGen;

public abstract class Archetype : ForceNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public SocketFlag requiredFlags; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <TryPickSocket>b__0(Socket x) { }

	}

	[Tooltip("Each tile in a node gets this profile assigned to it. When you enter a tile, the profile is applied to the environment.")]
	public EnvironmentVolumeProfile environmentProfile; //Field offset: 0x30

	protected Archetype() { }

	protected bool CustomBoundsCheck(Bounds a, Bounds b, float error) { }

	protected Tile PickTile(List<WeightedRoomTile> _weightedTiles) { }

	protected bool TryGenerateRooms(List<WeightedRoomTile> tiles, List<Socket> availableSockets, SocketFlag socketFlags, List<Bounds> localBounds, Generator generator, int roomCount, float boundsError, out NodeGenerationResult result) { }

	protected bool TryPickSocket(List<Socket> sockets, SocketFlag requiredFlags, out Socket pickedSocket) { }

	protected bool ValidateBounds(Bounds newB, List<Bounds> localBounds, List<Bounds> globalBounds, Bounds ignore, float boundsError) { }

}

