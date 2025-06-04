namespace UnityEngine.Experimental.Animations;

[Extension]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Animation/AnimatorDefines.h")]
[StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType::DoubleColon (2))]
public static class AnimationPlayableOutputExtensions
{

	[NativeThrows]
	private static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource) { }

	private static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource) { }

	[NativeThrows]
	private static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder) { }

	private static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder) { }

	[Extension]
	public static void SetAnimationStreamSource(AnimationPlayableOutput output, AnimationStreamSource streamSource) { }

	[Extension]
	public static void SetSortingOrder(AnimationPlayableOutput output, ushort sortingOrder) { }

}

