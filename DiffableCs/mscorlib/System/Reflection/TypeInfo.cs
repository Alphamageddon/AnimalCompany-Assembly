namespace System.Reflection;

public abstract class TypeInfo : Type, IReflectableType
{
	private const BindingFlags DeclaredOnlyLookup = 62; //Field offset: 0x0

	public override IEnumerable<PropertyInfo> DeclaredProperties
	{
		 get { } //Length: 20
	}

	protected TypeInfo() { }

	public override IEnumerable<PropertyInfo> get_DeclaredProperties() { }

	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

