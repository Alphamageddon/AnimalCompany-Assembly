namespace Oculus.Platform;

public class Request
{
	private Callback callback_; //Field offset: 0x10
	[CompilerGenerated]
	private ulong <RequestID>k__BackingField; //Field offset: 0x18

	public ulong RequestID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Request(ulong requestID) { }

	[CompilerGenerated]
	public ulong get_RequestID() { }

	public override void HandleMessage(Message msg) { }

	public Request OnComplete(Callback callback) { }

	public static void RunCallbacks(uint limit = 0) { }

	[CompilerGenerated]
	public void set_RequestID(ulong value) { }

}

