namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

[AddComponentMenu("XR/XR Hand Skeleton Poke Displacer", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRHandSkeletonPokeDisplacer.html")]
public class XRHandSkeletonPokeDisplacer : MonoBehaviour
{
	private const float k_MinSmoothingAmount = 0; //Field offset: 0x0
	private const float k_MaxSmoothingAmount = 30; //Field offset: 0x0
	[RequireInterface(typeof(IPokeStateDataProvider))]
	[SerializeField]
	[Tooltip("Poke interactor reference used to get poke data.")]
	private object m_PokeInteractorObject; //Field offset: 0x20
	private IPokeStateDataProvider m_PokeInteractor; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Threshold poke interaction strength must be above to snap the poke pose to the current pose.")]
	private float m_PokeStrengthSnapThreshold; //Field offset: 0x30
	[Range(0, 30)]
	[SerializeField]
	[Tooltip("Smoothing to apply to the offset root. If smoothing amount is 0, no smoothing will be applied.")]
	private float m_SmoothingAmount; //Field offset: 0x34
	[SerializeField]
	[Tooltip("Additional offset subtracted along the poke interaction axis to apply to the root pose when poking. Default value accounts for the width of the finger mesh.")]
	private float m_FixedOffset; //Field offset: 0x38

	public float fixedOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public IPokeStateDataProvider pokeInteractor
	{
		 get { } //Length: 8
		 set { } //Length: 128
	}

	public float pokeStrengthSnapThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float smoothingAmount
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public XRHandSkeletonPokeDisplacer() { }

	protected void Awake() { }

	public float get_fixedOffset() { }

	public IPokeStateDataProvider get_pokeInteractor() { }

	public float get_pokeStrengthSnapThreshold() { }

	public float get_smoothingAmount() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	public void set_fixedOffset(float value) { }

	public void set_pokeInteractor(IPokeStateDataProvider value) { }

	public void set_pokeStrengthSnapThreshold(float value) { }

	public void set_smoothingAmount(float value) { }

	protected void Update() { }

}

