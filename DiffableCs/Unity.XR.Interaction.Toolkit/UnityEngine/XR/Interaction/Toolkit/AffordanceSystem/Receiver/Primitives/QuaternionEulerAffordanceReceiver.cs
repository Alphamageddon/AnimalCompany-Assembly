namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Quaternion Euler Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.QuaternionEulerAffordanceReceiver.html")]
public class QuaternionEulerAffordanceReceiver : Vector3AffordanceReceiver
{
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated, expressed as a quaternion generated from euler angles.")]
	private QuaternionUnityEvent m_QuaternionValueUpdated; //Field offset: 0xB0

	public QuaternionUnityEvent quaternionValueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public QuaternionEulerAffordanceReceiver() { }

	public QuaternionUnityEvent get_quaternionValueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(float3 newValue) { }

	public void set_quaternionValueUpdated(QuaternionUnityEvent value) { }

}

