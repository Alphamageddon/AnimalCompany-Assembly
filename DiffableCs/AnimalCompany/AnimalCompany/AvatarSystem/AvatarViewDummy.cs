namespace AnimalCompany.AvatarSystem;

public class AvatarViewDummy : MonoBehaviour
{
	internal enum AvatarType
	{
		Gorilla = 0,
		Cat = 1,
		Pug = 2,
		Frog = 3,
	}

	[SerializeField]
	private AvatarType _avatarType; //Field offset: 0x20
	[SerializeField]
	private PlayerView _playerView; //Field offset: 0x28

	public AvatarViewDummy() { }

	private void Awake() { }

	private TempStateRoot<UserAvatarState> GetAvatarState(AvatarType avatarType) { }

	private Color GetRandomColor() { }

	private void Update() { }

}

