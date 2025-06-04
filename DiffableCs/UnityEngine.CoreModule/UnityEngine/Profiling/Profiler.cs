namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[UsedByNativeCode]
public sealed class Profiler
{

	[Conditional("ENABLE_PROFILER")]
	public static void BeginSample(string name) { }

	[NativeMethod(Name = "ProfilerBindings::BeginSample", IsFreeFunction = True, IsThreadSafe = True)]
	private static void BeginSampleImpl(string name, object targetObject) { }

	[Conditional("ENABLE_PROFILER")]
	[NativeMethod(Name = "ProfilerBindings::EndSample", IsFreeFunction = True, IsThreadSafe = True)]
	public static void EndSample() { }

	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
	public static long GetRuntimeMemorySizeLong(object o) { }

	private static void ValidateArguments(string name) { }

}

