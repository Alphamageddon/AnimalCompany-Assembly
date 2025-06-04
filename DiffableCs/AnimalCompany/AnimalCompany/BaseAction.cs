namespace AnimalCompany;

public abstract class BaseAction
{
	[CompilerGenerated]
	private bool <silent>k__BackingField; //Field offset: 0x10

	public override bool silent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	protected BaseAction() { }

	[CompilerGenerated]
	private string <ToString>b__6_0(FieldInfo p) { }

	public abstract void Execute(AppState state) { }

	[CompilerGenerated]
	public override bool get_silent() { }

	public static string GetTypeNameStripped(Type type) { }

	public static bool IsSecuritySensitiveField(MemberInfo member) { }

	[CompilerGenerated]
	public override void set_silent(bool value) { }

	public override BaseAction SetSilent(bool silent = true) { }

	public virtual string ToString() { }

}

