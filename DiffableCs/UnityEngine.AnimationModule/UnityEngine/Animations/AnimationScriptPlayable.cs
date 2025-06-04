namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
{
	private static readonly AnimationScriptPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationScriptPlayable() { }

	internal AnimationScriptPlayable(PlayableHandle handle) { }

	private void CheckJobTypeValidity() { }

	public static AnimationScriptPlayable Create(PlayableGraph graph, T jobData, int inputCount = 0) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) { }

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData) { }

	public override bool Equals(AnimationScriptPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationScriptPlayable playable) { }

	public override void SetJobData(T jobData) { }

}

