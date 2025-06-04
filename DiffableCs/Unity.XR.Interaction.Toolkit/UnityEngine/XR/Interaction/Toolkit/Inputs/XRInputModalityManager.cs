namespace UnityEngine.XR.Interaction.Toolkit.Inputs;

[AddComponentMenu("XR/XR Input Modality Manager", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Inputs.XRInputModalityManager.html")]
public class XRInputModalityManager : MonoBehaviour
{
	private class InputDeviceMonitor
	{
		[CompilerGenerated]
		private Action<InputDevice> trackingAcquired; //Field offset: 0x10
		private readonly List<InputDevice> m_MonitoredDevices; //Field offset: 0x18
		private bool m_Subscribed; //Field offset: 0x20

		public event Action<InputDevice> trackingAcquired
		{
			[CompilerGenerated]
			 add { } //Length: 176
			[CompilerGenerated]
			 remove { } //Length: 176
		}

		public InputDeviceMonitor() { }

		[CompilerGenerated]
		public void add_trackingAcquired(Action<InputDevice> value) { }

		public void AddDevice(InputDevice device) { }

		public void ClearAllDevices() { }

		private void OnTrackingAcquired(XRNodeState nodeState) { }

		[CompilerGenerated]
		public void remove_trackingAcquired(Action<InputDevice> value) { }

		public void RemoveDevice(InputDevice device) { }

		private void Subscribe() { }

		private void Unsubscribe() { }

	}

	internal enum InputMode
	{
		None = 0,
		TrackedHand = 1,
		MotionController = 2,
	}

	private class TrackedDeviceMonitor
	{
		[CompilerGenerated]
		private Action<TrackedDevice> trackingAcquired; //Field offset: 0x10
		private readonly List<Int32> m_MonitoredDevices; //Field offset: 0x18
		private bool m_Subscribed; //Field offset: 0x20

		public event Action<TrackedDevice> trackingAcquired
		{
			[CompilerGenerated]
			 add { } //Length: 176
			[CompilerGenerated]
			 remove { } //Length: 176
		}

		public TrackedDeviceMonitor() { }

		[CompilerGenerated]
		public void add_trackingAcquired(Action<TrackedDevice> value) { }

		public void AddDevice(TrackedDevice device) { }

		public void ClearAllDevices() { }

		private void OnAfterInputUpdate() { }

		[CompilerGenerated]
		public void remove_trackingAcquired(Action<TrackedDevice> value) { }

		public void RemoveDevice(TrackedDevice device) { }

		private void Subscribe() { }

		private void Unsubscribe() { }

	}

	private static BindableEnum<InputMode> s_CurrentInputMode; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	[Tooltip("GameObject representing the left hand group of interactors. Will toggle on when using hand tracking and off when using motion controllers.")]
	private GameObject m_LeftHand; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	[Tooltip("GameObject representing the right hand group of interactors. Will toggle on when using hand tracking and off when using motion controllers.")]
	private GameObject m_RightHand; //Field offset: 0x28
	[Header("Motion Controllers")]
	[SerializeField]
	[Tooltip("GameObject representing the left motion controller group of interactors. Will toggle on when using motion controllers and off when using hand tracking.")]
	private GameObject m_LeftController; //Field offset: 0x30
	[SerializeField]
	[Tooltip("GameObject representing the left motion controller group of interactors. Will toggle on when using motion controllers and off when using hand tracking.")]
	private GameObject m_RightController; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private UnityEvent m_TrackedHandModeStarted; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private UnityEvent m_TrackedHandModeEnded; //Field offset: 0x48
	[Header("Events")]
	[SerializeField]
	private UnityEvent m_MotionControllerModeStarted; //Field offset: 0x50
	[SerializeField]
	private UnityEvent m_MotionControllerModeEnded; //Field offset: 0x58
	private readonly TrackedDeviceMonitor m_TrackedDeviceMonitor; //Field offset: 0x60
	private readonly InputDeviceMonitor m_InputDeviceMonitor; //Field offset: 0x68
	private InputMode m_LeftInputMode; //Field offset: 0x70
	private InputMode m_RightInputMode; //Field offset: 0x74

	public static IReadOnlyBindableVariable<InputMode> currentInputMode
	{
		 get { } //Length: 88
	}

	public GameObject leftController
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject leftHand
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UnityEvent motionControllerModeEnded
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UnityEvent motionControllerModeStarted
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject rightController
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject rightHand
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UnityEvent trackedHandModeEnded
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UnityEvent trackedHandModeStarted
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static XRInputModalityManager() { }

	public XRInputModalityManager() { }

	public static IReadOnlyBindableVariable<InputMode> get_currentInputMode() { }

	public GameObject get_leftController() { }

	public GameObject get_leftHand() { }

	public UnityEvent get_motionControllerModeEnded() { }

	public UnityEvent get_motionControllerModeStarted() { }

	public GameObject get_rightController() { }

	public GameObject get_rightHand() { }

	public UnityEvent get_trackedHandModeEnded() { }

	public UnityEvent get_trackedHandModeStarted() { }

	private bool GetLeftHandIsTracked() { }

	private bool GetRightHandIsTracked() { }

	private void LogMissingHandSubsystem() { }

	private void OnControllerTrackingAcquired(TrackedDevice device) { }

	private void OnControllerTrackingAcquired(InputDevice device) { }

	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	private void OnDeviceConfigChanged(InputDevice device) { }

	private void OnDeviceConnected(InputDevice device) { }

	private void OnDeviceDisconnected(InputDevice device) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnModeChanged(InputMode oldInputMode, InputMode newInputMode, InputMode otherHandInputMode) { }

	private static void SafeSetActive(GameObject gameObject, bool active) { }

	public void set_leftController(GameObject value) { }

	public void set_leftHand(GameObject value) { }

	public void set_motionControllerModeEnded(UnityEvent value) { }

	public void set_motionControllerModeStarted(UnityEvent value) { }

	public void set_rightController(GameObject value) { }

	public void set_rightHand(GameObject value) { }

	public void set_trackedHandModeEnded(UnityEvent value) { }

	public void set_trackedHandModeStarted(UnityEvent value) { }

	private void SetLeftMode(InputMode inputMode) { }

	private void SetRightMode(InputMode inputMode) { }

	private void SubscribeHandSubsystem() { }

	private void UnsubscribeHandSubsystem() { }

	protected void Update() { }

	private void UpdateLeftMode() { }

	private void UpdateMode(XRController controllerDevice, Action<InputMode> setModeMethod) { }

	private void UpdateMode(InputDevice controllerDevice, Action<InputMode> setModeMethod) { }

	private void UpdateRightMode() { }

}

