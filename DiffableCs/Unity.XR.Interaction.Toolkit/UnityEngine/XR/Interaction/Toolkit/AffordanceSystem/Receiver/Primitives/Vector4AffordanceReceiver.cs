namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Vector4 Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.Vector4AffordanceReceiver.html")]
public class Vector4AffordanceReceiver : BaseAsyncAffordanceStateReceiver<float4>
{
	[SerializeField]
	[Tooltip("Vector4 Affordance Theme datum property used to map affordance state to a Vector4 affordance value. Can store an asset or a serialized value.")]
	private Vector4AffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x98
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated.")]
	private Vector4UnityEvent m_ValueUpdated; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly BindableVariable<float4> <affordanceValue>k__BackingField; //Field offset: 0xA8

	public Vector4AffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual BindableVariable<float4> affordanceValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected virtual BaseAffordanceTheme<float4> defaultAffordanceTheme
	{
		 get { } //Length: 88
	}

	public Vector4UnityEvent valueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector4AffordanceReceiver() { }

	protected virtual BaseAffordanceTheme<float4> GenerateNewAffordanceThemeInstance() { }

	public Vector4AffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	[CompilerGenerated]
	protected virtual BindableVariable<float4> get_affordanceValue() { }

	protected virtual BaseAffordanceTheme<float4> get_defaultAffordanceTheme() { }

	public Vector4UnityEvent get_valueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(float4 newValue) { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float4>& jobData) { }

	public void set_affordanceThemeDatum(Vector4AffordanceThemeDatumProperty value) { }

	public void set_valueUpdated(Vector4UnityEvent value) { }

}

