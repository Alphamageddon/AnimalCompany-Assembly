namespace ExitGames.Client.Photon.StructWrapping;

public class StructWrapperPools
{
	public static readonly StructWrapper<Byte>[] mappedByteWrappers; //Field offset: 0x0
	public static readonly StructWrapper<Boolean>[] mappedBoolWrappers; //Field offset: 0x8
	private readonly Dictionary<Type, StructWrapperPool> pools; //Field offset: 0x10
	private readonly List<IDisposable> used; //Field offset: 0x18

	private static StructWrapperPools() { }

	public StructWrapperPools() { }

	public StructWrapper<Byte> Acquire(byte value) { }

	public StructWrapper<Boolean> Acquire(bool value) { }

	public StructWrapper<T> Acquire(T value) { }

	public void Clear() { }

	private StructWrapperPool<T> GetPoolForType() { }

}

