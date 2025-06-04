namespace Fusion.Sockets;

public interface INetPeerGroupCallbacks
{

	public void OnConnected(NetConnection* connection) { }

	public void OnConnectionAttempt(NetConnection* connection, int attempts, int totalConnectAttempts) { }

	public void OnConnectionFailed(NetAddress address, NetConnectFailedReason reason) { }

	public OnConnectionRequestReply OnConnectionRequest(NetAddress remoteAddress, Byte[] token, Byte[] uniqueId) { }

	public void OnDisconnected(NetConnection* connection, NetDisconnectReason reason) { }

	public void OnNotifyData(NetConnection* connection, NetBitBuffer* buffer) { }

	public void OnNotifyDelivered(NetConnection* connection, NetSendEnvelope envelope) { }

	public void OnNotifyDispose(NetSendEnvelope envelope) { }

	public void OnNotifyLost(NetConnection* connection, NetSendEnvelope envelope) { }

	public void OnReliableData(NetConnection* connection, ReliableId id, Byte* data) { }

	public void OnUnconnectedData(NetBitBuffer* buffer) { }

	public void OnUnreliableData(NetConnection* connection, NetBitBuffer* buffer) { }

}

