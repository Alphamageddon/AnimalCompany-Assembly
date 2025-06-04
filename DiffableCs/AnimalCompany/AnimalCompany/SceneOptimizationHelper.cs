namespace AnimalCompany;

public class SceneOptimizationHelper : MonoBehaviour
{
	[SerializeField]
	private string _materialNameToCheck; //Field offset: 0x20
	[SerializeField]
	private TMP_FontAsset[] _fontsAllowed; //Field offset: 0x28
	[SerializeField]
	private Shader[] _shaderAllowed; //Field offset: 0x30

	public SceneOptimizationHelper() { }

}

