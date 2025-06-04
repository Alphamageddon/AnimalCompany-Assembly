namespace Fusion.Internal;

public abstract class UnitySurrogateBase : IUnitySurrogate
{

	protected UnitySurrogateBase() { }

	public abstract void Init(int capacity) { }

	public abstract void Read(Int32* data, int capacity) { }

	public abstract void Write(Int32* data, int capacity) { }

}

