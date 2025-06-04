namespace SpatialSys.ObservableState;

[Nullable(0)]
[NullableContext(1)]
public static class TypeScriptInterfaceGenerator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<CustomAttributeData, Boolean> <>9__12_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<CustomAttributeData, Boolean> <>9__14_0; //Field offset: 0x10
		[Nullable(0)]
		public static Func<Type, String> <>9__17_0; //Field offset: 0x18
		[Nullable(0)]
		public static Func<ParameterInfo, String> <>9__23_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal string <GenerateClassInterface>b__23_0(ParameterInfo param) { }

		[NullableContext(0)]
		internal bool <GenerateEnumInternal>b__14_0(CustomAttributeData x) { }

		[NullableContext(0)]
		internal bool <GenerateInternal>b__12_0(CustomAttributeData x) { }

		[NullableContext(0)]
		internal string <GenericTypeToTS>b__17_0(Type param) { }

	}

	private static readonly int NEWLINE_LENGTH; //Field offset: 0x0
	private const int SPACES_PER_TAB = 2; //Field offset: 0x0
	private static readonly Type _IStateObjectType; //Field offset: 0x8
	private static readonly Type _StatePrimitiveType; //Field offset: 0x10
	private static readonly Type _StatePrimitiveSetType; //Field offset: 0x18
	private static readonly Type _StatePrimitiveArrayType; //Field offset: 0x20
	private static readonly Type _StateObjectType; //Field offset: 0x28
	private static readonly Type _StateListType; //Field offset: 0x30
	private static readonly Type _StateDictionaryType; //Field offset: 0x38
	private static readonly HashSet<Type> _ignoredAttributeTypes; //Field offset: 0x40

	private static TypeScriptInterfaceGenerator() { }

	public static void Generate(string fileIntro, string outputDirectory, string typesFilename, string keyPathsFilename, string emptyStateFilename, Type[] types, IStateObject emptyState) { }

	private static void GenerateClassInterface(StringBuilder builder, Type type, Type exportAttribute) { }

	public static void GenerateClassInterfaces(string fileIntro, string outputPath, Type[] types, Type exportAttribute) { }

	private static void GenerateCustomPrimitiveTypes(ref StringBuilder builder) { }

	private static void GenerateEmptyState(ref StringBuilder builder, string typesFilename, List<String> generatedKeyPaths, IStateObject emptyState) { }

	private static void GenerateEnumInternal(ref StringBuilder builder, Type root) { }

	private static void GenerateInternal(ref StringBuilder builder, Type type, string keyPath, bool isStateDictionary, HashSet<String> generatedInterfaceNames, HashSet<String> generatedEnumNames, List<String> generatedKeyPaths) { }

	private static void GenerateKeyPaths(ref StringBuilder builder, string typeName, List<String> generatedKeyPaths) { }

	private static void GenerateUnityTypes(ref StringBuilder builder) { }

	private static string GenericTypeToTS(Type type, out Type genericArgument0, out Type genericArgument1) { }

	[NullableContext(2)]
	private static bool IsStateObject(Type type) { }

	private static string PrimitiveTypeToTS(Type type, bool usedForKey = false) { }

	private static JSONNode ReplaceNullsWithEmptyString(JSONNode node) { }

	private static string TypeNameFromNonPolymer(Type type) { }

	private static string TypeNameToTS(string cSharpName) { }

}

