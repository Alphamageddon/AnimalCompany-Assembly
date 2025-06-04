namespace AnimalCompany;

public class BodyPartCullDebug : MonoBehaviour
{
	public AvatarBodyPartData[] bodyParts; //Field offset: 0x20
	public SkinnedMeshRenderer[] bodyPartRenderers; //Field offset: 0x28
	public AvatarAccessoryData accessoryData; //Field offset: 0x30

	public BodyPartCullDebug() { }

	private void Awake() { }

	private void OnEnable() { }

}

