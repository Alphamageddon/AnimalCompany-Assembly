namespace AnimalCompany;

public sealed class App : MonoBehaviour
{
	internal class ActionExecutionException : Exception
	{
		[CompilerGenerated]
		private bool <isDelayedExecution>k__BackingField; //Field offset: 0x8C

		public private bool isDelayedExecution
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public ActionExecutionException(string message, bool isDelayedExecution) { }

		[CompilerGenerated]
		public bool get_isDelayedExecution() { }

		[CompilerGenerated]
		private void set_isDelayedExecution(bool value) { }

	}

	private class FailedActionData
	{
		public BaseAction action; //Field offset: 0x10
		public Exception exception; //Field offset: 0x18

		public FailedActionData() { }

	}

	private const int MAX_ACTION_EXECUTION_LOG_LENGTH = 9000; //Field offset: 0x0
	[CompilerGenerated]
	private static AppState <state>k__BackingField; //Field offset: 0x0
	private static App _instance; //Field offset: 0x8
	private static IStateObservationContext _observationContext; //Field offset: 0x10
	private static bool _isCurrentlyExecutingAction; //Field offset: 0x18
	private static bool _isCurrentlyExecutingDelayedActions; //Field offset: 0x19
	private static bool _isCurrentlyNotifyingObservers; //Field offset: 0x1A
	private static List<BaseAction> _delayedActions; //Field offset: 0x20
	private static List<BaseAction> _delayedActionsBuffer; //Field offset: 0x28
	private static List<FailedActionData> _failedActionsData; //Field offset: 0x30
	private static int _delayActionCurrentDepth; //Field offset: 0x38
	private static ConcurrentQueue<BaseAction> _scheduledActions; //Field offset: 0x40
	private static List<BaseAction> _scheduledActionsBuffer; //Field offset: 0x48
	private static CommandScheduler _parallelCommands; //Field offset: 0x50
	private static ConcurrentQueue<Command> _scheduledCommands; //Field offset: 0x58
	private static Thread _mainThread; //Field offset: 0x60
	private static StringBuilder _actionLogStringBuilder; //Field offset: 0x68
	private static StringBuilder _logStringBuilder; //Field offset: 0x70

	public static AnimalCompanyAPI api
	{
		 get { } //Length: 136
	}

	public static ISession apiSession
	{
		 get { } //Length: 136
	}

	public static bool isCurrentlyNotifyingObservers
	{
		 get { } //Length: 88
	}

	public static AppPlatform platform
	{
		 get { } //Length: 168
	}

	public static IEnumerator<Command> runningCommands
	{
		 get { } //Length: 100
	}

	public private static AppState state
	{
		[CompilerGenerated]
		 get { } //Length: 88
		[CompilerGenerated]
		private set { } //Length: 92
	}

	private static App() { }

	public App() { }

	private void Awake() { }

	public static void DeregisterObserver(ObserverDelegate observer) { }

	private static void ExecuteAction(bool shouldLog, IList<BaseAction> actions, bool executeDelayedActions = true) { }

	public static void ExecuteAction(IList<BaseAction> actions) { }

	public static void ExecuteAction(BaseAction[] actions) { }

	public static void ExecuteActionOrDelay(BaseAction[] actions) { }

	public static void ExecuteActionOrDelay(IList<BaseAction> actions) { }

	public static void ExecuteActionSilently(BaseAction[] actions) { }

	public static void ExecuteActionSilently(IList<BaseAction> actions) { }

	public static CommandHandle ExecuteCommand(Command command, bool silent = false) { }

	public static void ExecuteDelayedActionsIfNecessary() { }

	private static void ExecuteScheduledActions() { }

	private static void ExecuteScheduledCommands() { }

	public static AnimalCompanyAPI get_api() { }

	public static ISession get_apiSession() { }

	public static bool get_isCurrentlyNotifyingObservers() { }

	public static AppPlatform get_platform() { }

	public static IEnumerator<Command> get_runningCommands() { }

	[CompilerGenerated]
	public static AppState get_state() { }

	private static string GetActionsDebugStr(IList<BaseAction> actions) { }

	private void OnDestroy() { }

	public static void RegisterKeyObserver(ObserverDelegate observer, object key, IStateDictionary[] dictionaries) { }

	public static void RegisterKeyObserverForChildren(ObserverDelegate observer, object key, IStateDictionary[] dictionaries) { }

	public static void RegisterKeyObserverForSelf(ObserverDelegate observer, object key, IStateDictionary[] dictionaries) { }

	public static void RegisterObserver(ObserverDelegate observer, IStateObject[] state) { }

	public static void RegisterObserverForChildren(ObserverDelegate observer, IStateObject[] state) { }

	public static void RegisterObserverForSelf(ObserverDelegate observer, IStateObject[] state) { }

	public static void ScheduleAction(BaseAction[] actions) { }

	public static CommandHandle ScheduleCommand(Command command, bool silent = false) { }

	[CompilerGenerated]
	private static void set_state(AppState value) { }

	private void Update() { }

}

