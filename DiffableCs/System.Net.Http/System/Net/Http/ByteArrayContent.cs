namespace System.Net.Http;

public class ByteArrayContent : HttpContent
{
	private readonly Byte[] content; //Field offset: 0x28
	private readonly int offset; //Field offset: 0x30
	private readonly int count; //Field offset: 0x34

	public ByteArrayContent(Byte[] content) { }

	protected virtual Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected private virtual bool TryComputeLength(out long length) { }

}

