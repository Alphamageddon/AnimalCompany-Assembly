namespace AnimalCompany.PrototypeOne;

public class MobView : MonoBehaviour
{
	private static readonly int ANIM_BOOL_ISWALK; //Field offset: 0x0
	private static readonly int ANIM_FLOAT_SPEED; //Field offset: 0x4
	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	private AudioSource _audioSourceNotice; //Field offset: 0x28
	[SerializeField]
	private AudioSource _audioSourceWalk; //Field offset: 0x30
	[SerializeField]
	private AudioClip _audioNotice; //Field offset: 0x38
	[SerializeField]
	private AudioClip _audioWalk; //Field offset: 0x40
	[SerializeField]
	private AudioClip _audioRun; //Field offset: 0x48

	public bool isWalking
	{
		 get { } //Length: 112
	}

	private static MobView() { }

	public MobView() { }

	public bool get_isWalking() { }

	public bool IsSoundRunPlaying() { }

	public void PlaySound(AudioClip clip) { }

	public void PlaySoundNotice() { }

	public void PlaySoundRun() { }

	public void PlaySoundWalk() { }

	public void SetWalk(bool isWalking) { }

	public void SetWalkSpeed(float speed) { }

	public void StopSoundWalk() { }

}

