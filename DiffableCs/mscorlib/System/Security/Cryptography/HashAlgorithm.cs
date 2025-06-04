namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	private bool _disposed; //Field offset: 0x10
	protected int HashSizeValue; //Field offset: 0x14
	protected private Byte[] HashValue; //Field offset: 0x18
	protected int State; //Field offset: 0x20

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 8
	}

	public override Byte[] Hash
	{
		 get { } //Length: 236
	}

	public override int HashSize
	{
		 get { } //Length: 8
	}

	public override int InputBlockSize
	{
		 get { } //Length: 8
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 8
	}

	protected HashAlgorithm() { }

	private Byte[] CaptureHashCodeAndReinitialize() { }

	public void Clear() { }

	public Byte[] ComputeHash(Byte[] buffer) { }

	public Byte[] ComputeHash(Byte[] buffer, int offset, int count) { }

	public Byte[] ComputeHash(Stream inputStream) { }

	public static HashAlgorithm Create(string hashName) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override Byte[] get_Hash() { }

	public override int get_HashSize() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	protected abstract void HashCore(Byte[] array, int ibStart, int cbSize) { }

	protected abstract Byte[] HashFinal() { }

	public abstract void Initialize() { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	private void ValidateTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

