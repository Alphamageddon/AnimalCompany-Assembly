namespace Nakama;

public interface ISocket
{

	public event Action Closed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action Connected
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IApiChannelMessage> ReceivedChannelMessage
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IChannelPresenceEvent> ReceivedChannelPresence
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<Exception> ReceivedError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IMatchmakerMatched> ReceivedMatchmakerMatched
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IMatchPresenceEvent> ReceivedMatchPresence
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IMatchState> ReceivedMatchState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IApiNotification> ReceivedNotification
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IParty> ReceivedParty
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyClose> ReceivedPartyClose
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyData> ReceivedPartyData
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyJoinRequest> ReceivedPartyJoinRequest
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyLeader> ReceivedPartyLeader
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyMatchmakerTicket> ReceivedPartyMatchmakerTicket
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IPartyPresenceEvent> ReceivedPartyPresence
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IStatusPresenceEvent> ReceivedStatusPresence
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IStreamPresenceEvent> ReceivedStreamPresence
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<IStreamState> ReceivedStreamState
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsConnected
	{
		 get { } //Length: 0
	}

	public bool IsConnecting
	{
		 get { } //Length: 0
	}

	public Task AcceptPartyMemberAsync(string partyId, IUserPresence presence) { }

	[CompilerGenerated]
	public void add_Closed(Action value) { }

	[CompilerGenerated]
	public void add_Connected(Action value) { }

	[CompilerGenerated]
	public void add_ReceivedChannelMessage(Action<IApiChannelMessage> value) { }

	[CompilerGenerated]
	public void add_ReceivedChannelPresence(Action<IChannelPresenceEvent> value) { }

	[CompilerGenerated]
	public void add_ReceivedError(Action<Exception> value) { }

	[CompilerGenerated]
	public void add_ReceivedMatchmakerMatched(Action<IMatchmakerMatched> value) { }

	[CompilerGenerated]
	public void add_ReceivedMatchPresence(Action<IMatchPresenceEvent> value) { }

	[CompilerGenerated]
	public void add_ReceivedMatchState(Action<IMatchState> value) { }

	[CompilerGenerated]
	public void add_ReceivedNotification(Action<IApiNotification> value) { }

