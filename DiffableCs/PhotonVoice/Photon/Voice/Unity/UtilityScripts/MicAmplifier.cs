namespace Photon.Voice.Unity.UtilityScripts;

[RequireComponent(typeof(Recorder))]
public class MicAmplifier : VoiceComponent
{
	[SerializeField]
	private float amplificationFactor; //Field offset: 0x28
	private MicAmplifierFloat floatProcessor; //Field offset: 0x30
	private MicAmplifierShort shortProcessor; //Field offset: 0x38

	public float AmplificationFactor
	{
		 get { } //Length: 8
		 set { } //Length: 72
	}

	public MicAmplifier() { }

	public float get_AmplificationFactor() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void PhotonVoiceCreated(PhotonVoiceCreatedParams p) { }

	public void set_AmplificationFactor(float value) { }

}

