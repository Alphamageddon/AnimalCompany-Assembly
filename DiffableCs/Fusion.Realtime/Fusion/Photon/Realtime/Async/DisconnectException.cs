namespace Fusion.Photon.Realtime.Async;

internal class DisconnectException : Exception
{
	public DisconnectCause Cause; //Field offset: 0x8C

	public DisconnectException(DisconnectCause cause) { }

}

