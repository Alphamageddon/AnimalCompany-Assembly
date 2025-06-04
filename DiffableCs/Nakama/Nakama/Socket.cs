namespace Nakama;

public class Socket : ISocket
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IApiUser, String> <>9__84_0; //Field offset: 0x8
		public static Func<IApiUser, String> <>9__112_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <FollowUsersAsync>b__84_0(IApiUser user) { }

		internal string <UnfollowUsersAsync>b__112_0(IApiUser user) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public Socket <>4__this; //Field offset: 0x10
		public WebSocketMessageEnvelope envelope; //Field offset: 0x18
		public TaskCompletionSource<WebSocketMessageEnvelope> completer; //Field offset: 0x20

		public <>c__DisplayClass122_0() { }

		internal void <SendAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <AddMatchmakerAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IMatchmakerTicket> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string query; //Field offset: 0x28
		public int minCount; //Field offset: 0x30
		public int maxCount; //Field offset: 0x34
		public Dictionary<String, String> stringProperties; //Field offset: 0x38
		public Dictionary<String, Double> numericProperties; //Field offset: 0x40
		public Nullable<Int32> countMultiple; //Field offset: 0x48
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddMatchmakerPartyAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IPartyMatchmakerTicket> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string partyId; //Field offset: 0x28
		public string query; //Field offset: 0x30
		public int minCount; //Field offset: 0x38
		public int maxCount; //Field offset: 0x3C
		public Dictionary<String, String> stringProperties; //Field offset: 0x40
		public Dictionary<String, Double> numericProperties; //Field offset: 0x48
		public Nullable<Int32> countMultiple; //Field offset: 0x50
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateMatchAsync>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IMatch> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string name; //Field offset: 0x28
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreatePartyAsync>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IParty> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public bool open; //Field offset: 0x28
		public int maxSize; //Field offset: 0x2C
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FollowUsersAsync>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IStatus> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public IEnumerable<String> userIDs; //Field offset: 0x28
		public IEnumerable<String> usernames; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinChatAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IChannel> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public bool hidden; //Field offset: 0x28
		public bool persistence; //Field offset: 0x29
		public string target; //Field offset: 0x30
		public ChannelType type; //Field offset: 0x38
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinMatchAsync>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IMatch> <>t__builder; //Field offset: 0x8
		public IMatchmakerMatched matched; //Field offset: 0x20
		public Socket <>4__this; //Field offset: 0x28
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinMatchAsync>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IMatch> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string matchId; //Field offset: 0x28
		public IDictionary<String, String> metadata; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ListPartyJoinRequestsAsync>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IPartyJoinRequest> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string partyId; //Field offset: 0x28
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemoveChatMessageAsync>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IChannelMessageAck> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string channelId; //Field offset: 0x28
		public string messageId; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcAsync>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string funcId; //Field offset: 0x28
		public string payload; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RpcAsync>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IApiRpc> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string funcId; //Field offset: 0x28
		public ArraySegment<Byte> payload; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAsync>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebSocketMessageEnvelope> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public WebSocketMessageEnvelope envelope; //Field offset: 0x28
		private <>c__DisplayClass122_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateChatMessageAsync>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IChannelMessageAck> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string channelId; //Field offset: 0x28
		public string messageId; //Field offset: 0x30
		public string content; //Field offset: 0x38
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteChatMessageAsync>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IChannelMessageAck> <>t__builder; //Field offset: 0x8
		public Socket <>4__this; //Field offset: 0x20
		public string channelId; //Field offset: 0x28
		public string content; //Field offset: 0x30
		private TaskAwaiter<WebSocketMessageEnvelope> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int DefaultConnectTimeout = 30; //Field offset: 0x0
	public const int DefaultSendTimeout = 10; //Field offset: 0x0
	private int _cid; //Field offset: 0x10
	[CompilerGenerated]
	private Action Closed; //Field offset: 0x18
	[CompilerGenerated]
	private Action Connected; //Field offset: 0x20
	[CompilerGenerated]
	private Action<IApiChannelMessage> ReceivedChannelMessage; //Field offset: 0x28
	[CompilerGenerated]
	private Action<IChannelPresenceEvent> ReceivedChannelPresence; //Field offset: 0x30
	[CompilerGenerated]
	private Action<Exception> ReceivedError; //Field offset: 0x38
	[CompilerGenerated]
	private Action<IMatchmakerMatched> ReceivedMatchmakerMatched; //Field offset: 0x40
	[CompilerGenerated]
	private Action<IMatchState> ReceivedMatchState; //Field offset: 0x48
	[CompilerGenerated]
	private Action<IMatchPresenceEvent> ReceivedMatchPresence; //Field offset: 0x50
	[CompilerGenerated]
	private Action<IApiNotification> ReceivedNotification; //Field offset: 0x58
	[CompilerGenerated]
	private Action<IStatusPresenceEvent> ReceivedStatusPresence; //Field offset: 0x60
	[CompilerGenerated]
	private Action<IStreamPresenceEvent> ReceivedStreamPresence; //Field offset: 0x68
	[CompilerGenerated]
	private Action<IStreamState> ReceivedStreamState; //Field offset: 0x70
	[CompilerGenerated]
	private Action<IParty> ReceivedParty; //Field offset: 0x78
	[CompilerGenerated]
	private Action<IPartyClose> ReceivedPartyClose; //Field offset: 0x80
	[CompilerGenerated]
	private Action<IPartyData> ReceivedPartyData; //Field offset: 0x88
	[CompilerGenerated]
	private Action<IPartyJoinRequest> ReceivedPartyJoinRequest; //Field offset: 0x90
	[CompilerGenerated]
	private Action<IPartyLeader> ReceivedPartyLeader; //Field offset: 0x98
	[CompilerGenerated]
	private Action<IPartyPresenceEvent> ReceivedPartyPresence; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<IPartyMatchmakerTicket> ReceivedPartyMatchmakerTicket; //Field offset: 0xA8
	[CompilerGenerated]
	private ILogger <Logger>k__BackingField; //Field offset: 0xB0
	private readonly ISocketAdapter _adapter; //Field offset: 0xB8
	private readonly Uri _baseUri; //Field offset: 0xC0
	private readonly Dictionary<String, TaskCompletionSource`1<WebSocketMessageEnvelope>> _responses; //Field offset: 0xC8
	private readonly TimeSpan _sendTimeoutSec; //Field offset: 0xD0
	private readonly object _responsesLock; //Field offset: 0xD8

	public override event Action Closed
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public override event Action Connected
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public override event Action<IApiChannelMessage> ReceivedChannelMessage
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IChannelPresenceEvent> ReceivedChannelPresence
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<Exception> ReceivedError
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IMatchmakerMatched> ReceivedMatchmakerMatched
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IMatchPresenceEvent> ReceivedMatchPresence
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IMatchState> ReceivedMatchState
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IApiNotification> ReceivedNotification
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IParty> ReceivedParty
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyClose> ReceivedPartyClose
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyData> ReceivedPartyData
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyJoinRequest> ReceivedPartyJoinRequest
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyLeader> ReceivedPartyLeader
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyMatchmakerTicket> ReceivedPartyMatchmakerTicket
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IPartyPresenceEvent> ReceivedPartyPresence
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IStatusPresenceEvent> ReceivedStatusPresence
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IStreamPresenceEvent> ReceivedStreamPresence
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override event Action<IStreamState> ReceivedStreamState
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public override bool IsConnected
	{
		 get { } //Length: 164
	}

	public override bool IsConnecting
	{
		 get { } //Length: 164
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Socket(string scheme, string host, int port, ISocketAdapter adapter, int sendTimeoutSec = 10) { }

	public Socket(ISocketAdapter adapter) { }

	public Socket() { }

	[CompilerGenerated]
	private void <.ctor>b__75_0() { }

	[CompilerGenerated]
	private void <.ctor>b__75_1() { }

	[CompilerGenerated]
	private void <.ctor>b__75_2(Exception e) { }

	public override Task AcceptPartyMemberAsync(string partyId, IUserPresence presence) { }

	[CompilerGenerated]
	public override void add_Closed(Action value) { }

	[CompilerGenerated]
	public override void add_Connected(Action value) { }

	[CompilerGenerated]
	public override void add_ReceivedChannelMessage(Action<IApiChannelMessage> value) { }

	[CompilerGenerated]
	public override void add_ReceivedChannelPresence(Action<IChannelPresenceEvent> value) { }

	[CompilerGenerated]
	public override void add_ReceivedError(Action<Exception> value) { }

	[CompilerGenerated]
	public override void add_ReceivedMatchmakerMatched(Action<IMatchmakerMatched> value) { }

	[CompilerGenerated]
	public override void add_ReceivedMatchPresence(Action<IMatchPresenceEvent> value) { }

	[CompilerGenerated]
	public override void add_ReceivedMatchState(Action<IMatchState> value) { }

	[CompilerGenerated]
	public override void add_ReceivedNotification(Action<IApiNotification> value) { }

	[CompilerGenerated]
	public override void add_ReceivedParty(Action<IParty> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyClose(Action<IPartyClose> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyData(Action<IPartyData> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyJoinRequest(Action<IPartyJoinRequest> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyLeader(Action<IPartyLeader> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyMatchmakerTicket(Action<IPartyMatchmakerTicket> value) { }

	[CompilerGenerated]
	public override void add_ReceivedPartyPresence(Action<IPartyPresenceEvent> value) { }

	[CompilerGenerated]
	public override void add_ReceivedStatusPresence(Action<IStatusPresenceEvent> value) { }

	[CompilerGenerated]
	public override void add_ReceivedStreamPresence(Action<IStreamPresenceEvent> value) { }

	[CompilerGenerated]
	public override void add_ReceivedStreamState(Action<IStreamState> value) { }

	[AsyncStateMachine(typeof(<AddMatchmakerAsync>d__77))]
	public override Task<IMatchmakerTicket> AddMatchmakerAsync(string query = "*", int minCount = 2, int maxCount = 8, Dictionary<String, String> stringProperties = null, Dictionary<String, Double> numericProperties = null, Nullable<Int32> countMultiple = null) { }

	[AsyncStateMachine(typeof(<AddMatchmakerPartyAsync>d__78))]
	public override Task<IPartyMatchmakerTicket> AddMatchmakerPartyAsync(string partyId, string query, int minCount, int maxCount, Dictionary<String, String> stringProperties = null, Dictionary<String, Double> numericProperties = null, Nullable<Int32> countMultiple = null) { }

	private static List<UserPresence> BuildPresenceList(IEnumerable<IUserPresence> presences) { }

	public override Task CloseAsync() { }

	public override Task ClosePartyAsync(string partyId) { }

	public override Task ConnectAsync(ISession session, bool appearOnline = false, int connectTimeoutSec = 30, string langTag = "en") { }

	[AsyncStateMachine(typeof(<CreateMatchAsync>d__82))]
	public override Task<IMatch> CreateMatchAsync(string name = null) { }

	[AsyncStateMachine(typeof(<CreatePartyAsync>d__83))]
	public override Task<IParty> CreatePartyAsync(bool open, int maxSize) { }

	[AsyncStateMachine(typeof(<FollowUsersAsync>d__85))]
	public override Task<IStatus> FollowUsersAsync(IEnumerable<String> userIDs, IEnumerable<String> usernames = null) { }

	public override Task<IStatus> FollowUsersAsync(IEnumerable<IApiUser> users) { }

	public static ISocket From(IClient client) { }

	public static ISocket From(IClient client, ISocketAdapter adapter) { }

	public override bool get_IsConnected() { }

	public override bool get_IsConnecting() { }

	[CompilerGenerated]
	public ILogger get_Logger() { }

	[AsyncStateMachine(typeof(<JoinChatAsync>d__86))]
	public override Task<IChannel> JoinChatAsync(string target, ChannelType type, bool persistence = false, bool hidden = false) { }

	[AsyncStateMachine(typeof(<JoinMatchAsync>d__88))]
	public override Task<IMatch> JoinMatchAsync(string matchId, IDictionary<String, String> metadata = null) { }

	[AsyncStateMachine(typeof(<JoinMatchAsync>d__87))]
	public override Task<IMatch> JoinMatchAsync(IMatchmakerMatched matched) { }

	public override Task JoinPartyAsync(string partyId) { }

	public override Task LeaveChatAsync(string channelId) { }

	public override Task LeaveChatAsync(IChannel channel) { }

	public override Task LeaveMatchAsync(string matchId) { }

	public override Task LeaveMatchAsync(IMatch match) { }

	public override Task LeavePartyAsync(string partyId) { }

	[AsyncStateMachine(typeof(<ListPartyJoinRequestsAsync>d__95))]
	public override Task<IPartyJoinRequest> ListPartyJoinRequestsAsync(string partyId) { }

	private void ProcessMessage(ArraySegment<Byte> buffer) { }

	public override Task PromotePartyMemberAsync(string partyId, IUserPresence partyMember) { }

	[CompilerGenerated]
	public override void remove_Closed(Action value) { }

	[CompilerGenerated]
	public override void remove_Connected(Action value) { }

	[CompilerGenerated]
	public override void remove_ReceivedChannelMessage(Action<IApiChannelMessage> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedChannelPresence(Action<IChannelPresenceEvent> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedError(Action<Exception> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedMatchmakerMatched(Action<IMatchmakerMatched> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedMatchPresence(Action<IMatchPresenceEvent> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedMatchState(Action<IMatchState> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedNotification(Action<IApiNotification> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedParty(Action<IParty> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyClose(Action<IPartyClose> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyData(Action<IPartyData> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyJoinRequest(Action<IPartyJoinRequest> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyLeader(Action<IPartyLeader> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyMatchmakerTicket(Action<IPartyMatchmakerTicket> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedPartyPresence(Action<IPartyPresenceEvent> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedStatusPresence(Action<IStatusPresenceEvent> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedStreamPresence(Action<IStreamPresenceEvent> value) { }

	[CompilerGenerated]
	public override void remove_ReceivedStreamState(Action<IStreamState> value) { }

	public override Task<IChannelMessageAck> RemoveChatMessageAsync(IChannel channel, string messageId) { }

	[AsyncStateMachine(typeof(<RemoveChatMessageAsync>d__98))]
	public override Task<IChannelMessageAck> RemoveChatMessageAsync(string channelId, string messageId) { }

	public override Task RemoveMatchmakerAsync(IMatchmakerTicket ticket) { }

	public override Task RemoveMatchmakerAsync(string ticket) { }

	public override Task RemoveMatchmakerPartyAsync(string partyId, string ticket) { }

	public override Task RemovePartyMemberAsync(string partyId, IUserPresence presence) { }

	[AsyncStateMachine(typeof(<RpcAsync>d__103))]
	public override Task<IApiRpc> RpcAsync(string funcId, string payload = null) { }

	[AsyncStateMachine(typeof(<RpcAsync>d__104))]
	public override Task<IApiRpc> RpcAsync(string funcId, ArraySegment<Byte> payload) { }

	[AsyncStateMachine(typeof(<SendAsync>d__122))]
	private Task<WebSocketMessageEnvelope> SendAsync(WebSocketMessageEnvelope envelope) { }

	public override Task SendMatchStateAsync(string matchId, long opCode, ArraySegment<Byte> state, IEnumerable<IUserPresence> presences = null) { }

	public override Task SendMatchStateAsync(string matchId, long opCode, string state, IEnumerable<IUserPresence> presences = null) { }

	public override Task SendMatchStateAsync(string matchId, long opCode, Byte[] state, IEnumerable<IUserPresence> presences = null) { }

	public override Task SendPartyDataAsync(string partyId, long opCode, ArraySegment<Byte> data) { }

	public override Task SendPartyDataAsync(string partyId, long opCode, string data) { }

	public override Task SendPartyDataAsync(string partyId, long opCode, Byte[] data) { }

	[CompilerGenerated]
	public void set_Logger(ILogger value) { }

	public virtual string ToString() { }

	public override Task UnfollowUsersAsync(IEnumerable<String> userIDs) { }

	public override Task UnfollowUsersAsync(IEnumerable<IApiUser> users) { }

	[AsyncStateMachine(typeof(<UpdateChatMessageAsync>d__115))]
	public override Task<IChannelMessageAck> UpdateChatMessageAsync(string channelId, string messageId, string content) { }

	public override Task<IChannelMessageAck> UpdateChatMessageAsync(IChannel channel, string messageId, string content) { }

	public override Task UpdateStatusAsync(string status) { }

	public override Task<IChannelMessageAck> WriteChatMessageAsync(IChannel channel, string content) { }

	[AsyncStateMachine(typeof(<WriteChatMessageAsync>d__118))]
	public override Task<IChannelMessageAck> WriteChatMessageAsync(string channelId, string content) { }

}

