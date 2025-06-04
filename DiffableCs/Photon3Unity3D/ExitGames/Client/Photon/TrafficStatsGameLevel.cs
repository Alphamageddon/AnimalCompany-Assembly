namespace ExitGames.Client.Photon;

public class TrafficStatsGameLevel
{
	private Stopwatch watch; //Field offset: 0x10
	private int timeOfLastDispatchCall; //Field offset: 0x18
	private int timeOfLastSendCall; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <OperationByteCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <OperationCount>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ResultByteCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ResultCount>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <EventByteCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <EventCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestOpResponseCallback>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private byte <LongestOpResponseCallbackOpCode>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestEventCallback>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestMessageCallback>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestRawMessageCallback>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private byte <LongestEventCallbackCode>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestDeltaBetweenDispatching>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LongestDeltaBetweenSending>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <DispatchIncomingCommandsCalls>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <SendOutgoingCommandsCalls>k__BackingField; //Field offset: 0x5C

	[Obsolete("Use DispatchIncomingCommandsCalls, which has proper naming.")]
	public int DispatchCalls
	{
		 get { } //Length: 8
	}

	public int DispatchIncomingCommandsCalls
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int EventByteCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int EventCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestDeltaBetweenDispatching
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestDeltaBetweenSending
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestEventCallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public byte LongestEventCallbackCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestMessageCallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestOpResponseCallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public byte LongestOpResponseCallbackOpCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int LongestRawMessageCallback
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int OperationByteCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int OperationCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int ResultByteCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int ResultCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int SendOutgoingCommandsCalls
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int TotalByteCount
	{
		 get { } //Length: 24
	}

	public int TotalIncomingByteCount
	{
		 get { } //Length: 16
	}

	public int TotalIncomingMessageCount
	{
		 get { } //Length: 16
	}

	public int TotalMessageCount
	{
		 get { } //Length: 24
	}

	public int TotalOutgoingByteCount
	{
		 get { } //Length: 8
	}

	public int TotalOutgoingMessageCount
	{
		 get { } //Length: 8
	}

	internal TrafficStatsGameLevel(Stopwatch sw) { }

	internal void CountEvent(int eventBytes) { }

	internal void CountOperation(int operationBytes) { }

	internal void CountResult(int resultBytes) { }

	internal void DispatchIncomingCommandsCalled() { }

	public int get_DispatchCalls() { }

	[CompilerGenerated]
	public int get_DispatchIncomingCommandsCalls() { }

	[CompilerGenerated]
	public int get_EventByteCount() { }

	[CompilerGenerated]
	public int get_EventCount() { }

	[CompilerGenerated]
	public int get_LongestDeltaBetweenDispatching() { }

	[CompilerGenerated]
	public int get_LongestDeltaBetweenSending() { }

	[CompilerGenerated]
	public int get_LongestEventCallback() { }

	[CompilerGenerated]
	public byte get_LongestEventCallbackCode() { }

	[CompilerGenerated]
	public int get_LongestMessageCallback() { }

	[CompilerGenerated]
	public int get_LongestOpResponseCallback() { }

	[CompilerGenerated]
	public byte get_LongestOpResponseCallbackOpCode() { }

	[CompilerGenerated]
	public int get_LongestRawMessageCallback() { }

	[CompilerGenerated]
	public int get_OperationByteCount() { }

	[CompilerGenerated]
	public int get_OperationCount() { }

	[CompilerGenerated]
	public int get_ResultByteCount() { }

	[CompilerGenerated]
	public int get_ResultCount() { }

	[CompilerGenerated]
	public int get_SendOutgoingCommandsCalls() { }

	public int get_TotalByteCount() { }

	public int get_TotalIncomingByteCount() { }

	public int get_TotalIncomingMessageCount() { }

	public int get_TotalMessageCount() { }

	public int get_TotalOutgoingByteCount() { }

	public int get_TotalOutgoingMessageCount() { }

	public void ResetMaximumCounters() { }

	internal void SendOutgoingCommandsCalled() { }

	[CompilerGenerated]
	public void set_DispatchIncomingCommandsCalls(int value) { }

	[CompilerGenerated]
	public void set_EventByteCount(int value) { }

	[CompilerGenerated]
	public void set_EventCount(int value) { }

	[CompilerGenerated]
	public void set_LongestDeltaBetweenDispatching(int value) { }

	[CompilerGenerated]
	public void set_LongestDeltaBetweenSending(int value) { }

	[CompilerGenerated]
	public void set_LongestEventCallback(int value) { }

	[CompilerGenerated]
	public void set_LongestEventCallbackCode(byte value) { }

	[CompilerGenerated]
	public void set_LongestMessageCallback(int value) { }

	[CompilerGenerated]
	public void set_LongestOpResponseCallback(int value) { }

	[CompilerGenerated]
	public void set_LongestOpResponseCallbackOpCode(byte value) { }

	[CompilerGenerated]
	public void set_LongestRawMessageCallback(int value) { }

	[CompilerGenerated]
	public void set_OperationByteCount(int value) { }

	[CompilerGenerated]
	public void set_OperationCount(int value) { }

	[CompilerGenerated]
	public void set_ResultByteCount(int value) { }

	[CompilerGenerated]
	public void set_ResultCount(int value) { }

	[CompilerGenerated]
	public void set_SendOutgoingCommandsCalls(int value) { }

	internal void TimeForEventCallback(byte code, int time) { }

	internal void TimeForMessageCallback(int time) { }

	internal void TimeForRawMessageCallback(int time) { }

	internal void TimeForResponseCallback(byte code, int time) { }

	public virtual string ToString() { }

	public string ToStringVitalStats() { }

}

