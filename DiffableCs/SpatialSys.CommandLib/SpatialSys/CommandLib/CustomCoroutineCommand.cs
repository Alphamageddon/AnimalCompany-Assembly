namespace SpatialSys.CommandLib;

public abstract class CustomCoroutineCommand : CoroutineCommand
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ToString>b__2_0(FieldInfo p) { }

	}


	protected CustomCoroutineCommand(string identifier = null) { }

	[CompilerGenerated]
	private string <ToString>b__2_1(FieldInfo p) { }

	public abstract IEnumerator<Command> ExecuteAsync() { }

	public static bool IsSecuritySensitiveField(MemberInfo member) { }

	public virtual string ToString() { }

}

