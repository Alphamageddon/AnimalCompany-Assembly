namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Float Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.FloatAffordanceReceiver.html")]
public class FloatAffordanceReceiver : BaseAsyncAffordanceStateReceiver<Single>
{
	[SerializeField]
	[Tooltip("Float Affordance Theme datum property used to map affordance state to a float affordance value. Can store an asset or a serialized value.")]
	private FloatAffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x90
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated.")]
	private FloatUnityEvent m_ValueUpdated; //Field offset: 0x98
	[CompilerGenerated]
	private readonly BindableVariable<Single> <affordanceValue>k__BackingField; //Field offset: 0xA0

	public FloatAffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual BindableVariable<Single> affordanceValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected virtual BaseAffordanceTheme<Single> defaultAffordanceTheme
	{
		 get { } //Length: 88
	}

	public FloatUnityEvent valueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public FloatAffordanceReceiver() { }

	protected virtual BaseAffordanceTheme<Single> GenerateNewAffordanceThemeInstance() { }

	public FloatAffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	[CompilerGenerated]
	protected virtual BindableVariable<Single> get_affordanceValue() { }

	protected virtual BaseAffordanceTheme<Single> get_defaultAffordanceTheme() { }

	public FloatUnityEvent get_valueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(float newValue) { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<Single>& jobData) { }

	public void set_affordanceThemeDatum(FloatAffordanceThemeDatumProperty value) { }

	public void set_valueUpdated(FloatUnityEvent value) { }

}

