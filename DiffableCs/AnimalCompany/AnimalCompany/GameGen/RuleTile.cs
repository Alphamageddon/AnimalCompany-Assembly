namespace AnimalCompany.GameGen;

public class RuleTile : Tile
{
	[Header("Rule Tile Settings")]
	public RuledTileset ruledTileset; //Field offset: 0x48
	[Space]
	public Socket posZSocket; //Field offset: 0x50
	public Socket negZSocket; //Field offset: 0x58
	public Socket posXSocket; //Field offset: 0x60
	public Socket negXSocket; //Field offset: 0x68

	public RuleTile() { }

	public virtual void RenderTile(Archetype archetype) { }

}

