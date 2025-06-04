namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Color Gradient Line Renderer Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.ColorGradientLineRendererAffordanceReceiver.html")]
public class ColorGradientLineRendererAffordanceReceiver : ColorAffordanceReceiver
{
	internal enum LineColorProperty
	{
		StartColor = 0,
		EndColor = 1,
	}

	[SerializeField]
	[Tooltip("Line Renderer on which to animate colors.")]
	private LineRenderer m_LineRenderer; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("Mode determining how color is applied to the associated Line Renderer.")]
	private LineColorProperty m_LineColorProperty; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("Prevent XR Interactor Line Visual from controlling line rendering color if present.")]
	private bool m_DisableXRInteractorLineVisualColorControlIfPresent; //Field offset: 0xBC
	private Color m_InitialStartColor; //Field offset: 0xC0
	private Color m_InitialEndColor; //Field offset: 0xD0

	public bool disableXRInteractorLineVisualColorControlIfPresent
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public LineColorProperty lineColorProperty
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	public LineRenderer lineRenderer
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ColorGradientLineRendererAffordanceReceiver() { }

	protected virtual void Awake() { }

	protected virtual void CaptureInitialValue() { }

	public bool get_disableXRInteractorLineVisualColorControlIfPresent() { }

	public LineColorProperty get_lineColorProperty() { }

	public LineRenderer get_lineRenderer() { }

	protected virtual Color GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(Color newValue) { }

	public void set_disableXRInteractorLineVisualColorControlIfPresent(bool value) { }

	public void set_lineColorProperty(LineColorProperty value) { }

	public void set_lineRenderer(LineRenderer value) { }

	protected virtual void Start() { }

}

