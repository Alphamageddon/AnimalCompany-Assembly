namespace Oculus.Platform;

public class NetSyncOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public NetSyncOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(NetSyncOptions options) { }

	public void SetVoipGroup(string value) { }

	public void SetVoipStreamDefault(NetSyncVoipStreamMode value) { }

	public void SetZoneId(string value) { }

}

