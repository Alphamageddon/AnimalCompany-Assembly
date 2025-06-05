namespace AnimalCompany;

public class AnglerView : MobView
{
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x0
	[ColorUsage(False, True)]
	[SerializeField]
	private Color GLOW_ON_COLOR; //Field offset: 0x88
	[ColorUsage(False, True)]
	[SerializeField]
	private Color GLOW_OFF_COLOR; //Field offset: 0x98
	[Header("Render")]
	[SerializeField]
	private Light _escaLight; //Field offset: 0xA8
	[SerializeField]
	private Renderer _renderer; //Field offset: 0xB0
	[SerializeField]
	private DynamicBoneControl _dynamicBoneControl; //Field offset: 0xB8
	[Header("Sound")]
	[SerializeField]
	private AudioSource _audioSourceFoundLight; //Field offset: 0xC0
	[SerializeField]
	private AudioSource _audioSourceAnticipation; //Field offset: 0xC8
	[SerializeField]
	private AudioSource _audioSourceRunning; //Field offset: 0xD0
	[Header("Animation")]
	[SerializeField]
	private Transform _boneRoot; //Field offset: 0xD8
	[SerializeField]
	private float _rootAnimSpeed; //Field offset: 0xE0
	[SerializeField]
	private Vector2 _rootAnimRange; //Field offset: 0xE4
	[SerializeField]
	private float _rootAnimYOffset; //Field offset: 0xEC
	private Vector3 _boneRootInitialPositionLS; //Field offset: 0xF0
	[SerializeField]
	[Space(5)]
	private Vector2 _rootAnimRotRange; //Field offset: 0xFC
	[SerializeField]
	private Vector2 _rootAnimRotSpeedOffset; //Field offset: 0x104
	[SerializeField]
	private float _rootAnimRotOffset; //Field offset: 0x10C
	private Vector3 _boneRootInitialRotation; //Field offset: 0x110

	private static AnglerView() { }

	public AnglerView() { }

	protected virtual void Awake() { }

	private void LateUpdate() { }

	public void PlayFoundLightSound() { }

	public void PlayRunningSound(bool play, float volume = 1) { }

	public void SetAnimSpeed(bool isRunning) { }

	public virtual void SetAnticipation() { }

	public void SetGlow(bool glow, bool forceZero = false) { }

	protected virtual void Update() { }

}

