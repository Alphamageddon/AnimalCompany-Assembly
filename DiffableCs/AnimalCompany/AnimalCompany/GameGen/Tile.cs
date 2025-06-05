namespace AnimalCompany.GameGen;

public class Tile : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Socket, Boolean> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetRandomSocket>b__4_0(Socket x) { }

	}

	public Bounds bounds; //Field offset: 0x20
	[HideArrayElementLabel]
	[Space]
	public List<Socket> sockets; //Field offset: 0x38

	public Tile() { }

	public Socket GetRandomSocket(bool biasForEntance = false) { }

	public Bounds GetWorldBounds() { }

	public void OnDrawGizmos() { }

	public override void RenderTile(Archetype archetype) { }

}

