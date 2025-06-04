namespace Fusion;

public abstract class FusionEditorLog
{
	private static string s_color; //Field offset: 0x0

	private static FusionEditorLog() { }

	protected FusionEditorLog() { }

	[AssertionMethod]
	[Conditional("UNITY_ASSERTIONS")]
	[ContractAnnotation("condition: false => halt")]
	public static void Assert(bool condition, string message) { }

	[AssertionMethod]
	[Conditional("UNITY_ASSERTIONS")]
	[ContractAnnotation("condition: false => halt")]
	public static void Assert(bool condition) { }

	[Conditional("UNITY_EDITOR")]
	public static void Error(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorConfig(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorImport(string assetPath, string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorImport(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorInspector(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorInstaller(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void ErrorMppm(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void Log(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogConfig(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogImport(string assetPath, string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogImport(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogInspector(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogInstaller(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogMppm(string msg) { }

	public static void SetPrefixColor(Color color) { }

	public static void SetPrefixColor(Color32 c) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void Trace(string msg) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void TraceConfig(string msg) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void TraceImport(string assetPath, string msg) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void TraceImport(string msg) { }

	[Conditional("FUSION_EDITOR_INSPECTOR_TRACE")]
	public static void TraceInspector(string msg) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void TraceInstaller(string msg) { }

	[Conditional("FUSION_EDITOR_TRACE")]
	public static void TraceMppm(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void Warn(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnConfig(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnImport(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnImport(string assetPath, string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnInspector(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnInstaller(string msg) { }

	[Conditional("UNITY_EDITOR")]
	public static void WarnMppm(string msg) { }

}

