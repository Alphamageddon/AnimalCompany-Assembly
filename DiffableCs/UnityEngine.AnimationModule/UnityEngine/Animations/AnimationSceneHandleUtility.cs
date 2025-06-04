namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
public static class AnimationSceneHandleUtility
{

	public static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<Single> buffer) { }

	[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadSceneFloatsInternal", IsFreeFunction = True, HasExplicitThis = False, IsThreadSafe = True)]
	private static void ReadSceneFloatsInternal(ref AnimationStream stream, Void* propertySceneHandles, Void* floatBuffer, int count) { }

	internal static int ValidateAndGetArrayCount(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) { }

}

