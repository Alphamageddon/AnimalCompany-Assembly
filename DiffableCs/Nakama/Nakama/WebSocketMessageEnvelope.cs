namespace Nakama;

internal class WebSocketMessageEnvelope
{
	[CompilerGenerated]
	private string <Cid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Channel <Channel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ChannelJoinMessage <ChannelJoin>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ChannelLeaveMessage <ChannelLeave>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ApiChannelMessage <ChannelMessage>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ChannelMessageAck <ChannelMessageAck>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private ChannelRemoveMessage <ChannelMessageRemove>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ChannelSendMessage <ChannelMessageSend>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private ChannelUpdateMessage <ChannelMessageUpdate>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private ChannelPresenceEvent <ChannelPresenceEvent>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private WebSocketErrorMessage <Error>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private MatchmakerAddMessage <MatchmakerAdd>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private MatchmakerMatched <MatchmakerMatched>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private MatchmakerRemoveMessage <MatchmakerRemove>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private MatchmakerTicket <MatchmakerTicket>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Match <Match>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private MatchCreateMessage <MatchCreate>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private MatchJoinMessage <MatchJoin>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private MatchLeaveMessage <MatchLeave>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private MatchPresenceEvent <MatchPresenceEvent>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private MatchState <MatchState>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private MatchSendMessage <MatchStateSend>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private ApiNotificationList <NotificationList>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private ApiRpc <Rpc>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Status <Status>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private StatusFollowMessage <StatusFollow>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private StatusPresenceEvent <StatusPresenceEvent>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private StatusUnfollowMessage <StatusUnfollow>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private StatusUpdateMessage <StatusUpdate>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private StreamPresenceEvent <StreamPresenceEvent>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private StreamState <StreamState>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Party <Party>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private PartyCreate <PartyCreate>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private PartyJoin <PartyJoin>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private PartyLeave <PartyLeave>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private PartyPromote <PartyPromote>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private PartyLeader <PartyLeader>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private PartyAccept <PartyAccept>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private PartyMemberRemove <PartyMemberRemove>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private PartyClose <PartyClose>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private PartyJoinRequestList <PartyJoinRequestList>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private PartyJoinRequest <PartyJoinRequest>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private PartyMatchmakerAdd <PartyMatchmakerAdd>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private PartyMatchmakerRemove <PartyMatchmakerRemove>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private PartyMatchmakerTicket <PartyMatchmakerTicket>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private PartyData <PartyData>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private PartyDataSend <PartyDataSend>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private PartyPresenceEvent <PartyPresenceEvent>k__BackingField; //Field offset: 0x188

