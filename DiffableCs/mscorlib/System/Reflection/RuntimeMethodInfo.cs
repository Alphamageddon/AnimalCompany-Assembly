namespace System.Reflection;

internal class RuntimeMethodInfo : MethodInfo, ISerializable
{
	internal IntPtr mhandle; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private Type reftype; //Field offset: 0x20

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 8
	}

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 8
	}

	public virtual CallingConventions CallingConvention
	{
		 get { } //Length: 44
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 200
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 44
	}

	public virtual bool IsGenericMethod
	{
		 get { } //Length: 4
	}

	public virtual bool IsGenericMethodDefinition
	{
		 get { } //Length: 4
	}

	public virtual bool IsSecurityCritical
	{
		 get { } //Length: 8
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 4
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 8
	}

	public virtual Module Module
	{
		 get { } //Length: 4
	}

	public virtual string Name
	{
		 get { } //Length: 20
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 8
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 132
	}

	public virtual ParameterInfo ReturnParameter
	{
		 get { } //Length: 4
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 44
	}

	internal RuntimeMethodInfo() { }

	internal static void ConvertValues(Binder binder, Object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	internal virtual string FormatNameAndSig(bool serialization) { }

	public virtual MethodAttributes get_Attributes() { }

	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	internal BindingFlags get_BindingFlags() { }

	public virtual CallingConventions get_CallingConvention() { }

	public virtual bool get_ContainsGenericParameters() { }

	private static int get_core_clr_security_level() { }

	public virtual Type get_DeclaringType() { }

	public virtual bool get_IsGenericMethod() { }

	public virtual bool get_IsGenericMethodDefinition() { }

	public virtual bool get_IsSecurityCritical() { }

	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	public virtual int get_MetadataToken() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual Module get_Module() { }

	internal static string get_name(MethodBase method) { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public virtual ParameterInfo get_ReturnParameter() { }

	public virtual Type get_ReturnType() { }

	internal MethodInfo GetBaseMethod() { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	private CustomAttributeData GetDllImportAttributeData() { }

	public virtual Type[] GetGenericArguments() { }

	public virtual MethodInfo GetGenericMethodDefinition() { }

	private MethodInfo GetGenericMethodDefinition_impl() { }

	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual ParameterInfo[] GetParameters() { }

	internal virtual int GetParametersCount() { }

	internal virtual ParameterInfo[] GetParametersInternal() { }

	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	internal Object[] GetPseudoCustomAttributes() { }

	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	internal RuntimeModule GetRuntimeModule() { }

	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	internal string SerializationToString() { }

	public virtual string ToString() { }

}

