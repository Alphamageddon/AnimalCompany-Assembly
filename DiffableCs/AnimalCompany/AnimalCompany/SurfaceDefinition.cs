namespace AnimalCompany;

[CreateAssetMenu(fileName = "SurfaceDefinition", menuName = "Surface")]
public class SurfaceDefinition : ScriptableObject
{
	[Header("Movement")]
	public float friction; //Field offset: 0x18
	[Header("Feedback")]
	[Space]
	public RandomSFX footstepSFX; //Field offset: 0x20
	[Header("Touch Effects")]
	[Space]
	[Tooltip("Damage dealt to the player when their hands touch the surface. Damage is applied once per touch.")]
	public int damageOnPlayerTouch; //Field offset: 0x28
	public bool vfxOnTouch; //Field offset: 0x2C
	public NetworkVFXType touchVFX; //Field offset: 0x2D
	[Header("Debug")]
	[Space]
	public Color debugColor; //Field offset: 0x30

	public SurfaceDefinition() { }

	private void OnValidate() { }

}

