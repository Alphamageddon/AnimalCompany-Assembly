namespace AnimalCompany.GameGen;

[CreateAssetMenu(fileName = "RoomTileset", menuName = "GameGen/Tile Set", order = 1)]
public class Tileset : ScriptableObject
{
	public List<WeightedRoomTile> tiles; //Field offset: 0x18

	public Tileset() { }

}

