namespace AnimalCompany;

[CreateAssetMenu(fileName = "EnvironmentVolumeProfile", menuName = "EnvironmentVolumeProfile")]
public class EnvironmentVolumeProfile : ScriptableObject
{
	[Header("Environment")]
	public Color realtimeShadowColor; //Field offset: 0x18
	public Color ambientColor; //Field offset: 0x28
	public Color skyboxColor; //Field offset: 0x38
	[Header("Fog")]
	[Space]
	public Color fogColor; //Field offset: 0x48
	public float fogDensity; //Field offset: 0x58
	[Header("Directional Light")]
	[Space]
	public Color directionalLightColor; //Field offset: 0x5C
	public float directionalLightIntensity; //Field offset: 0x6C
	[Header("Spookiness")]
	[Range(0, 1)]
	[Space]
	public float spookiness; //Field offset: 0x70
	[Header("Audio")]
	[Space]
	[Tooltip("Only non-custom presets work right now.")]
	public AudioReverbPreset reverbPreset; //Field offset: 0x74
	[Header("Physics")]
	[Space]
	public bool useCustomGravity; //Field offset: 0x78
	public Vector3 customGravity; //Field offset: 0x7C

	public EnvironmentVolumeProfile() { }

}

