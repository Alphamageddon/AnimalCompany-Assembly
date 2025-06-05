namespace AnimalCompany.GameGen;

public struct WeightedRoomTile
{
	public Tile tile; //Field offset: 0x0
	public float weight; //Field offset: 0x8
	[Tooltip("During generation the weight of a tile is multiplied by the Y value of the curve per the current DEPTH of generation. Depth is a 01 float based on the current node depth compared to the max node depth. It is NOT based on the max graph depth. Clamped to a max value of 1.")]
	public AnimationCurve depthCurve; //Field offset: 0x10

}

