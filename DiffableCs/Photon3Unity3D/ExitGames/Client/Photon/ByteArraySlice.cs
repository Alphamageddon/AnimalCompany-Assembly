namespace ExitGames.Client.Photon;

public class ByteArraySlice : IDisposable
{
	public Byte[] Buffer; //Field offset: 0x10
	public int Offset; //Field offset: 0x18
	public int Count; //Field offset: 0x1C
	private readonly ByteArraySlicePool returnPool; //Field offset: 0x20
	private readonly int stackIndex; //Field offset: 0x28

	internal ByteArraySlice(ByteArraySlicePool returnPool, int stackIndex) { }

	public ByteArraySlice(Byte[] buffer, int offset = 0, int count = 0) { }

	public ByteArraySlice() { }

	public override void Dispose() { }

	public bool Release() { }

	public void Reset() { }

}

