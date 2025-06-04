namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(TextureMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

