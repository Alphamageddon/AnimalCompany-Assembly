namespace Fusion;

public static class Log
{
	private static class Lock
	{

	}

	private const string DefaultPrefix = ""; //Field offset: 0x0
	private static ILogger _logger; //Field offset: 0x0
	public static LogType LogLevel; //Field offset: 0x8

	public static bool Initialized
	{
		 get { } //Length: 96
	}

	private static Log() { }

	[Conditional("DEBUG")]
	internal static void Debug(ILogSourceProxy source, object msg) { }

	[Conditional("DEBUG")]
	internal static void Debug(T source, object msg) { }

	[Conditional("DEBUG")]
	public static void Debug(object msg) { }

	[Conditional("DEBUG")]
	internal static void DebugError(ILogSourceProxy source, object msg) { }

	[Conditional("DEBUG")]
	internal static void DebugError(T source, object msg) { }

	[Conditional("DEBUG")]
	public static void DebugError(object msg) { }

	[Conditional("DEBUG")]
	internal static void DebugWarn(ILogSourceProxy source, object msg) { }

	[Conditional("DEBUG")]
	internal static void DebugWarn(T source, object msg) { }

	[Conditional("DEBUG")]
	public static void DebugWarn(object msg) { }

	[Conditional("DEBUG")]
	internal static void Error(ILogSourceProxy sourceProxy, object msg) { }

	[Conditional("DEBUG")]
	internal static void Error(ILogSource source, object msg) { }

	[Conditional("DEBUG")]
	public static void Error(object msg) { }

	private static void ErrorInternal(object msg, string stream = null) { }

	private static void ErrorInternalValue(ILogSource source, object msg, string stream = null) { }

	[Conditional("DEBUG")]
	internal static void ErrorRealtime(object msg) { }

	public static void ErrorSceneManager(T source, object msg) { }

	public static void ErrorSceneManager(object msg) { }

	internal static void Exception(T loggable, Exception exn) { }

	public static void Exception(Exception exn) { }

	private static void ExceptionInternal(Exception exn, string stream = null) { }

	[Conditional("DEBUG")]
	internal static void ExceptionRealtime(Exception ex) { }

	public static bool get_Initialized() { }

	[Conditional("DEBUG")]
	internal static void Info(ILogSource source, object msg) { }

	[Conditional("DEBUG")]
	internal static void Info(ILogSourceProxy sourceProxy, object msg) { }

	[Conditional("DEBUG")]
	public static void Info(object msg) { }

	private static void InfoInternal(object msg, string stream = null) { }

	private static void InfoInternalValue(ILogSource source, object msg, string stream = null) { }

	[Conditional("DEBUG")]
	internal static void InfoRealtime(object msg) { }

	public static void Init(ILogger logger, LogType LogLevel = 3) { }

	public static void InitForConsole() { }

	public static void Reset() { }

	[Conditional("TRACE")]
	internal static void Trace(T source, object msg) { }

	[Conditional("TRACE")]
	public static void Trace(object msg) { }

	[Conditional("TRACE")]
	internal static void Trace(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTraffic(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTraffic(T source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	public static void TraceDummyTraffic(object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTrafficError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTrafficError(T source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	public static void TraceDummyTrafficError(object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTrafficWarn(T source, object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	public static void TraceDummyTrafficWarn(object msg) { }

	[Conditional("TRACE_DUMMY_TRAFFIC")]
	internal static void TraceDummyTrafficWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	public static void TraceEncryption(object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryption(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryption(T source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryptionError(T source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryptionError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	public static void TraceEncryptionError(object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryptionWarn(T source, object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	public static void TraceEncryptionWarn(object msg) { }

	[Conditional("TRACE_ENCRYPTION")]
	internal static void TraceEncryptionWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE")]
	internal static void TraceError(T source, object msg) { }

	[Conditional("TRACE")]
	internal static void TraceError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE")]
	public static void TraceError(object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigration(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	public static void TraceHostMigration(object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigration(T source, object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigrationError(T source, object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigrationError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	public static void TraceHostMigrationError(object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigrationWarn(T source, object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	public static void TraceHostMigrationWarn(object msg) { }

	[Conditional("TRACE_HOST_MIGRATION")]
	internal static void TraceHostMigrationWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	public static void TraceNetwork(object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetwork(T source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetwork(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	public static void TraceNetworkError(object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetworkError(T source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetworkError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetworkWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_NETWORK")]
	public static void TraceNetworkWarn(object msg) { }

	[Conditional("TRACE_NETWORK")]
	internal static void TraceNetworkWarn(T source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObject(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObject(T source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	public static void TraceObject(object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObjectError(T source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	public static void TraceObjectError(object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObjectError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObjectWarn(T source, object msg) { }

	[Conditional("TRACE_OBJECT")]
	public static void TraceObjectWarn(object msg) { }

	[Conditional("TRACE_OBJECT")]
	internal static void TraceObjectWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	public static void TracePrefab(object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefab(T source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefab(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefabError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	public static void TracePrefabError(object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefabError(T source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	public static void TracePrefabWarn(object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefabWarn(T source, object msg) { }

	[Conditional("TRACE_PREFAB")]
	internal static void TracePrefabWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfo(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	public static void TraceSceneInfo(object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfo(T source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfoError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfoError(T source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	public static void TraceSceneInfoError(object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfoWarn(T source, object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	public static void TraceSceneInfoWarn(object msg) { }

	[Conditional("TRACE_SCENE_INFO")]
	internal static void TraceSceneInfoWarn(ILogSourceProxy source, object msg) { }

	[Conditional("FUSION_TRACE_SCENE_MANAGER")]
	public static void TraceSceneManager(T source, object msg) { }

	[Conditional("FUSION_TRACE_SCENE_MANAGER")]
	public static void TraceSceneManager(object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessage(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessage(T source, object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	public static void TraceSimulationMessage(object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessageError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessageError(T source, object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	public static void TraceSimulationMessageError(object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	public static void TraceSimulationMessageWarn(object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessageWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_SIMULATION_MESSAGE")]
	internal static void TraceSimulationMessageWarn(T source, object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStun(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_STUN")]
	public static void TraceStun(object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStun(T source, object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStunError(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_STUN")]
	public static void TraceStunError(object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStunError(T source, object msg) { }

	[Conditional("TRACE_STUN")]
	public static void TraceStunWarn(object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStunWarn(ILogSourceProxy source, object msg) { }

	[Conditional("TRACE_STUN")]
	internal static void TraceStunWarn(T source, object msg) { }

	[Conditional("TRACE")]
	internal static void TraceWarn(T source, object msg) { }

	[Conditional("TRACE")]
	public static void TraceWarn(object msg) { }

	[Conditional("TRACE")]
	internal static void TraceWarn(ILogSourceProxy source, object msg) { }

	[Conditional("DEBUG")]
	public static void Warn(object msg) { }

	[Conditional("DEBUG")]
	internal static void Warn(ILogSource source, object msg) { }

	[Conditional("DEBUG")]
	internal static void Warn(ILogSourceProxy sourceProxy, object msg) { }

	private static void WarnInternal(object msg, string stream = null) { }

	private static void WarnInternalValue(ILogSource source, object msg, string stream = null) { }

	[Conditional("DEBUG")]
	internal static void WarnRealtime(object msg) { }

	public static void WarnSceneManager(T source, object msg) { }

	public static void WarnSceneManager(object msg) { }

}

