namespace Fusion;

public static class JsonUtilityExtensions
{
	[CompilerGenerated]
	private struct <>c__DisplayClass8_0
	{
		public string json; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass9_0
	{
		public string json; //Field offset: 0x0

	}

	internal sealed class InstanceIDHandlerDelegate : MulticastDelegate
	{

		public InstanceIDHandlerDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object context, int value, AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke(object context, int value) { }

	}

	private class TypeNameWrapper
	{
		public string __TypeName; //Field offset: 0x10

		public TypeNameWrapper() { }

	}

	internal sealed class TypeResolverDelegate : MulticastDelegate
	{

		public TypeResolverDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string typeName, AsyncCallback callback, object object) { }

		public override Type EndInvoke(IAsyncResult result) { }

		public override Type Invoke(string typeName) { }

	}

	internal sealed class TypeSerializerDelegate : MulticastDelegate
	{

		public TypeSerializerDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Type type, AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke(Type type) { }

	}

	private const string TypePropertyName = "$type"; //Field offset: 0x0

	[CompilerGenerated]
	internal static int <FromJsonWithTypeAnnotation>g__SkipWhiteOrThrow|8_0(int i, ref <>c__DisplayClass8_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static int <FromJsonWithTypeAnnotationInternal>g__SkipWhiteOrThrow|9_0(int i, ref <>c__DisplayClass9_0 unnamed_param_1) { }

	public static string EnquoteIntegers(string json, int minDigits = 8) { }

	internal static int FindObjectEnd(string json, int start = 0) { }

	private static int FindScopeEnd(string json, int start, char cstart = {, char cend = }) { }

	public static T FromJsonWithTypeAnnotation(string json, TypeResolverDelegate typeResolver = null) { }

	public static object FromJsonWithTypeAnnotation(string json, TypeResolverDelegate typeResolver = null) { }

	private static object FromJsonWithTypeAnnotationInternal(string json, TypeResolverDelegate typeResolver = null, IList targetList = null) { }

	private static object FromJsonWithTypeAnnotationToObject(ref int i, string json, TypeResolverDelegate typeResolver) { }

	private static void ToJsonInternal(object obj, TextWriter writer, Nullable<Int32> integerEnquoteMinDigits = null, TypeSerializerDelegate typeResolver = null, InstanceIDHandlerDelegate instanceIDHandler = null) { }

	public static string ToJsonWithTypeAnnotation(object obj, InstanceIDHandlerDelegate instanceIDHandler = null) { }

	public static void ToJsonWithTypeAnnotation(object obj, TextWriter writer, Nullable<Int32> integerEnquoteMinDigits = null, TypeSerializerDelegate typeSerializer = null, InstanceIDHandlerDelegate instanceIDHandler = null) { }

}

