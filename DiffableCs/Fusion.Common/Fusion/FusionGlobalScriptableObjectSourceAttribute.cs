namespace Fusion;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public abstract class FusionGlobalScriptableObjectSourceAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <ObjectType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Order>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <AllowEditMode>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <AllowFallback>k__BackingField; //Field offset: 0x1D

	public bool AllowEditMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool AllowFallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Type ObjectType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Order
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public FusionGlobalScriptableObjectSourceAttribute(Type objectType) { }

	[CompilerGenerated]
	public bool get_AllowEditMode() { }

	[CompilerGenerated]
	public bool get_AllowFallback() { }

	[CompilerGenerated]
	public Type get_ObjectType() { }

	[CompilerGenerated]
	public int get_Order() { }

	public abstract FusionGlobalScriptableObjectLoadResult Load(Type type) { }

	[CompilerGenerated]
	public void set_AllowEditMode(bool value) { }

	[CompilerGenerated]
	public void set_AllowFallback(bool value) { }

	[CompilerGenerated]
	public void set_Order(int value) { }

}

