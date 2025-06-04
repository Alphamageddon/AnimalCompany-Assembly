namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[UsedByNativeCode]
public struct PlayableGraph
{
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort) { }

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) { }

	public static PlayableGraph Create(string name) { }

	private static void Create_Injected(string name, out PlayableGraph ret) { }

	[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = True, ThrowsException = True)]
	public void Destroy() { }

	private static void Destroy_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = True, ThrowsException = True)]
	public void Evaluate(float deltaTime) { }

	private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) { }

	public bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	public void Play() { }

	private static void Play_Injected(ref PlayableGraph _unity_self) { }

	[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = True, ThrowsException = True)]
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	private static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value) { }

}

