namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

[AddComponentMenu("Affordance System/Receiver/Primitives/Color Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.ColorAffordanceReceiver.html")]
public class ColorAffordanceReceiver : BaseAsyncAffordanceStateReceiver<Color>
{
	[SerializeField]
	[Tooltip("Color Affordance Theme datum property used to map affordance state to a color affordance value. Can store an asset or a serialized value.")]
	private ColorAffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x98
	[SerializeField]
	[Tooltip("The event that is called when the current affordance value is updated.")]
	private ColorUnityEvent m_ValueUpdated; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly BindableVariable<Color> <affordanceValue>k__BackingField; //Field offset: 0xA8

	public ColorAffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual BindableVariable<Color> affordanceValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected virtual BaseAffordanceTheme<Color> defaultAffordanceTheme
	{
		 get { } //Length: 88
	}

	public ColorUnityEvent valueUpdated
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ColorAffordanceReceiver() { }

	protected virtual BaseAffordanceTheme<Color> GenerateNewAffordanceThemeInstance() { }

	public ColorAffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	[CompilerGenerated]
	protected virtual BindableVariable<Color> get_affordanceValue() { }

	protected virtual BaseAffordanceTheme<Color> get_defaultAffordanceTheme() { }

	public ColorUnityEvent get_valueUpdated() { }

	protected virtual void OnAffordanceValueUpdated(Color newValue) { }

	protected virtual JobHandle ScheduleTweenJob(ref TweenJobData<Color>& jobData) { }

	public void set_affordanceThemeDatum(ColorAffordanceThemeDatumProperty value) { }

	public void set_valueUpdated(ColorUnityEvent value) { }

}

