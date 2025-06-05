namespace AnimalCompany.GameGen;

[CreateAssetMenu(fileName = "GenGraph", menuName = "GameGen/Gen Graph")]
public class GenGraph : ForceGraph
{
	[Header("Generation")]
	[Space]
	[Tooltip("If true, any generation failure will throw away the generation and start over.")]
	public bool strictMode; //Field offset: 0x28
	[Tooltip("The total number of times nodes can fail before the generation is considered a failure. Cumulative. Each node type has its own internal failure metrics for per tile failures.")]
	public int maxNodeFailures; //Field offset: 0x2C
	[HideInInspector]
	public GenGraphTestResponse testResponse; //Field offset: 0x30

	public GenGraph() { }

	public List<T> GetConnectionsOfType() { }

	public List<ForceConnection> GetNodeConnections(ForceNode node) { }

	public List<T> GetNodeConnectionsOfType(ForceNode node) { }

	public List<T> GetNodesOfType() { }

	public virtual Dictionary<Type, List`1<ValueTuple`2<String, Type>>> GraphConnectionTypes() { }

	public virtual List<ValueTuple`2<String, Type>> GraphNodeTypes() { }

	public virtual bool ValidateConnectionRequest(ForceNode from, ForceNode to, Type connectionType) { }

}

