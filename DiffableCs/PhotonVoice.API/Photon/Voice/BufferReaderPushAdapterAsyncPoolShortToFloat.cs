namespace Photon.Voice;

public class BufferReaderPushAdapterAsyncPoolShortToFloat : BufferReaderPushAdapterBase<Int16>
{
	private Int16[] buffer; //Field offset: 0x18

	public BufferReaderPushAdapterAsyncPoolShortToFloat(IDataReader<Int16> reader) { }

	public virtual void Service(LocalVoice localVoice) { }

}

