namespace AnimalCompany;

public class AvatarHeadView : MonoBehaviour
{
	private static readonly int PROP_PLAYER_VOLUME; //Field offset: 0x0
	[SerializeField]
	private AvatarView _avatarView; //Field offset: 0x20
	[SerializeField]
	private float _volumeSmoothStrengh; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	private float _volumeSmoothDrag; //Field offset: 0x2C
	[SerializeField]
	private float _volumeTremoloSpeed; //Field offset: 0x30
	[Range(0, 0.1)]
	[SerializeField]
	private float _volumeTremoloAmplitude; //Field offset: 0x34
	private float _volumeSmooth; //Field offset: 0x38
	private float _volumeSmoothVelocity; //Field offset: 0x3C
	private float _volume; //Field offset: 0x40

	private static AvatarHeadView() { }

	public AvatarHeadView() { }

	public void Setup(UserAvatarState avatarState) { }

	private void Update() { }

	public void UpdateVoice(float volume) { }

}

