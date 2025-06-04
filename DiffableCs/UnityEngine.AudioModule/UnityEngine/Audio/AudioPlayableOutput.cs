namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public override PlayableOutputHandle GetHandle() { }

}

