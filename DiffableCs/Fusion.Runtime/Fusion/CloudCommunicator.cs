namespace Fusion;

internal class CloudCommunicator : CommunicatorBase, IDisposable
{
	[CompilerGenerated]
	private FusionRelayClient <Client>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <WasExtracted>k__BackingField; //Field offset: 0x40
	private readonly Byte[] _buffer; //Field offset: 0x48

	public private FusionRelayClient Client
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual int CommunicatorID
	{
		 get { } //Length: 48
	}

	public bool WasExtracted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public CloudCommunicator(FusionAppSettings clientConfig) { }

	protected virtual void ConvertData(object data, out Byte[] dataBuffer, out int maxLength) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public FusionRelayClient get_Client() { }

	public virtual int get_CommunicatorID() { }

	[CompilerGenerated]
	public bool get_WasExtracted() { }

	public void Reset() { }

	public virtual bool SendPackage(byte code, int targetActor, bool reliable, Byte* buffer, int bufferLength) { }

	public virtual void Service() { }

	[CompilerGenerated]
	private void set_Client(FusionRelayClient value) { }

	[CompilerGenerated]
	public void set_WasExtracted(bool value) { }

}

