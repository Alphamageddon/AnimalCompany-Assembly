//Type is in global namespace

[CreateAssetMenu(fileName = "New MLP Settings Asset", menuName = "Magic Tools/Magic Light Probes/Create New Settings Asset", order = 1)]
public class MLPSettings : ScriptableObject
{
	public Workflow workflow; //Field offset: 0x18
	public float probesSpacing; //Field offset: 0x1C
	public float cornersDetectionThreshold; //Field offset: 0x20
	public float cornerProbesSpacing; //Field offset: 0x24
	public float distanceFromGeometry; //Field offset: 0x28
	public int divideVolumeOnProbesCount; //Field offset: 0x2C
	public bool useVolumeBottom; //Field offset: 0x30
	public bool selectedObjectsAsGlobal; //Field offset: 0x31
	public float maxHeightAboveGeometry; //Field offset: 0x34
	public float maxHeightAboveTerrain; //Field offset: 0x38
	public LayerMask collisionDetectionLayers; //Field offset: 0x3C
	public float collisionDetectionRadius; //Field offset: 0x40
	public bool considerDistanceToLights; //Field offset: 0x44
	public FillingMode fillingMode; //Field offset: 0x48
	public float lightIntensityThreshold; //Field offset: 0x4C
	public bool cullByColor; //Field offset: 0x50
	public float colorThreshold; //Field offset: 0x54
	public bool fillEquivalentVolume; //Field offset: 0x58
	public float equivalentVolumeFillingRate; //Field offset: 0x5C
	public bool fillUnlitVolume; //Field offset: 0x60
	public float unlitVolumeFillingRate; //Field offset: 0x64
	public bool optimizeForMixedLighting; //Field offset: 0x68
	public bool tryPreventLightLeakage; //Field offset: 0x69
	public BoundsDisplayMode boundsDisplayMode; //Field offset: 0x6C

	public MLPSettings() { }

}

