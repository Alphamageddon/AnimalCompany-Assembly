namespace Fusion;

public class FusionUnityLogger : ILogger
{
	private StringBuilder _builder; //Field offset: 0x10
	private Thread _mainThread; //Field offset: 0x18
	public string NameUnavailableObjectDestroyedLabel; //Field offset: 0x20
	public string NameUnavailableInWorkerThreadLabel; //Field offset: 0x28
	public bool UseGlobalPrefix; //Field offset: 0x30
	public bool UseColorTags; //Field offset: 0x31
	public bool AddHashCodePrefix; //Field offset: 0x32
	public string GlobalPrefixColor; //Field offset: 0x38
	public Color32 MinRandomColor; //Field offset: 0x40
	public Color32 MaxRandomColor; //Field offset: 0x44
	public Color ServerColor; //Field offset: 0x48

	private bool IsInMainThread
	{
		private get { } //Length: 32
	}

	public FusionUnityLogger(Thread mainThread) { }

	private void AppendNameThreadSafe(StringBuilder builder, object obj) { }

	private static int Color32ToRGB24(Color32 c) { }

	private static string Color32ToRGBString(Color32 c) { }

	private override void Fusion.ILogger.Log(LogType logType, object message, in LogContext logContext) { }

	private override void Fusion.ILogger.LogException(Exception ex, in LogContext logContext) { }

	private bool get_IsInMainThread() { }

	private int GetColorSeed(string name) { }

	private int GetRandomColor(int seed) { }

	private static int GetRandomColor(int seed, Color32 min, Color32 max, Color32 svr) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void Initialize() { }

	public void Log(LogType logType, object message, in LogContext logContext) { }

	public void LogException(Exception ex, in LogContext logContext) { }

	private bool TryAppendNetworkObjectPrefix(StringBuilder builder, NetworkObject networkObject) { }

	private bool TryAppendRunnerPrefix(StringBuilder builder, NetworkRunner runner) { }

	private bool TryAppendSimulationBehaviourPrefix(StringBuilder builder, SimulationBehaviour simulationBehaviour) { }

}

