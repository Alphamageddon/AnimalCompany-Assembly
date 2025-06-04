namespace ExitGames.Client.Photon;

public class NetworkSimulationSet
{
	private bool isSimulationEnabled; //Field offset: 0x10
	private int outgoingLag; //Field offset: 0x14
	private int outgoingJitter; //Field offset: 0x18
	private int outgoingLossPercentage; //Field offset: 0x1C
	private int incomingLag; //Field offset: 0x20
	private int incomingJitter; //Field offset: 0x24
	private int incomingLossPercentage; //Field offset: 0x28
	internal PeerBase peerBase; //Field offset: 0x30
	private Thread netSimThread; //Field offset: 0x38
	protected private readonly ManualResetEvent NetSimManualResetEvent; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LostPackagesOut>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LostPackagesIn>k__BackingField; //Field offset: 0x4C

	public int IncomingJitter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int IncomingLag
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int IncomingLossPercentage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected private bool IsSimulationEnabled
	{
		private get { } //Length: 8
		private set { } //Length: 1820
	}

	public internal int LostPackagesIn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public internal int LostPackagesOut
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public int OutgoingJitter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int OutgoingLag
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public int OutgoingLossPercentage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public NetworkSimulationSet() { }

	public int get_IncomingJitter() { }

	public int get_IncomingLag() { }

	public int get_IncomingLossPercentage() { }

	protected private bool get_IsSimulationEnabled() { }

	[CompilerGenerated]
	public int get_LostPackagesIn() { }

	[CompilerGenerated]
	public int get_LostPackagesOut() { }

	public int get_OutgoingJitter() { }

	public int get_OutgoingLag() { }

	public int get_OutgoingLossPercentage() { }

	public void set_IncomingJitter(int value) { }

	public void set_IncomingLag(int value) { }

	public void set_IncomingLossPercentage(int value) { }

	protected private void set_IsSimulationEnabled(bool value) { }

	[CompilerGenerated]
	internal void set_LostPackagesIn(int value) { }

	[CompilerGenerated]
	internal void set_LostPackagesOut(int value) { }

	public void set_OutgoingJitter(int value) { }

	public void set_OutgoingLag(int value) { }

	public void set_OutgoingLossPercentage(int value) { }

	public virtual string ToString() { }

}

