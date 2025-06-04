namespace UnityEngine.InputSystem.Utilities;

internal struct TypeTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InternedString, String> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <get_names>b__2_0(InternedString x) { }

	}

	public Dictionary<InternedString, Type> table; //Field offset: 0x0

	public IEnumerable<InternedString> internedNames
	{
		 get { } //Length: 80
	}

	public IEnumerable<String> names
	{
		 get { } //Length: 292
	}

	public void AddTypeRegistration(string name, Type type) { }

	public InternedString FindNameForType(Type type) { }

	public IEnumerable<InternedString> get_internedNames() { }

	public IEnumerable<String> get_names() { }

	public void Initialize() { }

	public Type LookupTypeRegistration(string name) { }

}

