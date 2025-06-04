namespace Fusion.Photon.Realtime.Async;

internal class OperationException : Exception
{
	public short ErrorCode; //Field offset: 0x8C

	public OperationException(short errorCode, string message) { }

}

