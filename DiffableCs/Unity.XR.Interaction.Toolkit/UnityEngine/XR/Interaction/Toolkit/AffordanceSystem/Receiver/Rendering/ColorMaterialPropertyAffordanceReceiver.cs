namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Color Material Property Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.ColorMaterialPropertyAffordanceReceiver.html")]
[RequireComponent(typeof(MaterialPropertyBlockHelper))]
public class ColorMaterialPropertyAffordanceReceiver : ColorAffordanceReceiver
{
	[IsReadOnly]
	private struct ShaderPropertyLookup
	{
		public static readonly int baseColor; //Field offset: 0x0
		public static readonly int color; //Field offset: 0x4

		private static ShaderPropertyLookup() { }

	}

	[SerializeField]
	[Tooltip("Material Property Block Helper component reference used to set material properties.")]
	private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("Shader property name to set the color of. When empty, the component will attempt to use the default for the current render pipeline.")]
	private string m_ColorPropertyName; //Field offset: 0xB8
	private int m_ColorProperty; //Field offset: 0xC0

	public string colorPropertyName
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public MaterialPropertyBlockHelper materialPropertyBlockHelper
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ColorMaterialPropertyAffordanceReceiver() { }

	protected virtual void Awake() { }

	public string get_colorPropertyName() { }

	public MaterialPropertyBlockHelper get_materialPropertyBlockHelper() { }

	protected virtual Color GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(Color newValue) { }

	protected void OnValidate() { }

	public void set_colorPropertyName(string value) { }

	public void set_materialPropertyBlockHelper(MaterialPropertyBlockHelper value) { }

	private void UpdateColorPropertyID() { }

}