	[DataMember(Name = "channel")]
	[Preserve]
	public Channel Channel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_join")]
	[Preserve]
	public ChannelJoinMessage ChannelJoin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_leave")]
	[Preserve]
	public ChannelLeaveMessage ChannelLeave
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_message")]
	[Preserve]
	public ApiChannelMessage ChannelMessage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_message_ack")]
	[Preserve]
	public ChannelMessageAck ChannelMessageAck
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_message_remove")]
	[Preserve]
	public ChannelRemoveMessage ChannelMessageRemove
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_message_send")]
	[Preserve]
	public ChannelSendMessage ChannelMessageSend
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_message_update")]
	[Preserve]
	public ChannelUpdateMessage ChannelMessageUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "channel_presence_event")]
	[Preserve]
	public ChannelPresenceEvent ChannelPresenceEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "cid")]
	[Preserve]
	public string Cid
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "error")]
	[Preserve]
	public WebSocketErrorMessage Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match")]
	[Preserve]
	public Match Match
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_create")]
	[Preserve]
	public MatchCreateMessage MatchCreate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_join")]
	[Preserve]
	public MatchJoinMessage MatchJoin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_leave")]
	[Preserve]
	public MatchLeaveMessage MatchLeave
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "matchmaker_add")]
	[Preserve]
	public MatchmakerAddMessage MatchmakerAdd
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "matchmaker_matched")]
	[Preserve]
	public MatchmakerMatched MatchmakerMatched
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "matchmaker_remove")]
	[Preserve]
	public MatchmakerRemoveMessage MatchmakerRemove
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "matchmaker_ticket")]
	[Preserve]
	public MatchmakerTicket MatchmakerTicket
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_presence_event")]
	[Preserve]
	public MatchPresenceEvent MatchPresenceEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_data")]
	[Preserve]
	public MatchState MatchState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "match_data_send")]
	[Preserve]
	public MatchSendMessage MatchStateSend
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "notifications")]
	[Preserve]
	public ApiNotificationList NotificationList
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party")]
	[Preserve]
	public Party Party
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_accept")]
	[Preserve]
	public PartyAccept PartyAccept
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_close")]
	[Preserve]
	public PartyClose PartyClose
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_create")]
	[Preserve]
	public PartyCreate PartyCreate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_data")]
	[Preserve]
	public PartyData PartyData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_data_send")]
	[Preserve]
	public PartyDataSend PartyDataSend
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_join")]
	[Preserve]
	public PartyJoin PartyJoin
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_join_request")]
	[Preserve]
	public PartyJoinRequest PartyJoinRequest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_join_request_list")]
	[Preserve]
	public PartyJoinRequestList PartyJoinRequestList
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_leader")]
	[Preserve]
	public PartyLeader PartyLeader
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_leave")]
	[Preserve]
	public PartyLeave PartyLeave
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_matchmaker_add")]
	[Preserve]
	public PartyMatchmakerAdd PartyMatchmakerAdd
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_matchmaker_remove")]
	[Preserve]
	public PartyMatchmakerRemove PartyMatchmakerRemove
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_matchmaker_ticket")]
	[Preserve]
	public PartyMatchmakerTicket PartyMatchmakerTicket
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_remove")]
	[Preserve]
	public PartyMemberRemove PartyMemberRemove
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_presence_event")]
	[Preserve]
	public PartyPresenceEvent PartyPresenceEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "party_promote")]
	[Preserve]
	public PartyPromote PartyPromote
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "rpc")]
	[Preserve]
	public ApiRpc Rpc
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status")]
	[Preserve]
	public Status Status
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status_follow")]
	[Preserve]
	public StatusFollowMessage StatusFollow
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status_presence_event")]
	[Preserve]
	public StatusPresenceEvent StatusPresenceEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status_unfollow")]
	[Preserve]
	public StatusUnfollowMessage StatusUnfollow
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status_update")]
	[Preserve]
	public StatusUpdateMessage StatusUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "stream_presence_event")]
	[Preserve]
	public StreamPresenceEvent StreamPresenceEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "stream_data")]
	[Preserve]
	public StreamState StreamState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public WebSocketMessageEnvelope() { }

	[CompilerGenerated]
	public Channel get_Channel() { }

	[CompilerGenerated]
	public ChannelJoinMessage get_ChannelJoin() { }

	[CompilerGenerated]
	public ChannelLeaveMessage get_ChannelLeave() { }

	[CompilerGenerated]
	public ApiChannelMessage get_ChannelMessage() { }

	[CompilerGenerated]
	public ChannelMessageAck get_ChannelMessageAck() { }

	[CompilerGenerated]
	public ChannelRemoveMessage get_ChannelMessageRemove() { }

	[CompilerGenerated]
	public ChannelSendMessage get_ChannelMessageSend() { }

	[CompilerGenerated]
	public ChannelUpdateMessage get_ChannelMessageUpdate() { }

	[CompilerGenerated]
	public ChannelPresenceEvent get_ChannelPresenceEvent() { }

	[CompilerGenerated]
	public string get_Cid() { }

	[CompilerGenerated]
	public WebSocketErrorMessage get_Error() { }

	[CompilerGenerated]
	public Match get_Match() { }

	[CompilerGenerated]
	public MatchCreateMessage get_MatchCreate() { }

	[CompilerGenerated]
	public MatchJoinMessage get_MatchJoin() { }

	[CompilerGenerated]
	public MatchLeaveMessage get_MatchLeave() { }

	[CompilerGenerated]
	public MatchmakerAddMessage get_MatchmakerAdd() { }

	[CompilerGenerated]
	public MatchmakerMatched get_MatchmakerMatched() { }

	[CompilerGenerated]
	public MatchmakerRemoveMessage get_MatchmakerRemove() { }

	[CompilerGenerated]
	public MatchmakerTicket get_MatchmakerTicket() { }

	[CompilerGenerated]
	public MatchPresenceEvent get_MatchPresenceEvent() { }

	[CompilerGenerated]
	public MatchState get_MatchState() { }

	[CompilerGenerated]
	public MatchSendMessage get_MatchStateSend() { }

	[CompilerGenerated]
	public ApiNotificationList get_NotificationList() { }

	[CompilerGenerated]
	public Party get_Party() { }

	[CompilerGenerated]
	public PartyAccept get_PartyAccept() { }

	[CompilerGenerated]
	public PartyClose get_PartyClose() { }

	[CompilerGenerated]
	public PartyCreate get_PartyCreate() { }

	[CompilerGenerated]
	public PartyData get_PartyData() { }

	[CompilerGenerated]
	public PartyDataSend get_PartyDataSend() { }

	[CompilerGenerated]
	public PartyJoin get_PartyJoin() { }

	[CompilerGenerated]
	public PartyJoinRequest get_PartyJoinRequest() { }

	[CompilerGenerated]
	public PartyJoinRequestList get_PartyJoinRequestList() { }

	[CompilerGenerated]
	public PartyLeader get_PartyLeader() { }

	[CompilerGenerated]
	public PartyLeave get_PartyLeave() { }

	[CompilerGenerated]
	public PartyMatchmakerAdd get_PartyMatchmakerAdd() { }

	[CompilerGenerated]
	public PartyMatchmakerRemove get_PartyMatchmakerRemove() { }

	[CompilerGenerated]
	public PartyMatchmakerTicket get_PartyMatchmakerTicket() { }

	[CompilerGenerated]
	public PartyMemberRemove get_PartyMemberRemove() { }

	[CompilerGenerated]
	public PartyPresenceEvent get_PartyPresenceEvent() { }

	[CompilerGenerated]
	public PartyPromote get_PartyPromote() { }

	[CompilerGenerated]
	public ApiRpc get_Rpc() { }

	[CompilerGenerated]
	public Status get_Status() { }

	[CompilerGenerated]
	public StatusFollowMessage get_StatusFollow() { }

	[CompilerGenerated]
	public StatusPresenceEvent get_StatusPresenceEvent() { }

	[CompilerGenerated]
	public StatusUnfollowMessage get_StatusUnfollow() { }

	[CompilerGenerated]
	public StatusUpdateMessage get_StatusUpdate() { }

	[CompilerGenerated]
	public StreamPresenceEvent get_StreamPresenceEvent() { }

	[CompilerGenerated]
	public StreamState get_StreamState() { }

	[CompilerGenerated]
	public void set_Channel(Channel value) { }

	[CompilerGenerated]
	public void set_ChannelJoin(ChannelJoinMessage value) { }

	[CompilerGenerated]
	public void set_ChannelLeave(ChannelLeaveMessage value) { }

	[CompilerGenerated]
	public void set_ChannelMessage(ApiChannelMessage value) { }

	[CompilerGenerated]
	public void set_ChannelMessageAck(ChannelMessageAck value) { }

	[CompilerGenerated]
	public void set_ChannelMessageRemove(ChannelRemoveMessage value) { }

	[CompilerGenerated]
	public void set_ChannelMessageSend(ChannelSendMessage value) { }

	[CompilerGenerated]
	public void set_ChannelMessageUpdate(ChannelUpdateMessage value) { }

	[CompilerGenerated]
	public void set_ChannelPresenceEvent(ChannelPresenceEvent value) { }

	[CompilerGenerated]
	public void set_Cid(string value) { }

	[CompilerGenerated]
	public void set_Error(WebSocketErrorMessage value) { }

	[CompilerGenerated]
	public void set_Match(Match value) { }

	[CompilerGenerated]
	public void set_MatchCreate(MatchCreateMessage value) { }

	[CompilerGenerated]
	public void set_MatchJoin(MatchJoinMessage value) { }

	[CompilerGenerated]
	public void set_MatchLeave(MatchLeaveMessage value) { }

	[CompilerGenerated]
	public void set_MatchmakerAdd(MatchmakerAddMessage value) { }

	[CompilerGenerated]
	public void set_MatchmakerMatched(MatchmakerMatched value) { }

	[CompilerGenerated]
	public void set_MatchmakerRemove(MatchmakerRemoveMessage value) { }

	[CompilerGenerated]
	public void set_MatchmakerTicket(MatchmakerTicket value) { }

	[CompilerGenerated]
	public void set_MatchPresenceEvent(MatchPresenceEvent value) { }

	[CompilerGenerated]
	public void set_MatchState(MatchState value) { }

	[CompilerGenerated]
	public void set_MatchStateSend(MatchSendMessage value) { }

	[CompilerGenerated]
	public void set_NotificationList(ApiNotificationList value) { }

	[CompilerGenerated]
	public void set_Party(Party value) { }

	[CompilerGenerated]
	public void set_PartyAccept(PartyAccept value) { }

	[CompilerGenerated]
	public void set_PartyClose(PartyClose value) { }

	[CompilerGenerated]
	public void set_PartyCreate(PartyCreate value) { }

	[CompilerGenerated]
	public void set_PartyData(PartyData value) { }

	[CompilerGenerated]
	public void set_PartyDataSend(PartyDataSend value) { }

	[CompilerGenerated]
	public void set_PartyJoin(PartyJoin value) { }

	[CompilerGenerated]
	public void set_PartyJoinRequest(PartyJoinRequest value) { }

	[CompilerGenerated]
	public void set_PartyJoinRequestList(PartyJoinRequestList value) { }

	[CompilerGenerated]
	public void set_PartyLeader(PartyLeader value) { }

	[CompilerGenerated]
	public void set_PartyLeave(PartyLeave value) { }

	[CompilerGenerated]
	public void set_PartyMatchmakerAdd(PartyMatchmakerAdd value) { }

	[CompilerGenerated]
	public void set_PartyMatchmakerRemove(PartyMatchmakerRemove value) { }

	[CompilerGenerated]
	public void set_PartyMatchmakerTicket(PartyMatchmakerTicket value) { }

	[CompilerGenerated]
	public void set_PartyMemberRemove(PartyMemberRemove value) { }

	[CompilerGenerated]
	public void set_PartyPresenceEvent(PartyPresenceEvent value) { }

	[CompilerGenerated]
	public void set_PartyPromote(PartyPromote value) { }

	[CompilerGenerated]
	public void set_Rpc(ApiRpc value) { }

	[CompilerGenerated]
	public void set_Status(Status value) { }

	[CompilerGenerated]
	public void set_StatusFollow(StatusFollowMessage value) { }

	[CompilerGenerated]
	public void set_StatusPresenceEvent(StatusPresenceEvent value) { }

	[CompilerGenerated]
	public void set_StatusUnfollow(StatusUnfollowMessage value) { }

	[CompilerGenerated]
	public void set_StatusUpdate(StatusUpdateMessage value) { }

	[CompilerGenerated]
	public void set_StreamPresenceEvent(StreamPresenceEvent value) { }

	[CompilerGenerated]
	public void set_StreamState(StreamState value) { }

	public virtual string ToString() { }

}

