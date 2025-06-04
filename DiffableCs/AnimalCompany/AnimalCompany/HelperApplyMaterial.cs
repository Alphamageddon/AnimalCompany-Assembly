namespace AnimalCompany;

public class HelperApplyMaterial : MonoBehaviour
{
	public GameObject root; //Field offset: 0x20
	public Material[] materials; //Field offset: 0x28

	public HelperApplyMaterial() { }

	[ContextMenu("Apply Materials")]
	public void ApplyMaterials() { }

}

