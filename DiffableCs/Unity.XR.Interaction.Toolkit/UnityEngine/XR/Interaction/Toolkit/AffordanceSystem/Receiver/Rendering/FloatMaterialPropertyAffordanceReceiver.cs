namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Float Material Property Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.FloatMaterialPropertyAffordanceReceiver.html")]
[RequireComponent(typeof(MaterialPropertyBlockHelper))]
public class FloatMaterialPropertyAffordanceReceiver : FloatAffordanceReceiver
{
	[SerializeField]
	[Tooltip("Material Property Block Helper component reference used to set material properties.")]
	private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("Shader property name to set the float value of.")]
	private string m_FloatPropertyName; //Field offset: 0xB0
	private int m_FloatProperty; //Field offset: 0xB8

	public string floatPropertyName
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public MaterialPropertyBlockHelper materialPropertyBlockHelper
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public FloatMaterialPropertyAffordanceReceiver() { }

	protected virtual void Awake() { }

	public string get_floatPropertyName() { }

	public MaterialPropertyBlockHelper get_materialPropertyBlockHelper() { }

	protected virtual float GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(float newValue) { }

	protected void OnValidate() { }

	public void set_floatPropertyName(string value) { }

	public void set_materialPropertyBlockHelper(MaterialPropertyBlockHelper value) { }

}

