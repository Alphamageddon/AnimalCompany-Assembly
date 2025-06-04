namespace Fusion;

public class NetworkDelegates : INetworkRunnerCallbacks
{
	public Action<NetworkRunner, PlayerRef> OnPlayerJoined; //Field offset: 0x10
	public Action<NetworkRunner, PlayerRef> OnPlayerLeft; //Field offset: 0x18
	public Action<NetworkRunner, NetworkInput> OnInput; //Field offset: 0x20
	public Action<NetworkRunner, PlayerRef, NetworkInput> OnInputMissing; //Field offset: 0x28
	public Action<NetworkRunner, ShutdownReason> OnShutdown; //Field offset: 0x30
	public Action<NetworkRunner> OnConnectedToServer; //Field offset: 0x38
	public Action<NetworkRunner, NetDisconnectReason> OnDisconnectedFromServer; //Field offset: 0x40
	public Action<NetworkRunner> OnSceneLoadDone; //Field offset: 0x48
	public Action<NetworkRunner> OnSceneLoadStart; //Field offset: 0x50
	public Action<NetworkRunner, ConnectRequest, Byte[]> OnConnectRequest; //Field offset: 0x58
	public Action<NetworkRunner, NetAddress, NetConnectFailedReason> OnConnectFailed; //Field offset: 0x60
	public Action<NetworkRunner, SimulationMessagePtr> OnUserSimulationMessage; //Field offset: 0x68
	public Action<NetworkRunner, List`1<SessionInfo>> OnSessionListUpdated; //Field offset: 0x70
	public Action<NetworkRunner, Dictionary`2<String, Object>> OnCustomAuthenticationResponse; //Field offset: 0x78
	public Action<NetworkRunner, HostMigrationToken> OnHostMigration; //Field offset: 0x80
	public Action<NetworkRunner, PlayerRef, ReliableKey, ArraySegment`1<Byte>> OnReliableDataReceived; //Field offset: 0x88
	public Action<NetworkRunner, PlayerRef, ReliableKey, Single> OnReliableDataProgress; //Field offset: 0x90
	public Action<NetworkRunner, NetworkObject, PlayerRef> OnObjectExitAOI; //Field offset: 0x98
	public Action<NetworkRunner, NetworkObject, PlayerRef> OnObjectEnterAOI; //Field offset: 0xA0

	public NetworkDelegates() { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectedToServer(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnConnectRequest(NetworkRunner runner, ConnectRequest request, Byte[] token) { }

	private override void Fusion.INetworkRunnerCallbacks.OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<String, Object> data) { }

	private override void Fusion.INetworkRunnerCallbacks.OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

	private override void Fusion.INetworkRunnerCallbacks.OnInput(NetworkRunner runner, NetworkInput input) { }

	private override void Fusion.INetworkRunnerCallbacks.OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }

	private override void Fusion.INetworkRunnerCallbacks.OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnPlayerJoined(NetworkRunner runner, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }

	private override void Fusion.INetworkRunnerCallbacks.OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress) { }

	private override void Fusion.INetworkRunnerCallbacks.OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ArraySegment<Byte> data) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadDone(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadStart(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

	private override void Fusion.INetworkRunnerCallbacks.OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

}

