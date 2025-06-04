namespace AnimalCompany;

public class GraphicsSettingsManager : MonoBehaviour
{
	public const string KEYWORD_DISABLE_CUSTOM_ATTEN = "_DISABLE_CUSTOM_ATTEN"; //Field offset: 0x0
	private GlobalKeyword _disableCustomAttenKeyword; //Field offset: 0x20

	public GraphicsSettingsManager() { }

	private void Awake() { }

	private void OnDestroy() { }

}

