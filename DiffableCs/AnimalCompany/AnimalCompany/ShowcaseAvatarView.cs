namespace AnimalCompany;

public class ShowcaseAvatarView : MonoBehaviour
{
	public Color primaryColor; //Field offset: 0x20
	[Space]
	public string head; //Field offset: 0x30
	public string eyeLeft; //Field offset: 0x38
	public string eyeRight; //Field offset: 0x40
	public string torso; //Field offset: 0x48
	public string armLeft; //Field offset: 0x50
	public string armRight; //Field offset: 0x58
	public string butt; //Field offset: 0x60
	public string tail; //Field offset: 0x68
	[Space]
	public String[] accessories; //Field offset: 0x70
	[Space]
	public AvatarView avatarView; //Field offset: 0x78

	public ShowcaseAvatarView() { }

	private void Awake() { }

}

