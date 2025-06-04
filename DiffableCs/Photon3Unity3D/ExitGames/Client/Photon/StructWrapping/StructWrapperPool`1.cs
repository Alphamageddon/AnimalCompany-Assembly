namespace ExitGames.Client.Photon.StructWrapping;

public class StructWrapperPool : StructWrapperPool
{
	public const int GROWBY = 4; //Field offset: 0x0
	public readonly Type tType; //Field offset: 0x0
	public readonly WrappedType wType; //Field offset: 0x0
	public Stack<StructWrapper`1<T>> pool; //Field offset: 0x0
	public readonly bool isStaticPool; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 28
	}

	public StructWrapperPool`1(bool isStaticPool) { }

	public StructWrapper<T> Acquire() { }

	public StructWrapper<T> Acquire(T value) { }

	public int get_Count() { }

	internal void Release(StructWrapper<T> obj) { }

}

