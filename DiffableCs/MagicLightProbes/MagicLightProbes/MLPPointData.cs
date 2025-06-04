namespace MagicLightProbes;

public class MLPPointData
{
	public float lightIntensity; //Field offset: 0x10
	public float maxIntencity; //Field offset: 0x14
	public Vector3 position; //Field offset: 0x18
	public int col; //Field offset: 0x24
	public int row; //Field offset: 0x28
	public int depth; //Field offset: 0x2C
	public List<Single> distancesToLights; //Field offset: 0x30
	public List<Vector3> collisionPoints; //Field offset: 0x38
	public List<MLPPointData> nearbyPoints; //Field offset: 0x40
	public List<MLPPointData> nearbyPointsOptimaziable; //Field offset: 0x48
	public bool removed; //Field offset: 0x50
	public bool outOfRange; //Field offset: 0x51
	public bool inSaveRange; //Field offset: 0x52
	public bool savedNearGeometry; //Field offset: 0x53
	public bool contrastOnOutOfRangeArea; //Field offset: 0x54
	public bool inRangeOfLight; //Field offset: 0x55
	public bool contrastOnShadingArea; //Field offset: 0x56
	public bool equalIntensity; //Field offset: 0x57
	public bool equalColor; //Field offset: 0x58
	public bool borderPoint; //Field offset: 0x59
	public bool outOfMaxHeight; //Field offset: 0x5A
	public float angleToLight; //Field offset: 0x5C
	public Vector3 contactPoint; //Field offset: 0x60
	public bool inCorner; //Field offset: 0x6C
	public bool lockForCull; //Field offset: 0x6D
	public bool onGeometryEdge; //Field offset: 0x6E
	public bool lightLeakLocked; //Field offset: 0x6F
	public Vector3 collisionNormal; //Field offset: 0x70
	public List<MLPLight> inRangeForLights; //Field offset: 0x80
	public List<MLPLight> inShadowForLights; //Field offset: 0x88
	public GameObject temporaryObject; //Field offset: 0x90
	public GameObject collisionObject; //Field offset: 0x98
	public Color averagedColor; //Field offset: 0xA0
	public bool xEndPoint; //Field offset: 0xB0
	public bool yEndPoint; //Field offset: 0xB1
	public bool zEndPoint; //Field offset: 0xB2
	public bool xStartPoint; //Field offset: 0xB3
	public bool yStartPoint; //Field offset: 0xB4
	public bool zStartPoint; //Field offset: 0xB5
	public int equivalent; //Field offset: 0xB8
	public float avaragedColorValue; //Field offset: 0xBC
	public bool isUnlit; //Field offset: 0xC0

	public MLPPointData() { }

	public void SetInContrastArea(bool value) { }

	public void SetInSaveRange(bool value) { }

	public void SetLightIntensity(float intensity) { }

	public void SetOutOfRange(bool visibility) { }

	public void SetPosition(Vector3 position) { }

}

