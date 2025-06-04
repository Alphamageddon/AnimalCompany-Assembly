namespace AnimalCompany;

public class PlayerAudioView : MonoBehaviour
{
	private static readonly Vector2 HAND_STEP_SOUND_MIN_MAX; //Field offset: 0x0
	[SerializeField]
	private AudioClip[] _audioClipsFootStep; //Field offset: 0x20
	[SerializeField]
	private AudioSource _audioSourceFootStepLeft; //Field offset: 0x28
	[SerializeField]
	private AudioSource _audioSourceFootStepRight; //Field offset: 0x30

	public int handStepClipCount
	{
		 get { } //Length: 28
	}

	private static PlayerAudioView() { }

	public PlayerAudioView() { }

	public int get_handStepClipCount() { }

	public void PlayHandstepSound(HandSide handSide, int clipIndex, float intensity01) { }

}

