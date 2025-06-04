namespace Oculus.Platform;

public class ApplicationOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public ApplicationOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(ApplicationOptions options) { }

	public void SetDeeplinkMessage(string value) { }

	public void SetDestinationApiName(string value) { }

	public void SetLobbySessionId(string value) { }

	public void SetMatchSessionId(string value) { }

	public void SetRoomId(ulong value) { }

}

