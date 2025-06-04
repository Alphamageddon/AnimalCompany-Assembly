namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		 get { } //Length: 60
	}

	public bool loop
	{
		 set { } //Length: 68
	}

	public float maxDistance
	{
		 set { } //Length: 76
	}

	public float minDistance
	{
		 set { } //Length: 76
	}

	public bool mute
	{
		 set { } //Length: 68
	}

	public AudioMixerGroup outputAudioMixerGroup
	{
		 set { } //Length: 68
	}

	public float pitch
	{
		 set { } //Length: 76
	}

	public bool playOnAwake
	{
		 set { } //Length: 68
	}

	public float reverbZoneMix
	{
		 set { } //Length: 76
	}

	public AudioRolloffMode rolloffMode
	{
		 set { } //Length: 68
	}

	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend
	{
		 set { } //Length: 76
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		 set { } //Length: 76
	}

	[NativeProperty("SamplePosition")]
	public int timeSamples
	{
		[NativeMethod(IsThreadSafe = True)]
		 get { } //Length: 60
	}

	public float volume
	{
		 get { } //Length: 60
		 set { } //Length: 76
	}

	public AudioClip get_clip() { }

	[NativeName("IsPlayingScripting")]
	public bool get_isPlaying() { }

	[NativeMethod(IsThreadSafe = True)]
	public int get_timeSamples() { }

	public float get_volume() { }

	public void Pause() { }

	[ExcludeFromDocs]
	public void Play() { }

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	public void set_clip(AudioClip value) { }

	public void set_loop(bool value) { }

	public void set_maxDistance(float value) { }

	public void set_minDistance(float value) { }

	public void set_mute(bool value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	public void set_pitch(float value) { }

	public void set_playOnAwake(bool value) { }

	public void set_reverbZoneMix(float value) { }

	public void set_rolloffMode(AudioRolloffMode value) { }

	public void set_spatialBlend(float value) { }

	public void set_time(float value) { }

	public void set_volume(float value) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	private void Stop(bool stopOneShots) { }

	public void Stop() { }

}