	[CompilerGenerated]
	public void add_ReceivedParty(Action<IParty> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyClose(Action<IPartyClose> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyData(Action<IPartyData> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyJoinRequest(Action<IPartyJoinRequest> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyLeader(Action<IPartyLeader> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyMatchmakerTicket(Action<IPartyMatchmakerTicket> value) { }

	[CompilerGenerated]
	public void add_ReceivedPartyPresence(Action<IPartyPresenceEvent> value) { }

	[CompilerGenerated]
	public void add_ReceivedStatusPresence(Action<IStatusPresenceEvent> value) { }

	[CompilerGenerated]
	public void add_ReceivedStreamPresence(Action<IStreamPresenceEvent> value) { }

	[CompilerGenerated]
	public void add_ReceivedStreamState(Action<IStreamState> value) { }

	public Task<IMatchmakerTicket> AddMatchmakerAsync(string query = "*", int minCount = 2, int maxCount = 8, Dictionary<String, String> stringProperties = null, Dictionary<String, Double> numericProperties = null, Nullable<Int32> countMultiple = null) { }

	public Task<IPartyMatchmakerTicket> AddMatchmakerPartyAsync(string partyId, string query, int minCount, int maxCount, Dictionary<String, String> stringProperties = null, Dictionary<String, Double> numericProperties = null, Nullable<Int32> countMultiple = null) { }

	public Task CloseAsync() { }

	public Task ClosePartyAsync(string partyId) { }

	public Task ConnectAsync(ISession session, bool appearOnline = false, int connectTimeout = 30, string langTag = "en") { }

	public Task<IMatch> CreateMatchAsync(string matchName = null) { }

	public Task<IParty> CreatePartyAsync(bool open, int maxSize) { }

	public Task<IStatus> FollowUsersAsync(IEnumerable<String> userIDs, IEnumerable<String> usernames = null) { }

	public Task<IStatus> FollowUsersAsync(IEnumerable<IApiUser> users) { }

	public bool get_IsConnected() { }

	public bool get_IsConnecting() { }

	public Task<IChannel> JoinChatAsync(string target, ChannelType type, bool persistence = false, bool hidden = false) { }

	public Task<IMatch> JoinMatchAsync(IMatchmakerMatched matched) { }

	public Task<IMatch> JoinMatchAsync(string matchId, IDictionary<String, String> metadata = null) { }

	public Task JoinPartyAsync(string partyId) { }

	public Task LeaveChatAsync(IChannel channel) { }

	public Task LeaveChatAsync(string channelId) { }

	public Task LeaveMatchAsync(string matchId) { }

	public Task LeaveMatchAsync(IMatch match) { }

	public Task LeavePartyAsync(string partyId) { }

	public Task<IPartyJoinRequest> ListPartyJoinRequestsAsync(string partyId) { }

	public Task PromotePartyMemberAsync(string partyId, IUserPresence partyMember) { }

	[CompilerGenerated]
	public void remove_Closed(Action value) { }

	[CompilerGenerated]
	public void remove_Connected(Action value) { }

	[CompilerGenerated]
	public void remove_ReceivedChannelMessage(Action<IApiChannelMessage> value) { }

	[CompilerGenerated]
	public void remove_ReceivedChannelPresence(Action<IChannelPresenceEvent> value) { }

	[CompilerGenerated]
	public void remove_ReceivedError(Action<Exception> value) { }

	[CompilerGenerated]
	public void remove_ReceivedMatchmakerMatched(Action<IMatchmakerMatched> value) { }

	[CompilerGenerated]
	public void remove_ReceivedMatchPresence(Action<IMatchPresenceEvent> value) { }

	[CompilerGenerated]
	public void remove_ReceivedMatchState(Action<IMatchState> value) { }

	[CompilerGenerated]
	public void remove_ReceivedNotification(Action<IApiNotification> value) { }

	[CompilerGenerated]
	public void remove_ReceivedParty(Action<IParty> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyClose(Action<IPartyClose> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyData(Action<IPartyData> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyJoinRequest(Action<IPartyJoinRequest> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyLeader(Action<IPartyLeader> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyMatchmakerTicket(Action<IPartyMatchmakerTicket> value) { }

	[CompilerGenerated]
	public void remove_ReceivedPartyPresence(Action<IPartyPresenceEvent> value) { }

	[CompilerGenerated]
	public void remove_ReceivedStatusPresence(Action<IStatusPresenceEvent> value) { }

	[CompilerGenerated]
	public void remove_ReceivedStreamPresence(Action<IStreamPresenceEvent> value) { }

	[CompilerGenerated]
	public void remove_ReceivedStreamState(Action<IStreamState> value) { }

	public Task<IChannelMessageAck> RemoveChatMessageAsync(IChannel channel, string messageId) { }

	public Task<IChannelMessageAck> RemoveChatMessageAsync(string channelId, string messageId) { }

	public Task RemoveMatchmakerAsync(IMatchmakerTicket ticket) { }

	public Task RemoveMatchmakerAsync(string ticket) { }

	public Task RemoveMatchmakerPartyAsync(string partyId, string ticket) { }

	public Task RemovePartyMemberAsync(string partyId, IUserPresence presence) { }

	public Task<IApiRpc> RpcAsync(string funcId, ArraySegment<Byte> payload) { }

	public Task<IApiRpc> RpcAsync(string funcId, string payload = null) { }

	public Task SendMatchStateAsync(string matchId, long opCode, string state, IEnumerable<IUserPresence> presences = null) { }

	public Task SendMatchStateAsync(string matchId, long opCode, ArraySegment<Byte> state, IEnumerable<IUserPresence> presences = null) { }

	public Task SendMatchStateAsync(string matchId, long opCode, Byte[] state, IEnumerable<IUserPresence> presences = null) { }

	public Task SendPartyDataAsync(string partyId, long opCode, ArraySegment<Byte> data) { }

	public Task SendPartyDataAsync(string partyId, long opCode, string data) { }

	public Task SendPartyDataAsync(string partyId, long opCode, Byte[] data) { }

	public Task UnfollowUsersAsync(IEnumerable<IApiUser> users) { }

	public Task UnfollowUsersAsync(IEnumerable<String> userIDs) { }

	public Task<IChannelMessageAck> UpdateChatMessageAsync(IChannel channel, string messageId, string content) { }

	public Task<IChannelMessageAck> UpdateChatMessageAsync(string channelId, string messageId, string content) { }

	public Task UpdateStatusAsync(string status) { }

	public Task<IChannelMessageAck> WriteChatMessageAsync(IChannel channel, string content) { }

	public Task<IChannelMessageAck> WriteChatMessageAsync(string channelId, string content) { }

}

