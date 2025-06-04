namespace Fusion;

public static class Assert
{

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, T0 arg0, T1 arg1) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, T0 arg0) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, string format, Object[] args) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, string error) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition) { }

	[AssertionMethod]
	[ContractAnnotation("condition:false=>halt")]
	public static void Always(bool condition, T0 arg0, T1 arg1, T2 arg2) { }

	public static void AlwaysFail(T error) { }

	public static void AlwaysFail(object error) { }

	public static void AlwaysFail(string error) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, T0 arg0, T1 arg1) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, T0 arg0) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, string format, Object[] args) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, string error) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:null=>halt")]
	public static void Check(Void* condition) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:null=>halt")]
	public static void Check(object condition) { }

	[AssertionMethod]
	[Conditional("DEBUG")]
	[ContractAnnotation("condition:false=>halt")]
	public static void Check(bool condition, T0 arg0, T1 arg1, T2 arg2) { }

	[Conditional("DEBUG")]
	public static void Fail(string format, Object[] args) { }

	[Conditional("DEBUG")]
	public static void Fail(string error) { }

	[Conditional("DEBUG")]
	public static void Fail() { }

}

