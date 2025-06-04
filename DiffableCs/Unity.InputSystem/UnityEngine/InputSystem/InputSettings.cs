namespace UnityEngine.InputSystem;

public class InputSettings : ScriptableObject
{
	internal enum BackgroundBehavior
	{
		ResetAndDisableNonBackgroundDevices = 0,
		ResetAndDisableAllDevices = 1,
		IgnoreFocus = 2,
	}

	internal enum EditorInputBehaviorInPlayMode
	{
		PointersAndKeyboardsRespectGameViewFocus = 0,
		AllDevicesRespectGameViewFocus = 1,
		AllDeviceInputAlwaysGoesToGameView = 2,
	}

	internal enum UpdateMode
	{
		ProcessEventsInDynamicUpdate = 1,
		ProcessEventsInFixedUpdate = 2,
		ProcessEventsManually = 3,
	}

	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0; //Field offset: 0x0
	internal static bool optimizedControlsFeatureEnabled; //Field offset: 0x0
	internal static bool readValueCachingFeatureEnabled; //Field offset: 0x1
	internal static bool paranoidReadValueCachingChecksEnabled; //Field offset: 0x2
	[SerializeField]
	[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
	private String[] m_SupportedDevices; //Field offset: 0x18
	[SerializeField]
	[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
	private UpdateMode m_UpdateMode; //Field offset: 0x20
	[SerializeField]
	private int m_MaxEventBytesPerUpdate; //Field offset: 0x24
	[SerializeField]
	private int m_MaxQueuedEventsPerUpdate; //Field offset: 0x28
	[SerializeField]
	private bool m_CompensateForScreenOrientation; //Field offset: 0x2C
	[SerializeField]
	private BackgroundBehavior m_BackgroundBehavior; //Field offset: 0x30
	[SerializeField]
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; //Field offset: 0x34
	[SerializeField]
	private float m_DefaultDeadzoneMin; //Field offset: 0x38
	[SerializeField]
	private float m_DefaultDeadzoneMax; //Field offset: 0x3C
	[Min(0.0001)]
	[SerializeField]
	private float m_DefaultButtonPressPoint; //Field offset: 0x40
	[SerializeField]
	private float m_ButtonReleaseThreshold; //Field offset: 0x44
	[SerializeField]
	private float m_DefaultTapTime; //Field offset: 0x48
	[SerializeField]
	private float m_DefaultSlowTapTime; //Field offset: 0x4C
	[SerializeField]
	private float m_DefaultHoldTime; //Field offset: 0x50
	[SerializeField]
	private float m_TapRadius; //Field offset: 0x54
	[SerializeField]
	private float m_MultiTapDelayTime; //Field offset: 0x58
	[SerializeField]
	private bool m_DisableRedundantEventsMerging; //Field offset: 0x5C
	[SerializeField]
	private bool m_ShortcutKeysConsumeInputs; //Field offset: 0x5D
	internal HashSet<String> m_FeatureFlags; //Field offset: 0x60

	public BackgroundBehavior backgroundBehavior
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float buttonReleaseThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public bool compensateForScreenOrientation
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public float defaultButtonPressPoint
	{
		 get { } //Length: 8
		 set { } //Length: 52
	}

	public float defaultDeadzoneMax
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float defaultDeadzoneMin
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float defaultHoldTime
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float defaultSlowTapTime
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float defaultTapTime
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public bool disableRedundantEventsMerging
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", False)]
	public bool filterNoiseOnCurrent
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public int maxEventBytesPerUpdate
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public int maxQueuedEventsPerUpdate
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public float multiTapDelayTime
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public bool shortcutKeysConsumeInput
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public ReadOnlyArray<String> supportedDevices
	{
		 get { } //Length: 96
		 set { } //Length: 292
	}

	public float tapRadius
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public UpdateMode updateMode
	{
		 get { } //Length: 8
		 set { } //Length: 24
	}

	public InputSettings() { }

	public BackgroundBehavior get_backgroundBehavior() { }

	public float get_buttonReleaseThreshold() { }

	public bool get_compensateForScreenOrientation() { }

	public float get_defaultButtonPressPoint() { }

	public float get_defaultDeadzoneMax() { }

	public float get_defaultDeadzoneMin() { }

	public float get_defaultHoldTime() { }

	public float get_defaultSlowTapTime() { }

	public float get_defaultTapTime() { }

	public bool get_disableRedundantEventsMerging() { }

	public EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	public bool get_filterNoiseOnCurrent() { }

	public int get_maxEventBytesPerUpdate() { }

	public int get_maxQueuedEventsPerUpdate() { }

	public float get_multiTapDelayTime() { }

	public bool get_shortcutKeysConsumeInput() { }

	public ReadOnlyArray<String> get_supportedDevices() { }

	public float get_tapRadius() { }

	public UpdateMode get_updateMode() { }

	internal bool IsFeatureEnabled(string featureName) { }

	internal void OnChange() { }

	public void set_backgroundBehavior(BackgroundBehavior value) { }

	public void set_buttonReleaseThreshold(float value) { }

	public void set_compensateForScreenOrientation(bool value) { }

	public void set_defaultButtonPressPoint(float value) { }

	public void set_defaultDeadzoneMax(float value) { }

	public void set_defaultDeadzoneMin(float value) { }

	public void set_defaultHoldTime(float value) { }

	public void set_defaultSlowTapTime(float value) { }

	public void set_defaultTapTime(float value) { }

	public void set_disableRedundantEventsMerging(bool value) { }

	public void set_editorInputBehaviorInPlayMode(EditorInputBehaviorInPlayMode value) { }

	public void set_filterNoiseOnCurrent(bool value) { }

	public void set_maxEventBytesPerUpdate(int value) { }

	public void set_maxQueuedEventsPerUpdate(int value) { }

	public void set_multiTapDelayTime(float value) { }

	public void set_shortcutKeysConsumeInput(bool value) { }

	public void set_supportedDevices(ReadOnlyArray<String> value) { }

	public void set_tapRadius(float value) { }

	public void set_updateMode(UpdateMode value) { }

	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

}

