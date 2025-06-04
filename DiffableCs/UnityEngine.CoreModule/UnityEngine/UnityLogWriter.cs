namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter
{

	public UnityLogWriter() { }

	public static void Init() { }

	public virtual void Write(char value) { }

	public virtual void Write(string s) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	[ThreadAndSerializationSafe]
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	private static void WriteStringToUnityLogImpl(string s) { }

}

