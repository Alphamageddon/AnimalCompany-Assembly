namespace Fusion;

[AddComponentMenu("Fusion/Network Events")]
public class NetworkEvents : Behaviour, INetworkRunnerCallbacks
{
	internal class ConnectFailedEvent : UnityEvent<NetworkRunner, NetAddress, NetConnectFailedReason>
	{

		public ConnectFailedEvent() { }

	}

	internal class ConnectRequestEvent : UnityEvent<NetworkRunner, ConnectRequest, Byte[]>
	{

		public ConnectRequestEvent() { }

	}

	internal class CustomAuthenticationResponse : UnityEvent<NetworkRunner, Dictionary`2<String, Object>>
	{

		public CustomAuthenticationResponse() { }

	}

	internal class DisconnectFromServerEvent : UnityEvent<NetworkRunner, NetDisconnectReason>
	{

		public DisconnectFromServerEvent() { }

	}

	internal class HostMigrationEvent : UnityEvent<NetworkRunner, HostMigrationToken>
	{

		public HostMigrationEvent() { }

	}

	internal class InputEvent : UnityEvent<NetworkRunner, NetworkInput>
	{

		public InputEvent() { }

	}

	internal class InputPlayerEvent : UnityEvent<NetworkRunner, PlayerRef, NetworkInput>
	{

		public InputPlayerEvent() { }

	}

	internal class ObjectEvent : UnityEvent<NetworkRunner, NetworkObject>
	{

		public ObjectEvent() { }

	}

	internal class ObjectPlayerEvent : UnityEvent<NetworkRunner, NetworkObject, PlayerRef>
	{

		public ObjectPlayerEvent() { }

	}

	internal class PlayerEvent : UnityEvent<NetworkRunner, PlayerRef>
	{

		public PlayerEvent() { }

	}

	internal class ReliableDataEvent : UnityEvent<NetworkRunner, PlayerRef, ReliableKey, ArraySegment`1<Byte>>
	{

		public ReliableDataEvent() { }

	}

	internal class ReliableProgressEvent : UnityEvent<NetworkRunner, PlayerRef, ReliableKey, Single>
	{

		public ReliableProgressEvent() { }

	}

	internal class RunnerEvent : UnityEvent<NetworkRunner>
	{

		public RunnerEvent() { }

	}

	internal class SessionListUpdateEvent : UnityEvent<NetworkRunner, List`1<SessionInfo>>
	{

		public SessionListUpdateEvent() { }

	}

	internal class ShutdownEvent : UnityEvent<NetworkRunner, ShutdownReason>
	{

		public ShutdownEvent() { }

	}

	internal class SimulationMessageEvent : UnityEvent<NetworkRunner, SimulationMessagePtr>
	{

		public SimulationMessageEvent() { }

	}

	public InputEvent OnInput; //Field offset: 0x20
	public InputPlayerEvent OnInputMissing; //Field offset: 0x28
	public RunnerEvent OnConnectedToServer; //Field offset: 0x30
	public DisconnectFromServerEvent OnDisconnectedFromServer; //Field offset: 0x38
	public ConnectRequestEvent OnConnectRequest; //Field offset: 0x40
	public ConnectFailedEvent OnConnectFailed; //Field offset: 0x48
	public PlayerEvent PlayerJoined; //Field offset: 0x50
	public PlayerEvent PlayerLeft; //Field offset: 0x58
	public SimulationMessageEvent OnSimulationMessage; //Field offset: 0x60
	public ShutdownEvent OnShutdown; //Field offset: 0x68
	public SessionListUpdateEvent OnSessionListUpdate; //Field offset: 0x70
	public CustomAuthenticationResponse OnCustomAuthenticationResponse; //Field offset: 0x78
	public HostMigrationEvent OnHostMigration; //Field offset: 0x80
	public RunnerEvent OnSceneLoadDone; //Field offset: 0x88
	public RunnerEvent OnSceneLoadStart; //Field offset: 0x90
	public ReliableDataEvent OnReliableData; //Field offset: 0x98
	public ReliableProgressEvent OnReliableProgress; //Field offset: 0xA0
	public ObjectPlayerEvent OnObjectEnterAOI; //Field offset: 0xA8
	public ObjectPlayerEvent OnObjectExitAOI; //Field offset: 0xB0

	public NetworkEvents() { }

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

