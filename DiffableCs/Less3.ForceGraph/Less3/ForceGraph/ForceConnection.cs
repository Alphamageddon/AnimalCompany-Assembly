namespace Less3.ForceGraph;

public abstract class ForceConnection : ScriptableObject
{
	public ForceNode from; //Field offset: 0x18
	public ForceNode to; //Field offset: 0x20

	protected ForceConnection() { }

}

