namespace UnityEngine.Animations;

internal struct ProcessAnimationJobStruct
{
	internal sealed class ExecuteJobFunction : MulticastDelegate
	{

		public ExecuteJobFunction(object object, IntPtr method) { }

		public override void Invoke(ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex) { }

	}

	private static IntPtr jobReflectionData; //Field offset: 0x0

	public static void Execute(ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex) { }

	public static IntPtr GetJobReflectionData() { }

}

