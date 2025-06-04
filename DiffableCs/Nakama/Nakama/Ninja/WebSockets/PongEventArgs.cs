namespace Nakama.Ninja.WebSockets;

public class PongEventArgs : EventArgs
{
	[CompilerGenerated]
	private ArraySegment<Byte> <Payload>k__BackingField; //Field offset: 0x10

	public private ArraySegment<Byte> Payload
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public PongEventArgs(ArraySegment<Byte> payload) { }

	[CompilerGenerated]
	public ArraySegment<Byte> get_Payload() { }

	[CompilerGenerated]
	private void set_Payload(ArraySegment<Byte> value) { }

}

