namespace Oculus.Platform;

public class WindowsPlatform
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class UnityLogDelegate : MulticastDelegate
	{

		public UnityLogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr tag, IntPtr msg, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr tag, IntPtr msg) { }

	}


	public WindowsPlatform() { }

	public Request<PlatformInitialize> AsyncInitialize(string appId) { }

	private void CPPLogCallback(IntPtr tag, IntPtr message) { }

	private IntPtr getCallbackPointer() { }

	public bool Initialize(string appId) { }

}

