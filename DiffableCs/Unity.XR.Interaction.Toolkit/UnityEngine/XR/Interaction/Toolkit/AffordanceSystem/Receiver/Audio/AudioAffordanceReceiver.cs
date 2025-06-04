namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Audio;

[AddComponentMenu("Affordance System/Receiver/Audio/Audio Affordance Receiver", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Audio.AudioAffordanceReceiver.html")]
[RequireComponent(typeof(AudioSource))]
public class AudioAffordanceReceiver : MonoBehaviour
{
	[SerializeField]
	[Tooltip("Affordance state provider component to subscribe to.")]
	private BaseAffordanceStateProvider m_AffordanceStateProvider; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Audio Affordance Theme datum property used to map affordance state to a Audio affordance value. Can store an asset or a serialized value.")]
	private AudioAffordanceThemeDatumProperty m_AffordanceThemeDatum; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Audio Source where the audio clip will be played.")]
	private AudioSource m_AudioSource; //Field offset: 0x30
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x38
	private byte m_LastAffordanceStateIndex; //Field offset: 0x40

	public BaseAffordanceStateProvider affordanceStateProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioAffordanceThemeDatumProperty affordanceThemeDatum
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioSource audioSource
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioAffordanceReceiver() { }

	protected void Awake() { }

	public BaseAffordanceStateProvider get_affordanceStateProvider() { }

	public AudioAffordanceThemeDatumProperty get_affordanceThemeDatum() { }

	public AudioSource get_audioSource() { }

	private void LogIfMissingAffordanceStates(AudioAffordanceTheme theme) { }

	private void OnAffordanceStateUpdated(AffordanceStateData affordanceStateData) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected void OnValidate() { }

	private void PlayAudioClip(AudioClip clipToPlay) { }

	public void set_affordanceStateProvider(BaseAffordanceStateProvider value) { }

	public void set_affordanceThemeDatum(AudioAffordanceThemeDatumProperty value) { }

	public void set_audioSource(AudioSource value) { }

}

