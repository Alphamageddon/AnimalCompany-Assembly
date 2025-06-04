namespace AnimalCompany.GameGen;

public class Tile : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Socket, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<Socket, Boolean> <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetRandomSocket>b__5_0(Socket x) { }

		internal bool <TryGetRandomSocket>b__6_1(Socket x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public SocketFlag requiredFlags; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <TryGetRandomSocket>b__0(Socket x) { }

	}

	public Bounds bounds; //Field offset: 0x20
	[HideArrayElementLabel]
	[Space]
	public List<Socket> sockets; //Field offset: 0x38
	[Space]
	[Tooltip("Overrides the env profile selected in a GenGraph. Null is ok")]
	public EnvironmentVolumeProfile envOverride; //Field offset: 0x40

	public Tile() { }

	public Socket GetRandomSocket(bool biasForEntance = false) { }

	public Bounds GetWorldBounds() { }

	public void OnDrawGizmos() { }

	public override void RenderTile(Archetype archetype) { }

	public bool TryGetRandomSocket(bool biasForEntance, SocketFlag requiredFlags, out Socket socket) { }

}

