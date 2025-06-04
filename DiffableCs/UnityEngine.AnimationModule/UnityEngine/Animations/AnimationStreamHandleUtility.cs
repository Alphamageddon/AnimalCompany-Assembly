namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
public static class AnimationStreamHandleUtility
{

	public static void ReadFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<Single> buffer) { }

	[NativeMethod(Name = "AnimationHandleUtilityBindings::ReadStreamFloatsInternal", IsFreeFunction = True, HasExplicitThis = False, IsThreadSafe = True)]
	private static void ReadStreamFloatsInternal(ref AnimationStream stream, Void* propertyStreamHandles, Void* floatBuffer, int count) { }

	public static void WriteFloats(AnimationStream stream, NativeArray<PropertyStreamHandle> handles, NativeArray<Single> buffer, bool useMask) { }

	[NativeMethod(Name = "AnimationHandleUtilityBindings::WriteStreamFloatsInternal", IsFreeFunction = True, HasExplicitThis = False, IsThreadSafe = True)]
	private static void WriteStreamFloatsInternal(ref AnimationStream stream, Void* propertyStreamHandles, Void* floatBuffer, int count, bool useMask) { }

}

