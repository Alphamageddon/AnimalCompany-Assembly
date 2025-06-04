namespace Fusion;

[DisallowMultipleComponent]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Sand (8))]
public class RunnerEnableVisibility : Behaviour, INetworkRunnerCallbacks
{

	public RunnerEnableVisibility() { }

	private void Awake() { }

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

	private override void Fusion.INetworkRunnerCallbacks.OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ArraySegment<Byte> data) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadDone(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSceneLoadStart(NetworkRunner runner) { }

	private override void Fusion.INetworkRunnerCallbacks.OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

	private override void Fusion.INetworkRunnerCallbacks.OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

	private override void Fusion.INetworkRunnerCallbacks.OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

	private void OnDestroy() { }

	public override void OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress) { }

	private void RunnerOnObjectAcquired(NetworkRunner runner, NetworkObject obj) { }

}

