namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation;

[AddComponentMenu("Affordance System/Receiver/Transformation/Uniform Transform Scale Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation.UniformTransformScaleAffordanceReceiver.html")]
public class UniformTransformScaleAffordanceReceiver : FloatAffordanceReceiver
{
	[SerializeField]
	[Tooltip("Transform on which to apply scale value.")]
	private Transform m_TransformToScale; //Field offset: 0xA8
	private bool m_HasTransformToScale; //Field offset: 0xB0
	private Vector3 m_InitialScale; //Field offset: 0xB4

	public Transform transformToScale
	{
		 get { } //Length: 8
		 set { } //Length: 120
	}

	public UniformTransformScaleAffordanceReceiver() { }

	public Transform get_transformToScale() { }

	protected virtual float GetCurrentValueForCapture() { }

	protected virtual void OnAffordanceValueUpdated(float newValue) { }

	protected virtual void OnEnable() { }

	private void OnValidate() { }

	public void set_transformToScale(Transform value) { }

}

