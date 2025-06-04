namespace Nakama.Ninja.WebSockets;

public class BufferPool : IBufferPool
{
	internal class PublicBufferMemoryStream : MemoryStream
	{
		private readonly BufferPool _bufferPoolInternal; //Field offset: 0x50
		private Byte[] _buffer; //Field offset: 0x58
		private MemoryStream _ms; //Field offset: 0x60

		public virtual bool CanRead
		{
			 get { } //Length: 32
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 32
		}

		public virtual bool CanTimeout
		{
			 get { } //Length: 32
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 32
		}

		public virtual int Capacity
		{
			 get { } //Length: 36
			 set { } //Length: 36
		}

		public virtual long Length
		{
			 get { } //Length: 8
		}

		public virtual long Position
		{
			 get { } //Length: 32
			 set { } //Length: 36
		}

		public virtual int ReadTimeout
		{
			 get { } //Length: 36
			 set { } //Length: 36
		}

		public virtual int WriteTimeout
		{
			 get { } //Length: 36
			 set { } //Length: 36
		}

		public PublicBufferMemoryStream(Byte[] buffer, BufferPool bufferPool) { }

		public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual void Close() { }

		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

		public virtual int EndRead(IAsyncResult asyncResult) { }

		public virtual void EndWrite(IAsyncResult asyncResult) { }

		private void EnlargeBufferIfRequired(int count) { }

		public virtual void Flush() { }

		public virtual Task FlushAsync(CancellationToken cancellationToken) { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanTimeout() { }

		public virtual bool get_CanWrite() { }

		public virtual int get_Capacity() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int get_ReadTimeout() { }

		public virtual int get_WriteTimeout() { }

		public virtual Byte[] GetBuffer() { }

		public virtual object InitializeLifetimeService() { }

		public virtual int Read(Byte[] buffer, int offset, int count) { }

		public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public virtual int ReadByte() { }

		public virtual long Seek(long offset, SeekOrigin loc) { }

		public virtual void set_Capacity(int value) { }

		public virtual void set_Position(long value) { }

		public virtual void set_ReadTimeout(int value) { }

		public virtual void set_WriteTimeout(int value) { }

		public virtual void SetLength(long value) { }

		public virtual Byte[] ToArray() { }

		public virtual bool TryGetBuffer(out ArraySegment<Byte>& buffer) { }

		public virtual void Write(Byte[] buffer, int offset, int count) { }

		public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		public virtual void WriteByte(byte value) { }

		public virtual void WriteTo(Stream stream) { }

	}

	private const int DEFAULT_BUFFER_SIZE = 16384; //Field offset: 0x0
	private readonly ConcurrentStack<Byte[]> _bufferPoolStack; //Field offset: 0x10
	private readonly int _bufferSize; //Field offset: 0x18

	public BufferPool() { }

	public BufferPool(int bufferSize) { }

	public override MemoryStream GetBuffer() { }

	protected void ReturnBuffer(Byte[] buffer) { }

}

