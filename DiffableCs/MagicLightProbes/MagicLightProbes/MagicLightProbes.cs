namespace MagicLightProbes;

[ExecuteInEditMode]
[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
public class MagicLightProbes : MonoBehaviour
{
	internal enum BoundsDisplayMode
	{
		Always = 0,
		OnSelection = 1,
	}

	internal enum CalculationTarget
	{
		GeometryEdges = 0,
		GeneralCalculation = 1,
	}

	internal enum DebugPasses
	{
		MaximumHeight = 0,
		GeometryCollision = 1,
		GeometryIntersections = 2,
		NearGeometry = 3,
		OutOfRange = 4,
		OutOfRangeBorders = 5,
		ShadingBorders = 6,
		ContrastAreas = 7,
		NearLights = 8,
		LightIntensity = 9,
		UnlitProbes = 10,
		EqualProbes = 11,
		GeometryEdges = 12,
		EqualColor = 13,
	}

	internal enum DrawModes
	{
		Accepted = 0,
		Culled = 1,
		Both = 2,
	}

	internal enum ExcludingLightsMode
	{
		AllInList = 0,
		AllExceptInList = 1,
	}

	internal enum FillingMode
	{
		VerticalDublicating = 0,
		FullFilling = 1,
		SeparateFilling = 2,
	}

	private struct TempPointData
	{
		public float xPos; //Field offset: 0x0
		public float yPos; //Field offset: 0x4
		public float zPos; //Field offset: 0x8

		public TempPointData(Vector3 _position) { }

	}

	internal struct VolumeParameters
	{
		public int volumeIndex; //Field offset: 0x0
		public Vector3 position; //Field offset: 0x4
		public Vector3 demensions; //Field offset: 0x10

		public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions) { }

	}

	internal enum Workflow
	{
		Simple = 0,
		Advanced = 1,
	}

	internal class WorkPathFoundEvent : UnityEvent<String>
	{

		public WorkPathFoundEvent() { }

	}

	private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/"; //Field offset: 0x0
	public static bool operationalDataLost; //Field offset: 0x0
	public IEnumerator colorThresholdRecalculationRoutine; //Field offset: 0x20
	public IEnumerator lightProbesVolumeCalculatingRoutine; //Field offset: 0x28
	public IEnumerator lightProbesVolumeCalculatingSubRoutine; //Field offset: 0x30
	public IEnumerator executingPassesRoutine; //Field offset: 0x38
	public IEnumerator volumeDivideingRoutine; //Field offset: 0x40
	public bool autoSaveSettings; //Field offset: 0x48
	public MLPSettings lastSettingsAsset; //Field offset: 0x50
	public List<String> groundAndFloorObjects; //Field offset: 0x58
	public List<String> storedGroundAndFloorKeywords; //Field offset: 0x60
	public GameObject probesVolume; //Field offset: 0x68
	public bool useDynamicDensity; //Field offset: 0x70
	public float volumeSpacing; //Field offset: 0x74
	public float volumeSpacingMin; //Field offset: 0x78
	public float volumeSpacingMax; //Field offset: 0x7C
	public float cornersDetectionThreshold; //Field offset: 0x80
	public float cornersDetectionThresholdMin; //Field offset: 0x84
	public float cornersDetectionThresholdMax; //Field offset: 0x88
	public float lastCornersDetectionThreshold; //Field offset: 0x8C
	public float lastCornersDetectionThresholdMin; //Field offset: 0x90
	public float lastCornersDetectionThresholdMax; //Field offset: 0x94
	public int lastMaxProbesInVolume; //Field offset: 0x98
	public int maxProbesInVolume; //Field offset: 0x9C
	public int defaultMaxProbesCount; //Field offset: 0xA0
	public float lastVolumeSpacing; //Field offset: 0xA4
	public float lastVolumeSpacingMin; //Field offset: 0xA8
	public float lastVolumeSpacingMax; //Field offset: 0xAC
	public bool volumeSpacingChanged; //Field offset: 0xB0
	public bool tooManySubVolumes; //Field offset: 0xB1
	public FillingMode fillingMode; //Field offset: 0xB4
	public ExcludingLightsMode excludingLightsMode; //Field offset: 0xB8
	public MLPSettings settingsAsset; //Field offset: 0xC0
	public Workflow workflow; //Field offset: 0xC8
	public float maxHeightAboveGeometry; //Field offset: 0xCC
	public float lastMaxHeightAboveGeometry; //Field offset: 0xD0
	public float maxHeightAboveTerrain; //Field offset: 0xD4
	public bool considerDistanceToLights; //Field offset: 0xD8
	public float lightIntensityTreshold; //Field offset: 0xDC
	public float colorTreshold; //Field offset: 0xE0
	public float collisionDetectionRadius; //Field offset: 0xE4
	public bool saveProbesNearbyGeometry; //Field offset: 0xE8
	public float cornerProbesSpacing; //Field offset: 0xEC
	public float nearbyGeometryDetectionRadius; //Field offset: 0xF0
	public float nearbyGeometryDetectionRadiusMin; //Field offset: 0xF4
	public float nearbyGeometryDetectionRadiusMax; //Field offset: 0xF8
	public float distanceFromNearbyGeometry; //Field offset: 0xFC
	public bool fillEquivalentVolume; //Field offset: 0x100
	public float equivalentVolumeFillingRate; //Field offset: 0x104
	public bool fillUnlitVolume; //Field offset: 0x108
	public bool fillFreeVolume; //Field offset: 0x109
	public float unlitVolumeFillingRate; //Field offset: 0x10C
	public float freeVolumeFillingRate; //Field offset: 0x110
	public bool cullAcceptedVolume; //Field offset: 0x114
	public float acceptedVolumeFillingRate; //Field offset: 0x118
	public float nearbyGeometryVolumeFillingRate; //Field offset: 0x11C
	public float verticalDublicatingHeight; //Field offset: 0x120
	public float verticalDublicatingStep; //Field offset: 0x124
	public LayerMask raycastFilter; //Field offset: 0x128
	public List<MLPLight> excludedLights; //Field offset: 0x130
	public LayerMask layerMask; //Field offset: 0x138
	public int firstCollisionLayer; //Field offset: 0x13C
	public bool useMultithreading; //Field offset: 0x140
	public GameObject previousSelection; //Field offset: 0x148
	public bool unloaded; //Field offset: 0x150
	public bool sceneChanging; //Field offset: 0x151
	public bool waitForPrevious; //Field offset: 0x152
	public MagicLightProbes previousVolume; //Field offset: 0x158
	public bool optimizeForMixedLighting; //Field offset: 0x160
	public bool lastOptimizeForMixedLightingValue; //Field offset: 0x161
	public bool lastUseDynamicDensityValue; //Field offset: 0x162
	public bool preventLeakageThroughWalls; //Field offset: 0x163
	public bool useVolumeBottom; //Field offset: 0x164
	public bool placeProbesOnGeometryEdges; //Field offset: 0x165
	public float lastColorThreshold; //Field offset: 0x168
	public float lastLightIntensityThreshold; //Field offset: 0x16C
	public float lastEquivalentVolumeFillingRate; //Field offset: 0x170
	public float lastUnlitVolumeFillingRate; //Field offset: 0x174
	public float lastFreeVolumeFillingRate; //Field offset: 0x178
	public float lastCornerProbesSpacing; //Field offset: 0x17C
	public float lastDistanceFromGeometry; //Field offset: 0x180
	public bool debugMode; //Field offset: 0x184
	public float debugObjectScale; //Field offset: 0x188
	public BoundsDisplayMode boundsDisplayMode; //Field offset: 0x18C
	public DebugPasses debugPass; //Field offset: 0x190
	public DrawModes drawMode; //Field offset: 0x194
	public bool debugShowLightIntensity; //Field offset: 0x198
	public bool showPreviewGrid; //Field offset: 0x199
	public bool nextStep; //Field offset: 0x19A
	public bool cullByColor; //Field offset: 0x19B
	public bool forceSaveProbesOnShadingBorders; //Field offset: 0x19C
	public string dataPath; //Field offset: 0x1A0
	public string workPath; //Field offset: 0x1A8
	public bool workPathFound; //Field offset: 0x1B0
	public List<Vector3> localFinishedPositions; //Field offset: 0x1B8
	public ComputeShader calculateVolumeFilling; //Field offset: 0x1C0
	public ComputeShader calculateProbeSpacing; //Field offset: 0x1C8
	public ComputeShader calculateDistanceFromGeometry; //Field offset: 0x1D0
	public MLPVolume currentVolume; //Field offset: 0x1D8
	public bool recalculationRequired; //Field offset: 0x1E0
	private List<Collider> lightColliders; //Field offset: 0x1E8
	private List<Collider> objectColliders; //Field offset: 0x1F0
	private List<MLPPointData> finalDebugAcceptedPoints; //Field offset: 0x1F8
	private List<MLPPointData> finalDebugCulledPoints; //Field offset: 0x200
	private List<GameObject> tempObjects; //Field offset: 0x208
	private List<GameObject> temporarilyDisabledDynamicObjects; //Field offset: 0x210
	private List<GameObject> staticObjectsWithoutCollider; //Field offset: 0x218
	public List<GameObject> finalStaticGameObjectsList; //Field offset: 0x220
	private GameObject combinedVolumeObject; //Field offset: 0x228
	private VolumeParameters currentEditingVolume; //Field offset: 0x230
	private Vector3 currentSelectedObjectLastPosition; //Field offset: 0x24C
	private GameObject lastSelectedObject; //Field offset: 0x258
	public bool cancelCombination; //Field offset: 0x260
	public List<IEnumerator> passesToExecute; //Field offset: 0x268
	public List<GameObject> staticObjects; //Field offset: 0x270
	public List<MLPLight> lights; //Field offset: 0x278
	public List<MLPPointData> tmpSharedPointsArray; //Field offset: 0x280
	public List<MLPPointData> tmpOutOfRangePoints; //Field offset: 0x288
	public List<MLPPointData> tmpOutOfMaxHeightPoints; //Field offset: 0x290
	public List<MLPPointData> tmpGeometryCollisionPoints; //Field offset: 0x298
	public List<MLPPointData> tmpContrastOnOutOfRangePoints; //Field offset: 0x2A0
	public List<MLPPointData> tmpContrastShadingBordersPoints; //Field offset: 0x2A8
	public List<MLPPointData> tmpUnlitPoints; //Field offset: 0x2B0
	public List<MLPPointData> tmpFreePoints; //Field offset: 0x2B8
	public List<MLPPointData> tmpNearbyGeometryPoints; //Field offset: 0x2C0
	public List<MLPPointData> tmpPointsNearGeometryIntersections; //Field offset: 0x2C8
	public List<MLPPointData> tmpNearbyLightsPoints; //Field offset: 0x2D0
	public List<MLPPointData> tmpEqualPoints; //Field offset: 0x2D8
	public List<MLPPointData> debugCulledPoints; //Field offset: 0x2E0
	public List<MLPPointData> debugAcceptedPoints; //Field offset: 0x2E8
	public List<GameObject> subVolumesDivided; //Field offset: 0x2F0
	public List<Vector3> points; //Field offset: 0x2F8
	public List<VolumeParameters> innerVolumes; //Field offset: 0x300
	public List<VolumeParameters> subVolumesParameters; //Field offset: 0x308
	public List<MagicLightProbes> innerVolumesObjects; //Field offset: 0x310
	public List<LayerMask> layerMasks; //Field offset: 0x318
	public List<Vector3> transformedPoints; //Field offset: 0x320
	public string assetEditorPath; //Field offset: 0x328
	public MagicLightProbes parentVolume; //Field offset: 0x330
	public bool localOperationalDataLost; //Field offset: 0x338
	public bool recombinationNeeded; //Field offset: 0x339
	public bool isInBackground; //Field offset: 0x33A
	public bool realtimeEditing; //Field offset: 0x33B
	public bool calculated; //Field offset: 0x33C
	public bool calculatingError; //Field offset: 0x33D
	public int xPointsCount; //Field offset: 0x340
	public int yPointsCount; //Field offset: 0x344
	public int zPointsCount; //Field offset: 0x348
	public float prevVolumeScaleX; //Field offset: 0x34C
	public float prevVolumeScaleY; //Field offset: 0x350
	public float prevVolumeScaleZ; //Field offset: 0x354
	public int totalProbes; //Field offset: 0x358
	public int totalProbesInSubVolume; //Field offset: 0x35C
	public int totalProbesInVolume; //Field offset: 0x360
	public bool calculatingVolume; //Field offset: 0x364
	public bool calculatingVolumeSubPass; //Field offset: 0x365
	public string currentPass; //Field offset: 0x368
	public int currentPassProgressCounter; //Field offset: 0x370
	public int currentPassProgressFrameSkipper; //Field offset: 0x374
	public float totalProgress; //Field offset: 0x378
	public float currentPassProgress; //Field offset: 0x37C
	public int selectedTab; //Field offset: 0x380
	public bool showOptionsInManagerWindow; //Field offset: 0x384
	public bool restored; //Field offset: 0x385
	public int currentVolumePart; //Field offset: 0x388
	public float eta; //Field offset: 0x38C
	public bool changed; //Field offset: 0x390
	public bool redivideParts; //Field offset: 0x391
	public bool combinedVolumeError; //Field offset: 0x392
	public bool isInPrefab; //Field offset: 0x393
	public Vector3 prefabPosition; //Field offset: 0x394
	public GameObject prefabRoot; //Field offset: 0x3A0
	public MLPPrefab prefabConnectionObject; //Field offset: 0x3A8
	public string prefabRootName; //Field offset: 0x3B0
	public bool calculatedFromPrefab; //Field offset: 0x3B8
	public string prefabUID; //Field offset: 0x3C0
	private bool passesExecuting; //Field offset: 0x3C8
	private int totalProgressCounter; //Field offset: 0x3CC
	private int totalProgressFrameSkipper; //Field offset: 0x3D0
	private float startTime; //Field offset: 0x3D4
	private float endTime; //Field offset: 0x3D8
	private bool scenePreparing; //Field offset: 0x3DC

	private static MagicLightProbes() { }

	public MagicLightProbes() { }

	public void CheckForNearContrast(MLPPointData pointForCheck) { }

	public bool UpdateProgress(int count, int period = 100) { }

	private bool UpdateTotalProgress(int count, int period = 100) { }

}

