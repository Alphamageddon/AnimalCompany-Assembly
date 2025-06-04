namespace Fusion;

public struct RpcInfo
{
	public Tick Tick; //Field offset: 0x0
	public PlayerRef Source; //Field offset: 0x4
	public RpcChannel Channel; //Field offset: 0x8
	public bool IsInvokeLocal; //Field offset: 0xC

	public static RpcInfo FromLocal(NetworkRunner runner, RpcChannel channel, RpcHostMode hostMode) { }

	public static RpcInfo FromMessage(NetworkRunner runner, SimulationMessage* message, RpcHostMode hostMode) { }

	public virtual string ToString() { }

}

