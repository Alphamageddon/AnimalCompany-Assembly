namespace Less3.ForceGraph;

public abstract class ForceNode : ScriptableObject, IForceNodePinnable
{
	public Vector2 position; //Field offset: 0x18
	[CompilerGenerated]
	private ForceGraph <graph>k__BackingField; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private bool _pinned; //Field offset: 0x28

	public private ForceGraph graph
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override bool pinned
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	protected ForceNode() { }

	[CompilerGenerated]
	public ForceGraph get_graph() { }

	public override bool get_pinned() { }

	[CompilerGenerated]
	private void set_graph(ForceGraph value) { }

	public override void set_pinned(bool value) { }

	public void SetGraph(ForceGraph graph) { }

	public virtual string ToString() { }

}

