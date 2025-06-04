namespace AnimalCompany;

[ExecuteAlways]
public class EnvironmentVolumeManager : MonoBehaviour
{
	private static readonly int PROP_SPOOKINESS_GLOBAL; //Field offset: 0x0
	private const float LERP_SPEED = 0.333; //Field offset: 0x0
	public static EnvironmentVolumeManager instance; //Field offset: 0x8
	private static float _lerpSlider; //Field offset: 0x10
	[CompilerGenerated]
	private EnvironmentVolumeProfile <currentProfile>k__BackingField; //Field offset: 0x20
	public Light mainDirectionalLight; //Field offset: 0x28
	private float _currentSpookiness; //Field offset: 0x30

	public private EnvironmentVolumeProfile currentProfile
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static EnvironmentVolumeManager() { }

	public EnvironmentVolumeManager() { }

	private void Awake() { }

	[CompilerGenerated]
	public EnvironmentVolumeProfile get_currentProfile() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_currentProfile(EnvironmentVolumeProfile value) { }

	public static void SetEnvironmentProfile(EnvironmentVolumeProfile profile) { }

	private void Update() { }

}

