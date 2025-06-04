namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableHandle Null
	{
		 get { } //Length: 88
	}

	private static PlayableHandle() { }

	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	internal bool CheckInputBounds(int inputIndex) { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableHandle other) { }

	public static PlayableHandle get_Null() { }

	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph() { }

	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	public virtual int GetHashCode() { }

	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetJobData", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal IntPtr GetJobData() { }

	private static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetJobType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetJobType() { }

	private static Type GetJobType_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputCount(int value) { }

	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	internal bool SetInputWeight(int inputIndex, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private void SetInputWeightFromIndex(int index, float weight) { }

	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

}

