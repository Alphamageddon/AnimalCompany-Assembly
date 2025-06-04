namespace Oculus.Platform;

public sealed class StandalonePlatform
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class UnityLogDelegate : MulticastDelegate
	{

		public UnityLogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr tag, IntPtr msg, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr tag, IntPtr msg) { }

	}


	public StandalonePlatform() { }

	public Request<PlatformInitialize> AsyncInitialize(ulong appID, string accessToken) { }

	public Request<PlatformInitialize> AsyncInitializeWithAccessTokenAndOptions(string appId, string accessToken, Dictionary<InitConfigOptions, Boolean> initConfigOptions) { }

	public Request<PlatformInitialize> InitializeInEditor() { }

}

