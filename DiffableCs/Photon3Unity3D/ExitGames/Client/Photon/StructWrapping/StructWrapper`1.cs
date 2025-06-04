namespace ExitGames.Client.Photon.StructWrapping;

public class StructWrapper : StructWrapper
{
	internal static StructWrapperPool<T> staticPool; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StructWrapperPool<T> <ReturnPool>k__BackingField; //Field offset: 0x0
	internal Pooling pooling; //Field offset: 0x0
	internal T value; //Field offset: 0x0

	public internal StructWrapperPool<T> ReturnPool
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private static StructWrapper`1() { }

	public StructWrapper`1(Pooling releasing) { }

	public StructWrapper`1(Pooling releasing, Type tType, WrappedType wType) { }

	public virtual object Box() { }

	public virtual void DisconnectFromPool() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public StructWrapperPool<T> get_ReturnPool() { }

	public static StructWrapper<T> op_Implicit(T value) { }

	public T Peek() { }

	public StructWrapper<T> Poke(byte value) { }

	public StructWrapper<T> Poke(bool value) { }

	public StructWrapper<T> Poke(T value) { }

	[CompilerGenerated]
	internal void set_ReturnPool(StructWrapperPool<T> value) { }

	public virtual string ToString() { }

	public virtual string ToString(bool writeTypeInfo) { }

	public T Unwrap() { }

}

