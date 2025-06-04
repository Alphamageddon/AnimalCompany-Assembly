namespace Oculus.Platform;

public class InviteOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public InviteOptions() { }

	public void AddSuggestedUser(ulong userID) { }

	public void ClearSuggestedUsers() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(InviteOptions options) { }

}

