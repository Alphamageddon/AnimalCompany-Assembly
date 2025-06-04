namespace AnimalCompany.AvatarSystem;

public static class AvatarSystemSettings
{
	public static readonly Dictionary<AvatarRawBodyPartType, String> FALLBACK_BODY_PART_ITEM_IDS; //Field offset: 0x0
	public const int NUM_AVATAR_BODY_PARTS = 8; //Field offset: 0x0
	public static readonly Dictionary<AvatarRawBodyPartType, ApiAvatarItemType> BODY_PART_TYPE_TO_ITEM_TYPE; //Field offset: 0x8
	public static readonly Dictionary<AvatarRawBodyPartType, AvatarBodyBones[]> BONES_BY_BODY_PART; //Field offset: 0x10
	public static readonly Dictionary<AvatarRawBodyPartType, AvatarAttachmentPointType[]> ATTACHMENT_POINTS_BY_BODY_PART; //Field offset: 0x18
	public static readonly Dictionary<AvatarRawBodyPartType, Int32[]> CAGE_INDICES_BY_BODY_PART; //Field offset: 0x20
	public static readonly Dictionary<AvatarRawBodyPartType, Int32[]> CAGE_BOUNDARY_PART_LOOKUP; //Field offset: 0x28
	public static readonly Dictionary<AvatarRawBodyPartType, Int32[]> CAGE_BOUNDARY_PART_TO_TORSO_LOOKUP; //Field offset: 0x30

	private static AvatarSystemSettings() { }

}

