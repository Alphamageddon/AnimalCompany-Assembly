namespace AnimalCompany.GameGen;

public class Socket : MonoBehaviour
{
	public SocketType socketType; //Field offset: 0x20
	[Tooltip("Sometimes during generation sockets are randomly chosen but biased towards entrances. Set this flag if you want players to enter from specific sockets. Remember that the generator is non-linear, so plays might not always enter from an entrance.")]
	public bool useAsEntrance; //Field offset: 0x24
	[Space]
	[Tooltip("A random open variant is used when the socket is connected to another tile. Aka an open doorway.")]
	public List<GameObject> openVariants; //Field offset: 0x28
	[Tooltip("A random closed variant is used when the socket is not connected to another tile. Aka a closed doorway.")]
	public List<GameObject> closedVariants; //Field offset: 0x30
	public Bounds lastEvaluatedBounds; //Field offset: 0x38
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; //Field offset: 0x50

	public private bool isOpen
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Socket() { }

	private void DrawGizmoInternal(float opacity) { }

	[CompilerGenerated]
	public bool get_isOpen() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	[CompilerGenerated]
	private void set_isOpen(bool value) { }

	public void SetOpen(bool open) { }

}

