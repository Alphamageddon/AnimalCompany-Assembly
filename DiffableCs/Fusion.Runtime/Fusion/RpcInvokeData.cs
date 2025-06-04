namespace Fusion;

public struct RpcInvokeData
{
	public int Key; //Field offset: 0x0
	public int Sources; //Field offset: 0x4
	public int Targets; //Field offset: 0x8
	public RpcInvokeDelegate Delegate; //Field offset: 0x10

	public virtual string ToString() { }

}

