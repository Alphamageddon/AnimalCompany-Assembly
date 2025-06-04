namespace ExitGames.Client.Photon;

internal class NCommandPool
{
	private readonly Stack<NCommand> pool; //Field offset: 0x10

	public NCommandPool() { }

	public NCommand Acquire(EnetPeer peer, Byte[] inBuff, ref int readingOffset) { }

	public NCommand Acquire(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) { }

	public void Release(NCommand nCommand) { }

}

