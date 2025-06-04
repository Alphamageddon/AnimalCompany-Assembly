namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/AudioReverbZone.h")]
[RequireComponent(typeof(Transform))]
public sealed class AudioReverbZone : Behaviour
{

	public AudioReverbPreset reverbPreset
	{
		 set { } //Length: 68
	}

	public void set_reverbPreset(AudioReverbPreset value) { }

}

