namespace AnimalCompany.GameGen;

public class GraphGenerationResult
{
	public Dictionary<IGenerationNode, NodeGenerationResult> nodeResults; //Field offset: 0x10
	public List<List`1<NodeGenerationResult>> nodeResultsByZone; //Field offset: 0x18
	public List<NavZone> navZones; //Field offset: 0x20

	public GraphGenerationResult() { }

}

