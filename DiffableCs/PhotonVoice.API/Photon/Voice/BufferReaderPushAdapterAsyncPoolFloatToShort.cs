namespace Photon.Voice;

public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<Single>
{
	private Single[] buffer; //Field offset: 0x18

	public BufferReaderPushAdapterAsyncPoolFloatToShort(IDataReader<Single> reader) { }

	public virtual void Service(LocalVoice localVoice) { }

}

