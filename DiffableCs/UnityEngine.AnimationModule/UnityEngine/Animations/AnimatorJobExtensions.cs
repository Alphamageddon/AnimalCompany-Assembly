namespace UnityEngine.Animations;

[Extension]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
[StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType::DoubleColon (2))]
public static class AnimatorJobExtensions
{

	[Extension]
	public static PropertyStreamHandle BindCustomStreamProperty(Animator animator, string property, CustomStreamPropertyType type) { }

	[Extension]
	public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property) { }

	[Extension]
	public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference) { }

	[Extension]
	public static TransformSceneHandle BindSceneTransform(Animator animator, Transform transform) { }

	[Extension]
	public static PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property) { }

	[Extension]
	public static PropertyStreamHandle BindStreamProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference) { }

	[Extension]
	public static TransformStreamHandle BindStreamTransform(Animator animator, Transform transform) { }

	private static void InternalBindCustomStreamProperty(Animator animator, string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle) { }

	private static void InternalBindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle) { }

	private static void InternalBindSceneTransform(Animator animator, Transform transform, out TransformSceneHandle transformSceneHandle) { }

	private static void InternalBindStreamProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle) { }

	private static void InternalBindStreamTransform(Animator animator, Transform transform, out TransformStreamHandle transformStreamHandle) { }

}

