namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.UI;

[AddComponentMenu("Affordance System/Receiver/UI/Image Color Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.UI.ImageColorAffordanceReceiver.html")]
public class ImageColorAffordanceReceiver : ColorAffordanceReceiver
{
	[SerializeField]
	[Tooltip("Image to apply the color to.")]
	private Image m_Image; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("If set, alpha changes will be applied to the CanvasGroup rather than the Image.")]
	private CanvasGroup m_CanvasGroup; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("Ignore alpha changes in color theme.")]
	private bool m_IgnoreAlpha; //Field offset: 0xC0
	private bool m_HasImage; //Field offset: 0xC1
	private bool m_HasCanvasGroup; //Field offset: 0xC2

	public CanvasGroup canvasGroup
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool ignoreAlpha
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Image image
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ImageColorAffordanceReceiver() { }

	public CanvasGroup get_canvasGroup() { }

	public bool get_ignoreAlpha() { }

	public Image get_image() { }

	protected virtual Color GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(Color newValue) { }

	protected virtual void OnEnable() { }

	public void set_canvasGroup(CanvasGroup value) { }

	public void set_ignoreAlpha(bool value) { }

	public void set_image(Image value) { }

}

