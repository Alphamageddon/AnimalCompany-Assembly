namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Visual/XR Tint Interactable Visual", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRTintInteractableVisual.html")]
public class XRTintInteractableVisual : MonoBehaviour
{
	private struct ShaderPropertyLookup
	{
		public static readonly int emissionColor; //Field offset: 0x0

		private static ShaderPropertyLookup() { }

	}

	private static readonly List<Material> s_Materials; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Tint color for interactable.")]
	private Color m_TintColor; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Tint on hover.")]
	private bool m_TintOnHover; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Tint on selection.")]
	private bool m_TintOnSelection; //Field offset: 0x31
	[SerializeField]
	[Tooltip("Renderer(s) to use for tinting (will default to any Renderer on the GameObject if not specified).")]
	private List<Renderer> m_TintRenderers; //Field offset: 0x38
	private IXRInteractable m_Interactable; //Field offset: 0x40
	private IXRHoverInteractable m_HoverInteractable; //Field offset: 0x48
	private IXRSelectInteractable m_SelectInteractable; //Field offset: 0x50
	private MaterialPropertyBlock m_TintPropertyBlock; //Field offset: 0x58
	private bool m_EmissionEnabled; //Field offset: 0x60
	private bool m_HasLoggedMaterialInstance; //Field offset: 0x61

	public Color tintColor
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public bool tintOnHover
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool tintOnSelection
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public List<Renderer> tintRenderers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRTintInteractableVisual() { }

	public XRTintInteractableVisual() { }

	protected void Awake() { }

	public Color get_tintColor() { }

	public bool get_tintOnHover() { }

	public bool get_tintOnSelection() { }

	public List<Renderer> get_tintRenderers() { }

	protected override bool GetEmissionEnabled() { }

	protected void OnDestroy() { }

	private void OnFirstHoverEntered(HoverEnterEventArgs args) { }

	private void OnFirstSelectEntered(SelectEnterEventArgs args) { }

	private void OnLastHoverExited(HoverExitEventArgs args) { }

	private void OnLastSelectExited(SelectExitEventArgs args) { }

	public void set_tintColor(Color value) { }

	public void set_tintOnHover(bool value) { }

	public void set_tintOnSelection(bool value) { }

	public void set_tintRenderers(List<Renderer> value) { }

	protected override void SetTint(bool on) { }

}

