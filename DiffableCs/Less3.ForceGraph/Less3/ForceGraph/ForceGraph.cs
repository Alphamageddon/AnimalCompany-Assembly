namespace Less3.ForceGraph;

public abstract class ForceGraph : ScriptableObject
{
	public List<ForceNode> nodes; //Field offset: 0x18
	public List<ForceConnection> connections; //Field offset: 0x20

	protected ForceGraph() { }

	public abstract Dictionary<Type, List`1<ValueTuple`2<String, Type>>> GraphConnectionTypes() { }

	public abstract List<ValueTuple`2<String, Type>> GraphNodeTypes() { }

	private void OnEnable() { }

	public override bool ValidateConnectionRequest(ForceNode from, ForceNode to, Type connectionType) { }

}

