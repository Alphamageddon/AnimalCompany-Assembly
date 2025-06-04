namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Vector3 Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.Vector3AffordanceReceiver.html")]
public class Vector3AffordanceReceiver : BaseAsyncAffordanceStateReceiver<float3>
{
	[SerializeField]
	[Tooltip("Vector3 Affordance Theme datum property used to map affordance state to a Vector3 affordance value. Can store an asset or a serialized value.")]
	private Vector3AffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x98
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated.")]
	private Vector3UnityEvent m_ValueUpdated; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly BindableVariable<float3> <affordanceValue>k__BackingField; //Field offset: 0xA8

	public Vector3AffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual BindableVariable<float3> affordanceValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected virtual BaseAffordanceTheme<float3> defaultAffordanceTheme
	{
		 get { } //Length: 88
	}

	public Vector3UnityEvent valueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3AffordanceReceiver() { }

	protected virtual BaseAffordanceTheme<float3> GenerateNewAffordanceThemeInstance() { }

	public Vector3AffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	[CompilerGenerated]
	protected virtual BindableVariable<float3> get_affordanceValue() { }

	protected virtual BaseAffordanceTheme<float3> get_defaultAffordanceTheme() { }

	public Vector3UnityEvent get_valueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(float3 newValue) { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float3>& jobData) { }

	public void set_affordanceThemeDatum(Vector3AffordanceThemeDatumProperty value) { }

	public void set_valueUpdated(Vector3UnityEvent value) { }

}

