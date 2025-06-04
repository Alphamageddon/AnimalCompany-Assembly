namespace System.Net.Http;

public class StreamContent : HttpContent
{
	private readonly Stream content; //Field offset: 0x28
	private readonly int bufferSize; //Field offset: 0x30
	private readonly CancellationToken cancellationToken; //Field offset: 0x38
	private readonly long startPosition; //Field offset: 0x40
	private bool contentCopied; //Field offset: 0x48

	public StreamContent(Stream content) { }

	public StreamContent(Stream content, int bufferSize) { }

	internal StreamContent(Stream content, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	protected private virtual bool TryComputeLength(out long length) { }

}

