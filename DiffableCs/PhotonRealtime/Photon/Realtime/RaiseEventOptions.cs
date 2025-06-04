namespace Photon.Realtime;

public class RaiseEventOptions
{
	public static readonly RaiseEventOptions Default; //Field offset: 0x0
	public EventCaching CachingOption; //Field offset: 0x10
	public byte InterestGroup; //Field offset: 0x11
	public Int32[] TargetActors; //Field offset: 0x18
	public ReceiverGroup Receivers; //Field offset: 0x20
	[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
	public byte SequenceChannel; //Field offset: 0x21
	public WebFlags Flags; //Field offset: 0x28

	private static RaiseEventOptions() { }

	public RaiseEventOptions() { }

}

