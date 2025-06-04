namespace AnimalCompany.GameGen;

public class NodeGenerationResult
{
	public Archetype archetype; //Field offset: 0x10
	public GameObject parentObject; //Field offset: 0x18
	public List<Tile> tiles; //Field offset: 0x20
	public List<NavPoint> navPoints; //Field offset: 0x28
	public List<ItemPoint> itemPoints; //Field offset: 0x30
	public NavZone navZone; //Field offset: 0x38

	public NodeGenerationResult() { }

}

