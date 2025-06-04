namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Vector2 Material Property Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.Vector2MaterialPropertyAffordanceReceiver.html")]
[RequireComponent(typeof(MaterialPropertyBlockHelper))]
public class Vector2MaterialPropertyAffordanceReceiver : Vector2AffordanceReceiver
{
	[SerializeField]
	[Tooltip("Material Property Block Helper component reference used to set material properties.")]
	private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper; //Field offset: 0xA8
	[SerializeField]
	[Tooltip("Shader property name to set the vector value of.")]
	private string m_Vector2PropertyName; //Field offset: 0xB0
	private int m_Vector2Property; //Field offset: 0xB8

	public MaterialPropertyBlockHelper materialPropertyBlockHelper
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string vector2PropertyName
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public Vector2MaterialPropertyAffordanceReceiver() { }

	protected virtual void Awake() { }

	public MaterialPropertyBlockHelper get_materialPropertyBlockHelper() { }

	public string get_vector2PropertyName() { }

	protected virtual float2 GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(float2 newValue) { }

	protected void OnValidate() { }

	public void set_materialPropertyBlockHelper(MaterialPropertyBlockHelper value) { }

	public void set_vector2PropertyName(string value) { }

}

