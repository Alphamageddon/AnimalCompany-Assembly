namespace AnimalCompany;

public class EnvironmentHelper : MonoBehaviour
{
	[Header("Lightmap Scale")]
	[SerializeField]
	private GameObject _lightmapScaleTargetRoot; //Field offset: 0x20
	[SerializeField]
	private float _lightmapScale; //Field offset: 0x28
	[Header("Audio")]
	[SerializeField]
	private AudioMixerGroup _audioMixerGroupAmbience; //Field offset: 0x30

	public EnvironmentHelper() { }

}

