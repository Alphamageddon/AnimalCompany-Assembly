namespace Unity.XR.CoreUtils;

public static class ReflectionUtils
{
	private static Assembly[] s_Assemblies; //Field offset: 0x0
	private static List<Type[]> s_TypesPerAssembly; //Field offset: 0x8
	private static List<Dictionary`2<String, Type>> s_AssemblyTypeMaps; //Field offset: 0x10

	public static Type FindType(Func<Type, Boolean> predicate) { }

	public static Type FindTypeByFullName(string fullName) { }

	public static Type FindTypeInAssemblyByFullName(string assemblyName, string typeName) { }

	public static void FindTypesBatch(List<Func`2<Type, Boolean>> predicates, List<Type> resultList) { }

	public static void FindTypesByFullNameBatch(List<String> typeNames, List<Type> resultList) { }

	public static void ForEachAssembly(Action<Assembly> callback) { }

	public static void ForEachType(Action<Type> callback) { }

	private static Assembly[] GetCachedAssemblies() { }

	private static List<Dictionary`2<String, Type>> GetCachedAssemblyTypeMaps() { }

	private static List<Type[]> GetCachedTypesPerAssembly() { }

	public static string NicifyVariableName(string name) { }

	public static void PreWarmTypeCache() { }

}

