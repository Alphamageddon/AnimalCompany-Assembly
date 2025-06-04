namespace Unity.XR.CoreUtils;

[Extension]
public static class TypeExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Type type; //Field offset: 0x10
		public Func<Type, Boolean> predicate; //Field offset: 0x18
		public List<Type> list; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <GetAssignableTypes>b__0(Type t) { }

	}

	private static readonly List<FieldInfo> k_Fields; //Field offset: 0x0
	private static readonly List<String> k_TypeNames; //Field offset: 0x8

	private static TypeExtensions() { }

	[Extension]
	public static void GetAssignableTypes(Type type, List<Type> list, Func<Type, Boolean> predicate = null) { }

	[Extension]
	public static TAttribute GetAttribute(Type type, bool inherit = false) { }

	[Extension]
	public static void GetExtensionsOfClass(Type type, List<Type> list) { }

	[Extension]
	public static FieldInfo GetFieldInTypeOrBaseType(Type type, string fieldName) { }

	[Extension]
	public static FieldInfo GetFieldRecursively(Type type, string name, BindingFlags bindingAttr) { }

	[Extension]
	public static void GetFieldsRecursively(Type type, List<FieldInfo> fields, BindingFlags bindingAttr = 54) { }

	[Extension]
	public static string GetFullNameWithGenericArguments(Type type) { }

	[Extension]
	private static string GetFullNameWithGenericArgumentsInternal(Type type) { }

	[Extension]
	public static void GetGenericInterfaces(Type type, Type genericInterface, List<Type> interfaces) { }

	[Extension]
	public static void GetImplementationsOfInterface(Type type, List<Type> list) { }

	[Extension]
	public static void GetInterfaceFieldsFromClasses(IEnumerable<Type> classes, List<FieldInfo> fields, List<Type> interfaceTypes, BindingFlags bindingAttr) { }

	[Extension]
	public static MethodInfo GetMethodRecursively(Type type, string name, BindingFlags bindingAttr) { }

	[Extension]
	public static string GetNameWithFullGenericArguments(Type type) { }

	[Extension]
	public static string GetNameWithGenericArguments(Type type) { }

	[Extension]
	public static void GetPropertiesRecursively(Type type, List<PropertyInfo> fields, BindingFlags bindingAttr = 54) { }

	[Extension]
	public static PropertyInfo GetPropertyRecursively(Type type, string name, BindingFlags bindingAttr) { }

	[Extension]
	public static bool IsAssignableFromOrSubclassOf(Type checkType, Type baseType) { }

	[Extension]
	public static void IsDefinedGetInheritedTypes(Type type, List<Type> types) { }

}

