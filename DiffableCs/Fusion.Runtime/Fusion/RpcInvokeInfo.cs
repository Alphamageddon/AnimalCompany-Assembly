namespace Fusion;

public struct RpcInvokeInfo
{
	public RpcLocalInvokeResult LocalInvokeResult; //Field offset: 0x0
	public RpcSendCullResult SendCullResult; //Field offset: 0x4
	public RpcSendResult SendResult; //Field offset: 0x8

	public virtual string ToString() { }

}

