namespace Fusion;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
public class RpcAttribute : Attribute
{
	public const int MaxPayloadSize = 512; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Sources>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Targets>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <InvokeLocal>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private RpcChannel <Channel>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <TickAligned>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private RpcHostMode <HostMode>k__BackingField; //Field offset: 0x24

	public RpcChannel Channel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public RpcHostMode HostMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool InvokeLocal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public int Sources
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int Targets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool TickAligned
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public RpcAttribute() { }

	public RpcAttribute(RpcSources sources, RpcTargets targets) { }

	[CompilerGenerated]
	public RpcChannel get_Channel() { }

	[CompilerGenerated]
	public RpcHostMode get_HostMode() { }

	[CompilerGenerated]
	public bool get_InvokeLocal() { }

	[CompilerGenerated]
	public int get_Sources() { }

	[CompilerGenerated]
	public int get_Targets() { }

	[CompilerGenerated]
	public bool get_TickAligned() { }

	[CompilerGenerated]
	public void set_Channel(RpcChannel value) { }

	[CompilerGenerated]
	public void set_HostMode(RpcHostMode value) { }

	[CompilerGenerated]
	public void set_InvokeLocal(bool value) { }

	[CompilerGenerated]
	public void set_TickAligned(bool value) { }

}

