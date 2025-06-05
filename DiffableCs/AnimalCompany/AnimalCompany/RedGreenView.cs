namespace AnimalCompany;

public class RedGreenView : MobView
{
	private static readonly int PROP_IS_GREEN; //Field offset: 0x0
	private static readonly int PROP_IS_EVIL; //Field offset: 0x4
	[ColorUsage(False, True)]
	[SerializeField]
	private Color _greenColor; //Field offset: 0x88
	[ColorUsage(False, True)]
	[SerializeField]
	private Color _redColor; //Field offset: 0x98
	[SerializeField]
	private Light _light; //Field offset: 0xA8
	[SerializeField]
	private MeshRenderer _lightMeshRenderer; //Field offset: 0xB0
	[Header("Audio_Monster")]
	[SerializeField]
	private AudioSource _audioSourceAnticipation; //Field offset: 0xB8
	[SerializeField]
	private AudioSource _audioSourceBackToStand; //Field offset: 0xC0
	[SerializeField]
	private AudioSource _audioSourceRunning; //Field offset: 0xC8
	[SerializeField]
	private AudioSource _audioSourceWalking; //Field offset: 0xD0
	[SerializeField]
	private AudioSource _audioSourceSaw; //Field offset: 0xD8
	[Header("Audio_Lights")]
	[SerializeField]
	private AudioSource _audioSourceLightGreen; //Field offset: 0xE0
	[SerializeField]
	private AudioSource _audioSourceLightGreenLoop; //Field offset: 0xE8
	[SerializeField]
	private AudioSource _audioSourceLightRed; //Field offset: 0xF0
	[Header("Saws")]
	[SerializeField]
	private Transform[] _sawTransforms; //Field offset: 0xF8
	private bool _isSawRotating; //Field offset: 0x100
	private Single[] _sawRotationSpeeds; //Field offset: 0x108

	private static RedGreenView() { }

	public RedGreenView() { }

	public void PlayAnticipationSound() { }

	public void PlayBackToStandSound() { }

	public void PlayRunningSound(bool play) { }

	private void PlaySawSound(bool play) { }

	public void PlayWalkingSound(bool play) { }

	public void SetLightColor(bool isGreen) { }

	public void SetLightEvil(bool isEvil) { }

	public void SetSawRotation(bool rotate) { }

	protected virtual void Update() { }

}

