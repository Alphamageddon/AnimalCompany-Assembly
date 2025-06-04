namespace AnimalCompany;

public class AvatarHeadContainer : MonoBehaviour
{
	[SerializeField]
	protected AvatarHeadView _avatarHeadView; //Field offset: 0x20

	public AvatarHeadView avatarHeadView
	{
		 get { } //Length: 8
	}

	public AvatarHeadContainer() { }

	public AvatarHeadView get_avatarHeadView() { }

}

