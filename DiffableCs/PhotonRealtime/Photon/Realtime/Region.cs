namespace Photon.Realtime;

public class Region
{
	[CompilerGenerated]
	private string <Code>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Cluster>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <HostAndPort>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Ping>k__BackingField; //Field offset: 0x28

	public private string Cluster
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string Code
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string HostAndPort
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int Ping
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool WasPinged
	{
		 get { } //Length: 20
	}

	public Region(string code, string address) { }

	public Region(string code, int ping) { }

	[CompilerGenerated]
	public string get_Cluster() { }

	[CompilerGenerated]
	public string get_Code() { }

	[CompilerGenerated]
	public string get_HostAndPort() { }

	[CompilerGenerated]
	public int get_Ping() { }

	public bool get_WasPinged() { }

	[CompilerGenerated]
	private void set_Cluster(string value) { }

	[CompilerGenerated]
	private void set_Code(string value) { }

	[CompilerGenerated]
	protected private void set_HostAndPort(string value) { }

	[CompilerGenerated]
	public void set_Ping(int value) { }

	private void SetCodeAndCluster(string codeAsString) { }

	public virtual string ToString() { }

	public string ToString(bool compact = false) { }

}

