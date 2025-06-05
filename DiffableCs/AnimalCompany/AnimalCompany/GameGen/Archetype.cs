namespace AnimalCompany.GameGen;

public abstract class Archetype : ForceNode
{
	[Tooltip("Each tile in a node gets this profile assigned to it. When you enter a tile, the profile is applied to the environment.")]
	public EnvironmentVolumeProfile environmentProfile; //Field offset: 0x20

	protected Archetype() { }

}

