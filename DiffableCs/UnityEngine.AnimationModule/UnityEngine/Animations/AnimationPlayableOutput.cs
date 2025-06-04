namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public static AnimationPlayableOutput Null
	{
		 get { } //Length: 124
	}

	internal AnimationPlayableOutput(PlayableOutputHandle handle) { }

	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	public static AnimationPlayableOutput get_Null() { }

	public override PlayableOutputHandle GetHandle() { }

	[NativeThrows]
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }

	public void SetTarget(Animator value) { }

}

