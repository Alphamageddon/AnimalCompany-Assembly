namespace UnityEngine.InputSystem;

public static class InputSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InputEventPtr, InputControl> <>9__79_0; //Field offset: 0x8
		public static Func<InputControl, Boolean> <>9__79_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal InputControl <get_onAnyButtonPress>b__79_0(InputEventPtr e) { }

		internal bool <get_onAnyButtonPress>b__79_1(InputControl c) { }

	}

	private struct DeltaStateEventBuffer
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		public const int kMaxSize = 512; //Field offset: 0x0
		public DeltaStateEvent stateEvent; //Field offset: 0x0
		[FixedBuffer(typeof(byte, 511)]
		public <data>e__FixedBuffer data; //Field offset: 0x1D

	}

	private struct StateEventBuffer
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <data>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		public const int kMaxSize = 512; //Field offset: 0x0
		public StateEvent stateEvent; //Field offset: 0x0
		[FixedBuffer(typeof(byte, 511)]
		public <data>e__FixedBuffer data; //Field offset: 0x19

	}

	internal const string kAssemblyVersion = "1.7.0"; //Field offset: 0x0
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7"; //Field offset: 0x0
	internal static InputManager s_Manager; //Field offset: 0x0
	internal static InputRemoting s_Remote; //Field offset: 0x8

	public static event Action<Object, InputActionChange> onActionChange
	{
		 add { } //Length: 180
		 remove { } //Length: 180
	}

	public static event Action onAfterUpdate
	{
		 add { } //Length: 296
		 remove { } //Length: 296
	}

	public static event Action onBeforeUpdate
	{
		 add { } //Length: 296
		 remove { } //Length: 296
	}

	public static event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		 add { } //Length: 372
		 remove { } //Length: 372
	}

	public static event InputDeviceCommandDelegate onDeviceCommand
	{
		 add { } //Length: 372
		 remove { } //Length: 372
	}

	public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
	{
		 add { } //Length: 296
		 remove { } //Length: 296
	}

	public static event Action<String, InputControlLayoutChange> onLayoutChange
	{
		 add { } //Length: 296
		 remove { } //Length: 296
	}

	public static event Action onSettingsChange
	{
		 add { } //Length: 108
		 remove { } //Length: 108
	}

	public static ReadOnlyArray<InputDevice> devices
	{
		 get { } //Length: 100
	}

	public static ReadOnlyArray<InputDevice> disconnectedDevices
	{
		 get { } //Length: 156
	}

	internal static bool isProcessingEvents
	{
		internal get { } //Length: 100
	}

	public static InputMetrics metrics
	{
		 get { } //Length: 148
	}

	public static IObservable<InputControl> onAnyButtonPress
	{
		 get { } //Length: 516
	}

	public static InputEventListener onEvent
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public static float pollingFrequency
	{
		 get { } //Length: 100
		 set { } //Length: 116
	}

	public static InputRemoting remoting
	{
		 get { } //Length: 88
	}

	public static bool runInBackground
	{
		 get { } //Length: 212
		 set { } //Length: 220
	}

	public static InputSettings settings
	{
		 get { } //Length: 100
		 set { } //Length: 320
	}

	public static Version version
	{
		 get { } //Length: 108
	}

	private static InputSystem() { }

	public static void add_onActionChange(Action<Object, InputActionChange> value) { }

	public static void add_onAfterUpdate(Action value) { }

	public static void add_onBeforeUpdate(Action value) { }

	public static void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	public static void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	public static void add_onSettingsChange(Action value) { }

	public static void AddDevice(InputDevice device) { }

	public static InputDevice AddDevice(string layout, string name = null, string variants = null) { }

	public static TDevice AddDevice(string name = null) { }

	public static InputDevice AddDevice(InputDeviceDescription description) { }

	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	public static void AddDeviceUsage(InputDevice device, string usage) { }

	public static void DisableAllEnabledActions() { }

	public static void DisableDevice(InputDevice device, bool keepSendingEvents = false) { }

	public static void EnableDevice(InputDevice device) { }

	internal static void EnsureInitialized() { }

	public static InputControl FindControl(string path) { }

	public static int FindControls(string path, ref InputControlList<TControl>& controls) { }

	public static InputControlList<TControl> FindControls(string path) { }

	public static InputControlList<InputControl> FindControls(string path) { }

	public static void FlushDisconnectedDevices() { }

	public static ReadOnlyArray<InputDevice> get_devices() { }

	public static ReadOnlyArray<InputDevice> get_disconnectedDevices() { }

	internal static bool get_isProcessingEvents() { }

	public static InputMetrics get_metrics() { }

	public static IObservable<InputControl> get_onAnyButtonPress() { }

	public static InputEventListener get_onEvent() { }

	public static float get_pollingFrequency() { }

	public static InputRemoting get_remoting() { }

	public static bool get_runInBackground() { }

	public static InputSettings get_settings() { }

	public static Version get_version() { }

	public static TDevice GetDevice(InternedString usage) { }

	public static InputDevice GetDevice(Type type) { }

	public static TDevice GetDevice() { }

	public static TDevice GetDevice(string usage) { }

	public static InputDevice GetDevice(string nameOrLayout) { }

	public static InputDevice GetDeviceById(int deviceId) { }

	public static string GetNameOfBaseLayout(string layoutName) { }

	public static List<InputDeviceDescription> GetUnsupportedDevices() { }

	public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null) { }

	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	public static List<InputAction> ListEnabledActions() { }

	public static int ListEnabledActions(List<InputAction> actions) { }

	public static IEnumerable<String> ListInteractions() { }

	public static IEnumerable<String> ListLayouts() { }

	public static IEnumerable<String> ListLayoutsBasedOn(string baseLayout) { }

	public static IEnumerable<String> ListProcessors() { }

	public static InputControlLayout LoadLayout() { }

	public static InputControlLayout LoadLayout(string name) { }

	public static void PauseHaptics() { }

	private static void PerformDefaultPluginInitialization() { }

	public static void QueueConfigChangeEvent(InputDevice device, double time = -1) { }

	public static void QueueDeltaStateEvent(InputControl control, TDelta delta, double time = -1) { }

	public static void QueueEvent(ref TEvent inputEvent) { }

	public static void QueueEvent(InputEventPtr eventPtr) { }

	public static void QueueStateEvent(InputDevice device, TState state, double time = -1) { }

	public static void QueueTextEvent(InputDevice device, char character, double time = -1) { }

	public static void RegisterBindingComposite(string name = null) { }

	public static void RegisterBindingComposite(Type type, string name) { }

	public static void RegisterInteraction(string name = null) { }

	public static void RegisterInteraction(Type type, string name = null) { }

	public static void RegisterLayout(string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	public static void RegisterLayout(string json, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	public static void RegisterLayout(Type type, string name = null, Nullable<InputDeviceMatcher> matches = null) { }

	public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, Nullable<InputDeviceMatcher> matches = null) { }

	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	public static void RegisterLayoutMatcher(InputDeviceMatcher matcher) { }

	public static void RegisterLayoutOverride(string json, string name = null) { }

	public static void RegisterPrecompiledLayout(string metadata) { }

	public static void RegisterProcessor(Type type, string name = null) { }

	public static void RegisterProcessor(string name = null) { }

	public static void remove_onActionChange(Action<Object, InputActionChange> value) { }

	public static void remove_onAfterUpdate(Action value) { }

	public static void remove_onBeforeUpdate(Action value) { }

	public static void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	public static void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	public static void remove_onSettingsChange(Action value) { }

	public static void RemoveDevice(InputDevice device) { }

	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	public static void RemoveLayout(string name) { }

	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false) { }

	public static void ResetHaptics() { }

	public static void ResumeHaptics() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void RunInitializeInPlayer() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void RunInitialUpdate() { }

	public static void set_onEvent(InputEventListener value) { }

	public static void set_pollingFrequency(float value) { }

	public static void set_runInBackground(bool value) { }

	public static void set_settings(InputSettings value) { }

	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	public static void SetDeviceUsage(InputDevice device, string usage) { }

	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	public static Type TryGetBindingComposite(string name) { }

	public static Type TryGetInteraction(string name) { }

	public static Type TryGetProcessor(string name) { }

	[Obsolete("Use 'ResetDevice' instead.", False)]
	public static bool TryResetDevice(InputDevice device) { }

	public static bool TrySyncDevice(InputDevice device) { }

	internal static void Update(InputUpdateType updateType) { }

	public static void Update() { }

}

