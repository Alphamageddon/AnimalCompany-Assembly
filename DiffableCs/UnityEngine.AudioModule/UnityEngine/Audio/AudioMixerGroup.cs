namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : object
{

	[NativeProperty]
	public AudioMixer audioMixer
	{
		 get { } //Length: 60
	}

	internal AudioMixerGroup() { }

	public AudioMixer get_audioMixer() { }

}

