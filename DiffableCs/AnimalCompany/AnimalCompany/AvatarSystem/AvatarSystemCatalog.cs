namespace AnimalCompany.AvatarSystem;

public class AvatarSystemCatalog : ScriptableObject
{
	public Vector3[] baseCageMeshVertices; //Field offset: 0x18
	public Int32[] baseCageMeshTriangles; //Field offset: 0x20
	public AttachmentPointData[] baseCageAttachmentPoints; //Field offset: 0x28
	public AvatarArmature baseSkeletonArmature; //Field offset: 0x30
	public AvatarBodyPartData[] bodyParts; //Field offset: 0x38
	public AvatarAccessoryData[] accessories; //Field offset: 0x40
	public GameObject[] shopPrefabs; //Field offset: 0x48
	private Dictionary<String, AvatarBodyPartData> _bodyPartsLookup; //Field offset: 0x50
	private Dictionary<String, AvatarAccessoryData> _accessoriesLookup; //Field offset: 0x58
	private Dictionary<String, GameObject> _shopPrefabsLookup; //Field offset: 0x60

	public Dictionary<String, AvatarAccessoryData> accessoriesLookup
	{
		 get { } //Length: 264
	}

	public Dictionary<String, AvatarBodyPartData> bodyPartsLookup
	{
		 get { } //Length: 264
	}

	public Dictionary<String, GameObject> shopPrefabsLookup
	{
		 get { } //Length: 264
	}

	public AvatarSystemCatalog() { }

	public Dictionary<String, AvatarAccessoryData> get_accessoriesLookup() { }

	public Dictionary<String, AvatarBodyPartData> get_bodyPartsLookup() { }

	public Dictionary<String, GameObject> get_shopPrefabsLookup() { }

}

