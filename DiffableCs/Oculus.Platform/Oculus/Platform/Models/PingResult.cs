namespace Oculus.Platform.Models;

public class PingResult
{
	[CompilerGenerated]
	private ulong <ID>k__BackingField; //Field offset: 0x10
	private Nullable<UInt64> pingTimeUsec; //Field offset: 0x18

	public private ulong ID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool IsTimeout
	{
		 get { } //Length: 68
	}

	public ulong PingTimeUsec
	{
		 get { } //Length: 108
	}

	public PingResult(ulong id, Nullable<UInt64> pingTimeUsec) { }

	[CompilerGenerated]
	public ulong get_ID() { }

	public bool get_IsTimeout() { }

	public ulong get_PingTimeUsec() { }

	[CompilerGenerated]
	private void set_ID(ulong value) { }

}

