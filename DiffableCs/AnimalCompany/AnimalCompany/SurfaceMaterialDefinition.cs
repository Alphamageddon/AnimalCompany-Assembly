namespace AnimalCompany;

[CreateAssetMenu(fileName = "SurfaceDefinition", menuName = "Surface + Material")]
public class SurfaceMaterialDefinition : SurfaceDefinition
{
	[Header("Surface Material Settings")]
	[Space(10)]
	public Material material; //Field offset: 0x40

	public SurfaceMaterialDefinition() { }

	private void OnValidate() { }

}

