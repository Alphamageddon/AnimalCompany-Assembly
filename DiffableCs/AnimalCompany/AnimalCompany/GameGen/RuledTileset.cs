namespace AnimalCompany.GameGen;

[CreateAssetMenu(fileName = "RuledTileset", menuName = "GameGen/Ruled Tile Set")]
public class RuledTileset : ScriptableObject
{
	[HideArrayElementLabel]
	public List<RuledTile> tiles_Open; //Field offset: 0x18
	[HideArrayElementLabel]
	[Space]
	public List<RuledTile> tiles_I; //Field offset: 0x20
	[HideArrayElementLabel]
	[Space]
	public List<RuledTile> tiles_L; //Field offset: 0x28
	[HideArrayElementLabel]
	[Space]
	public List<RuledTile> tiles_II; //Field offset: 0x30
	[HideArrayElementLabel]
	[Space]
	public List<RuledTile> tiles_U; //Field offset: 0x38
	[HideArrayElementLabel]
	[Space]
	public List<RuledTile> tiles_Closed; //Field offset: 0x40

	public RuledTileset() { }

	public RuledTile GetRandomTile(TileRuleType rule) { }

}

