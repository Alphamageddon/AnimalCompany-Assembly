namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(AnimationClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

