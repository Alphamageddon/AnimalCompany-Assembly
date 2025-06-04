namespace Photon.Voice;

public abstract class BufferReaderPushAdapterBase : IServiceable
{
	protected IDataReader<T> reader; //Field offset: 0x0

	public BufferReaderPushAdapterBase`1(IDataReader<T> reader) { }

	public void Dispose() { }

	public abstract void Service(LocalVoice localVoice) { }

}

