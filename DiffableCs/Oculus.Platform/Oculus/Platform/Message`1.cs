namespace Oculus.Platform;

public abstract class Message : Message
{
	internal sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Message<T> message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Message<T> message) { }

	}

	private T data; //Field offset: 0x0

	public T Data
	{
		 get { } //Length: 8
	}

	public Message`1(IntPtr c_message) { }

	public T get_Data() { }

	protected abstract T GetDataFromMessage(IntPtr c_message) { }

}

