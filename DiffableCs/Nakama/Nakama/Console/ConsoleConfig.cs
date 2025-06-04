namespace Nakama.Console;

internal class ConsoleConfig : IConsoleConfig
{
	[CompilerGenerated]
	private string <Config>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <ServerVersion>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<ConfigWarning> <_warnings>k__BackingField; //Field offset: 0x20

	[DataMember(Name = "warnings")]
	public List<ConfigWarning> _warnings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "config")]
	public override string Config
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "server_version")]
	public override string ServerVersion
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable<IConfigWarning> Warnings
	{
		 get { } //Length: 120
	}

	public ConsoleConfig() { }

	[CompilerGenerated]
	public List<ConfigWarning> get__warnings() { }

	[CompilerGenerated]
	public override string get_Config() { }

	[CompilerGenerated]
	public override string get_ServerVersion() { }

	public override IEnumerable<IConfigWarning> get_Warnings() { }

	[CompilerGenerated]
	public void set__warnings(List<ConfigWarning> value) { }

	[CompilerGenerated]
	public void set_Config(string value) { }

	[CompilerGenerated]
	public void set_ServerVersion(string value) { }

	public virtual string ToString() { }

}

