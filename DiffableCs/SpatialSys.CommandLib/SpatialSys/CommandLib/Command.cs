namespace SpatialSys.CommandLib;

public abstract class Command
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Command, Boolean> <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Abort>b__45_0(Command c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public AsyncOperation asyncOperation; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal bool <op_Implicit>b__0(float elapsedTime) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public CommandHandle commandHandle; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <op_Implicit>b__0(float elapsedTime) { }

	}

	[CompilerGenerated]
	private sealed class <get__childCommands>d__37 : IEnumerable<Command>, IEnumerable, IEnumerator<Command>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Command <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get__childCommands>d__37(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Command> System.Collections.Generic.IEnumerable<SpatialSys.CommandLib.Command>.GetEnumerator() { }

		[DebuggerHidden]
		private override Command System.Collections.Generic.IEnumerator<SpatialSys.CommandLib.Command>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const LogLevel DEFAULT_LOG_LEVEL = 5; //Field offset: 0x0
	[CompilerGenerated]
	private CommandState <state>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <propagateAbortToParents>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Exception <abortException>k__BackingField; //Field offset: 0x18
	private LogLevel _minLogLevel; //Field offset: 0x20
	private string _identifier; //Field offset: 0x28
	internal Command _parentCommand; //Field offset: 0x30

	internal override IEnumerable<Command> _childCommands
	{
		[IteratorStateMachine(typeof(<get__childCommands>d__37))]
		internal get { } //Length: 104
	}

	public Exception abortException
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool hasFinalized
	{
		 get { } //Length: 104
	}

	public bool hasStarted
	{
		 get { } //Length: 16
	}

	public string identifier
	{
		 get { } //Length: 104
	}

	public bool isAborted
	{
		 get { } //Length: 32
	}

	public bool isCancelled
	{
		 get { } //Length: 32
	}

	public bool isDone
	{
		 get { } //Length: 16
	}

	public LogLevel minLogLevel
	{
		 get { } //Length: 60
		 set { } //Length: 8
	}

	protected Command parentCommand
	{
		 get { } //Length: 8
	}

	public bool propagateAbortToParents
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool silent
	{
		 get { } //Length: 24
		 set { } //Length: 44
	}

	public CommandState state
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected Command(string identifier = null, bool propagateAbortToParents = true) { }

	protected private void Abort(Exception exception) { }

	private void Abort(Command sourceCommand, Exception exception) { }

	public override void Cancel() { }

	protected override void Finally() { }

	[IteratorStateMachine(typeof(<get__childCommands>d__37))]
	internal override IEnumerable<Command> get__childCommands() { }

	[CompilerGenerated]
	public Exception get_abortException() { }

	public bool get_hasFinalized() { }

	public bool get_hasStarted() { }

	public string get_identifier() { }

	public bool get_isAborted() { }

	public bool get_isCancelled() { }

	public bool get_isDone() { }

	public LogLevel get_minLogLevel() { }

	protected Command get_parentCommand() { }

	[CompilerGenerated]
	public bool get_propagateAbortToParents() { }

	public bool get_silent() { }

	[CompilerGenerated]
	public CommandState get_state() { }

	private void InternalFinalize() { }

	protected void MarkDone() { }

	public static Command op_Implicit(CommandHandle commandHandle) { }

	public static Command op_Implicit(AsyncOperation asyncOperation) { }

	[CompilerGenerated]
	protected void set_abortException(Exception value) { }

	public void set_minLogLevel(LogLevel value) { }

	[CompilerGenerated]
	public void set_propagateAbortToParents(bool value) { }

	public void set_silent(bool value) { }

	[CompilerGenerated]
	protected void set_state(CommandState value) { }

	protected override void Start() { }

	public virtual string ToString() { }

	public bool Update(float deltaTime) { }

	protected abstract bool UpdateInternal(float deltaTime) { }

}

