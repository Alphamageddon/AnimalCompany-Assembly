namespace Oculus.Platform;

public class UserOptions
{
	private IntPtr Handle; //Field offset: 0x10

	public UserOptions() { }

	public void AddServiceProvider(ServiceProvider value) { }

	public void ClearServiceProviders() { }

	protected virtual void Finalize() { }

	public static IntPtr op_Explicit(UserOptions options) { }

	public void SetMaxUsers(uint value) { }

	public void SetTimeWindow(TimeWindow value) { }

}

