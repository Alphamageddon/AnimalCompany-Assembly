namespace AnimalCompany;

public class AvatarAccessoryData : ScriptableObject
{
	public ApiAvatarItemType itemType; //Field offset: 0x18
	public AccessorySlotType slotType; //Field offset: 0x1C
	public bool isFittedAccessory; //Field offset: 0x20
	public Vector3 position; //Field offset: 0x24
	public Quaternion rotation; //Field offset: 0x30
	public Mesh mesh; //Field offset: 0x40
	public Material material; //Field offset: 0x48
	public AttachmentPointData attachment; //Field offset: 0x50
	public AvatarCageData cageData; //Field offset: 0x58
	public GarmentRefitPreProcessResult refitData; //Field offset: 0x60
	public AvatarBodyBones[] bones; //Field offset: 0x68

        public AvatarAccessoryData()
        {
                // ScriptableObject constructor will initialise Unity specific
                // behaviour. No additional setup is required.
        }

}

