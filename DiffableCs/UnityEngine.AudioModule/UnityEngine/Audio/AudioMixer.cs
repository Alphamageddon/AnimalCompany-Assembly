namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
public class AudioMixer : object
{

	internal AudioMixer() { }

	[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	[NativeMethod]
	public bool SetFloat(string name, float value) { }

}

