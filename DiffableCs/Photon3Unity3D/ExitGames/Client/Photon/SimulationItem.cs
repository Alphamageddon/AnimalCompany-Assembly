namespace ExitGames.Client.Photon;

internal class SimulationItem
{
	internal readonly Stopwatch stopw; //Field offset: 0x10
	public int TimeToExecute; //Field offset: 0x18
	public Byte[] DelayedData; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Delay>k__BackingField; //Field offset: 0x28

	public internal int Delay
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	public SimulationItem() { }

	[CompilerGenerated]
	public int get_Delay() { }

	[CompilerGenerated]
	internal void set_Delay(int value) { }

}

