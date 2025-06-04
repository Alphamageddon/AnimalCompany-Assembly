namespace Fusion.Statistics;

public class NetworkObjectStatisticsManager
{
	private HashSet<NetworkId> _monitoredNetworkObjects; //Field offset: 0x10
	private Dictionary<NetworkId, NetworkObjectStatisticsSnapshot> _pendingSnapshots; //Field offset: 0x18
	private Dictionary<NetworkId, NetworkObjectStatisticsSnapshot> _completedSnapshots; //Field offset: 0x20
	private Stack<NetworkObjectStatisticsSnapshot> _free; //Field offset: 0x28

	internal NetworkObjectStatisticsManager() { }

	[Conditional("DEBUG")]
	internal void AddToNetworkObjectInBandwidth(NetworkId id, float value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToNetworkObjectInPackets(NetworkId id, int value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToNetworkObjectOutBandwidth(NetworkId id, float value, bool overrideValue = false) { }

	[Conditional("DEBUG")]
	internal void AddToNetworkObjectOutPackets(NetworkId id, int value, bool overrideValue = false) { }

	public void ClearMonitoredNetworkObjects() { }

	[Conditional("DEBUG")]
	internal void CollectStatistics() { }

	public bool GetNetworkObjectStatistics(NetworkId id, out NetworkObjectStatisticsSnapshot objectStatisticsSnapshot) { }

	private NetworkObjectStatisticsSnapshot GetNewStatisticsObject() { }

	private bool IsObjectMonitored(NetworkId id, Dictionary<NetworkId, NetworkObjectStatisticsSnapshot> source, out NetworkObjectStatisticsSnapshot snapshot) { }

	public void MonitorNetworkObjectStatistics(NetworkId id, bool monitor) { }

}

