namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering;

[AddComponentMenu("Affordance System/Receiver/Rendering/Vector3 Material Property Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.Vector3MaterialPropertyAffordanceReceiver.html")]
[RequireComponent(typeof(MaterialPropertyBlockHelper))]
public class Vector3MaterialPropertyAffordanceReceiver : Vector3AffordanceReceiver
{
	[SerializeField]
	[Tooltip("Material Property Block Helper component reference used to set material properties.")]
	private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper; //Field offset: 0xB0
	[SerializeField]
	[Tooltip("Shader property name to set the vector value of.")]
	private string m_Vector3PropertyName; //Field offset: 0xB8
	private int m_Vector3Property; //Field offset: 0xC0

	public MaterialPropertyBlockHelper materialPropertyBlockHelper
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string vector3PropertyName
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public Vector3MaterialPropertyAffordanceReceiver() { }

	protected virtual void Awake() { }

	public MaterialPropertyBlockHelper get_materialPropertyBlockHelper() { }

	public string get_vector3PropertyName() { }

	protected virtual float3 GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(float3 newValue) { }

	protected void OnValidate() { }

	public void set_materialPropertyBlockHelper(MaterialPropertyBlockHelper value) { }

	public void set_vector3PropertyName(string value) { }

}

