namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Tunneling Vignette Controller", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.TunnelingVignetteController.html")]
public class TunnelingVignetteController : MonoBehaviour
{
	private class ProviderRecord
	{
		[CompilerGenerated]
		private readonly ITunnelingVignetteProvider <provider>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private EaseState <easeState>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private float <dynamicApertureSize>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private bool <easeInLockEnded>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private float <dynamicEaseOutDelayTime>k__BackingField; //Field offset: 0x24

		public float dynamicApertureSize
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public float dynamicEaseOutDelayTime
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public bool easeInLockEnded
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 12
		}

		public EaseState easeState
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public ITunnelingVignetteProvider provider
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public ProviderRecord(ITunnelingVignetteProvider provider) { }

		[CompilerGenerated]
		public float get_dynamicApertureSize() { }

		[CompilerGenerated]
		public float get_dynamicEaseOutDelayTime() { }

		[CompilerGenerated]
		public bool get_easeInLockEnded() { }

		[CompilerGenerated]
		public EaseState get_easeState() { }

		[CompilerGenerated]
		public ITunnelingVignetteProvider get_provider() { }

		[CompilerGenerated]
		public void set_dynamicApertureSize(float value) { }

		[CompilerGenerated]
		public void set_dynamicEaseOutDelayTime(float value) { }

		[CompilerGenerated]
		public void set_easeInLockEnded(bool value) { }

		[CompilerGenerated]
		public void set_easeState(EaseState value) { }

	}

	private static class ShaderPropertyLookup
	{
		public static readonly int apertureSize; //Field offset: 0x0
		public static readonly int featheringEffect; //Field offset: 0x4
		public static readonly int vignetteColor; //Field offset: 0x8
		public static readonly int vignetteColorBlend; //Field offset: 0xC

		private static ShaderPropertyLookup() { }

	}

	private const string k_DefaultShader = "VR/TunnelingVignette"; //Field offset: 0x0
	[SerializeField]
	private VignetteParameters m_DefaultParameters; //Field offset: 0x20
	[SerializeField]
	private VignetteParameters m_CurrentParameters; //Field offset: 0x28
	[SerializeField]
	private List<LocomotionVignetteProvider> m_LocomotionVignetteProviders; //Field offset: 0x30
	private readonly List<ProviderRecord> m_ProviderRecords; //Field offset: 0x38
	private MeshRenderer m_MeshRender; //Field offset: 0x40
	private MeshFilter m_MeshFilter; //Field offset: 0x48
	private Material m_SharedMaterial; //Field offset: 0x50
	private MaterialPropertyBlock m_VignettePropertyBlock; //Field offset: 0x58

	public VignetteParameters currentParameters
	{
		 get { } //Length: 8
	}

	public VignetteParameters defaultParameters
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<LocomotionVignetteProvider> locomotionVignetteProviders
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public TunnelingVignetteController() { }

	protected override void Awake() { }

	public void BeginTunnelingVignette(ITunnelingVignetteProvider provider) { }

	public void EndTunnelingVignette(ITunnelingVignetteProvider provider) { }

	public VignetteParameters get_currentParameters() { }

	public VignetteParameters get_defaultParameters() { }

	public List<LocomotionVignetteProvider> get_locomotionVignetteProviders() { }

	[Conditional("UNITY_EDITOR")]
	internal void PreviewInEditor(VignetteParameters previewParameters) { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	public void set_defaultParameters(VignetteParameters value) { }

	public void set_locomotionVignetteProviders(List<LocomotionVignetteProvider> value) { }

	private bool TrySetUpMaterial() { }

	protected override void Update() { }

	private void UpdateTunnelingVignette(VignetteParameters parameters) { }

}

