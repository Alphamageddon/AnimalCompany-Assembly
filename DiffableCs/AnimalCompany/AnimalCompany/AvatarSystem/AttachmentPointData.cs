namespace AnimalCompany.AvatarSystem;

public class AttachmentPointData
{
	public string name; //Field offset: 0x10
	public AvatarAttachmentPointType type; //Field offset: 0x18
	public Vector3 position; //Field offset: 0x1C
	public Quaternion rotation; //Field offset: 0x28

	public AttachmentPointData() { }

}

