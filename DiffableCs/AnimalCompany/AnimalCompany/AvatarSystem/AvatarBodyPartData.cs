namespace AnimalCompany.AvatarSystem;

public class AvatarBodyPartData : ScriptableObject
{
	public ApiAvatarItemType itemType; //Field offset: 0x18
	public AvatarRawBodyPartType partType; //Field offset: 0x1C
	public Vector3 position; //Field offset: 0x20
	public Quaternion rotation; //Field offset: 0x2C
	public Mesh mesh; //Field offset: 0x40
	public Material[] materials; //Field offset: 0x48
	public AvatarBodyBoneData[] bones; //Field offset: 0x50
	public Vector3[] cage; //Field offset: 0x58
	public Int32[] meshVertexClosestCageTriangle; //Field offset: 0x60
	public AttachmentPointData[] attachmentPoints; //Field offset: 0x68
	[Header("Head Part Only")]
	public Vector3 eyePositionLeft; //Field offset: 0x70
	public Vector3 eyePositionRight; //Field offset: 0x7C
	[Header("Tail Part Only")]
	public TailBoneData[] tailBones; //Field offset: 0x88

	public AvatarBodyPartData() { }

}

