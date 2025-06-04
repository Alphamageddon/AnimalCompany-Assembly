namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Vector2 Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.Vector2AffordanceReceiver.html")]
public class Vector2AffordanceReceiver : BaseAsyncAffordanceStateReceiver<float2>
{
	[SerializeField]
	[Tooltip("Vector2 Affordance Theme datum property used to map affordance state to a Vector2 affordance value. Can store an asset or a serialized value.")]
	private Vector2AffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x90
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated.")]
	private Vector2UnityEvent m_ValueUpdated; //Field offset: 0x98
	[CompilerGenerated]
	private readonly BindableVariable<float2> <affordanceValue>k__BackingField; //Field offset: 0xA0

	public Vector2AffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual BindableVariable<float2> affordanceValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected virtual BaseAffordanceTheme<float2> defaultAffordanceTheme
	{
		 get { } //Length: 88
	}

	public Vector2UnityEvent valueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector2AffordanceReceiver() { }

	protected virtual BaseAffordanceTheme<float2> GenerateNewAffordanceThemeInstance() { }

	public Vector2AffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	[CompilerGenerated]
	protected virtual BindableVariable<float2> get_affordanceValue() { }

	protected virtual BaseAffordanceTheme<float2> get_defaultAffordanceTheme() { }

	public Vector2UnityEvent get_valueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(float2 newValue) { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<float2>& jobData) { }

	public void set_affordanceThemeDatum(Vector2AffordanceThemeDatumProperty value) { }

	public void set_valueUpdated(Vector2UnityEvent value) { }

}

