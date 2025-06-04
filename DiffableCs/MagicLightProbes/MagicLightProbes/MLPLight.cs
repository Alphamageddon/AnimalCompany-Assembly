namespace MagicLightProbes;

[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
public class MLPLight : MonoBehaviour
{
	internal enum CalculationMode
	{
		AccurateShadows = 0,
		LightIntensity = 1,
	}

	internal enum MLPLightType
	{
		Spot = 0,
		Directional = 1,
		Point = 2,
		Area = 3,
		Mesh = 4,
	}

	internal enum MLPLightTypeMA
	{
		Area = 3,
		Mesh = 4,
	}

	internal enum ShadowmaskMode
	{
		Shadowmask = 0,
		DistanceShadowmask = 1,
	}

	internal enum TracePointSettingMode
	{
		Auto = 0,
		Custom = 1,
	}

	public MLPLightType lightType; //Field offset: 0x20
	public MLPLightType lastLightType; //Field offset: 0x24
	public MLPLightTypeMA lightTypeMA; //Field offset: 0x28
	public CalculationMode calculationMode; //Field offset: 0x2C
	public TracePointSettingMode tracePointSettingType; //Field offset: 0x30
	public LightmapBakeType lightMode; //Field offset: 0x34
	public ShadowmaskMode shadowmaskMode; //Field offset: 0x38
	public Light targetLight; //Field offset: 0x40
	public GameObject parentGameObject; //Field offset: 0x48
	public Vector3 position; //Field offset: 0x50
	public Vector3 forward; //Field offset: 0x5C
	public bool saveNearbyProbes; //Field offset: 0x68
	public float saveRadius; //Field offset: 0x6C
	public float range; //Field offset: 0x70
	public bool useSourceParameters; //Field offset: 0x74
	public bool reverseDirection; //Field offset: 0x75
	public float angle; //Field offset: 0x78
	public bool customTracePoints; //Field offset: 0x7C
	public bool accurateTrace; //Field offset: 0x7D
	public int accuracy; //Field offset: 0x80
	public int lastAccuracy; //Field offset: 0x84
	public bool isDirectional; //Field offset: 0x88
	public float tracePointSize; //Field offset: 0x8C
	public float lastTracePointSize; //Field offset: 0x90
	public MeshFilter lastMesh; //Field offset: 0x98
	public List<GameObject> tracePoints; //Field offset: 0xA0
	public List<MLPTracePoint> tracePointsData; //Field offset: 0xA8
	public MLPTracePoint mainTracePoint; //Field offset: 0xB0
	public MagicLightProbes parentVolume; //Field offset: 0xB8
	public bool showOptionsInManagerWindow; //Field offset: 0xC0
	public float intensity; //Field offset: 0xC4
	public bool resetEditor; //Field offset: 0xC8
	public bool showLightOnScene; //Field offset: 0xC9
	public bool saveOnOutOfRange; //Field offset: 0xCA
	public bool isHDRP; //Field offset: 0xCB
	public Vector2 hdrpAreaSize; //Field offset: 0xCC

	public MLPLight() { }

}

