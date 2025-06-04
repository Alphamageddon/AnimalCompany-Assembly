namespace Fusion;

internal class NetworkObjectConnectionData
{
	public NetworkObjectConnectionData Prev; //Field offset: 0x10
	public NetworkObjectConnectionData Next; //Field offset: 0x18
	public NetworkId Id; //Field offset: 0x20
	public NetworkObjectMeta MetaCache; //Field offset: 0x28
	public int PriorityLevel; //Field offset: 0x30
	public NetworkObjectConnectionDataStatus Status; //Field offset: 0x34
	public bool MainTRSP; //Field offset: 0x38
	public Tick TickSent; //Field offset: 0x3C
	public Tick TickAcknowledged; //Field offset: 0x40
	public Tick TickMin; //Field offset: 0x44
	public ulong Filter; //Field offset: 0x48
	public PlayerUniqueData UniqueData; //Field offset: 0x50
	public PlayerUniqueDataChanges UniqueDataChanges; //Field offset: 0x54

	public NetworkObjectConnectionData() { }

	public void ClearPlayerDataFlag(NetworkObjectHeaderPlayerDataFlags flags, Simulation simulation) { }

	public ValueTuple<PlayerUniqueData, PlayerUniqueDataChanges> GetPlayerData() { }

	public bool HasAnyPlayerDataFlag(NetworkObjectHeaderPlayerDataFlags flags) { }

	public bool HasPlayerDataFlag(NetworkObjectHeaderPlayerDataFlags flags) { }

	public void SetPlayerDataFlag(NetworkObjectHeaderPlayerDataFlags flags, Simulation simulation) { }

}

