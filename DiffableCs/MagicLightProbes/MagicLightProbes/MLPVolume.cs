namespace MagicLightProbes;

[ExecuteInEditMode]
public class MLPVolume : MonoBehaviour
{
	[HideInInspector]
	public MagicLightProbes parentRootComponent; //Field offset: 0x20
	[HideInInspector]
	public MeshRenderer selfRenderer; //Field offset: 0x28
	[HideInInspector]
	public bool showGizmo; //Field offset: 0x30
	public bool showGizmoSelected; //Field offset: 0x31
	public bool isPartVolume; //Field offset: 0x32
	public bool isSubdividedPart; //Field offset: 0x33
	public bool isCalculated; //Field offset: 0x34
	public bool isInProcess; //Field offset: 0x35
	public bool skipped; //Field offset: 0x36
	public int id; //Field offset: 0x38
	public Color colorOnSelection; //Field offset: 0x3C
	public List<MLPPointData> localAcceptedPoints; //Field offset: 0x50
	public List<MLPPointData> localNearbyGeometryPoints; //Field offset: 0x58
	public List<MLPPointData> localContrastPoints; //Field offset: 0x60
	public List<MLPPointData> localCornerPoints; //Field offset: 0x68
	public List<Vector3> localNearbyGeometryPointsPositions; //Field offset: 0x70
	public List<Vector3> resultNearbyGeometryPointsPositions; //Field offset: 0x78
	public List<Vector3> localCornerPointsPositions; //Field offset: 0x80
	public List<Vector3> resultLocalCornerPointsPositions; //Field offset: 0x88
	public List<Vector3> localEquivalentPointsPositions; //Field offset: 0x90
	public List<Vector3> resultLocalEquivalentPointsPositions; //Field offset: 0x98
	public List<Vector3> resultLocalFreePointsPositions; //Field offset: 0xA0
	public List<Vector3> localUnlitPointsPositions; //Field offset: 0xA8
	public List<Vector3> localFreePointsPositions; //Field offset: 0xB0
	public List<Vector3> resultLocalUnlitPointsPositions; //Field offset: 0xB8
	public List<Vector3> localDirections; //Field offset: 0xC0
	public List<Vector3> localAvaragedDirections; //Field offset: 0xC8
	public List<MLPPointData> localColorThresholdEditingPoints; //Field offset: 0xD0
	public int objectsInside; //Field offset: 0xD8

	public MLPVolume() { }

}

