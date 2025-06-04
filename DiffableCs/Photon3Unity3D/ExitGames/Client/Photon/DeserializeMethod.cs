namespace ExitGames.Client.Photon;

public sealed class DeserializeMethod : MulticastDelegate
{

	public DeserializeMethod(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Byte[] serializedCustomObject, AsyncCallback callback, object object) { }

	public override object EndInvoke(IAsyncResult result) { }

	public override object Invoke(Byte[] serializedCustomObject) { }

}

