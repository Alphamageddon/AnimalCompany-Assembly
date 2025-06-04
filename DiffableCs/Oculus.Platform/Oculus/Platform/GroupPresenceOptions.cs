namespace Oculus.Platform;

public class GroupPresenceOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public GroupPresenceOptions() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(GroupPresenceOptions options) { }

	public void SetDeeplinkMessageOverride(string value) { }

	public void SetDestinationApiName(string value) { }

	public void SetIsJoinable(bool value) { }

	public void SetLobbySessionId(string value) { }

	public void SetMatchSessionId(string value) { }

}

