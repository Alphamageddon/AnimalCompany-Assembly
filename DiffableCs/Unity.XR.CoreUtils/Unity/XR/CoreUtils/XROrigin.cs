namespace Unity.XR.CoreUtils;

[AddComponentMenu("XR/XR Origin")]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.core-utils@2.0/api/Unity.XR.CoreUtils.XROrigin.html")]
public class XROrigin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RepeatInitializeCamera>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XROrigin <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <RepeatInitializeCamera>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum TrackingOriginMode
	{
		NotSpecified = 0,
		Device = 1,
		Floor = 2,
	}

	private const float k_DefaultCameraYOffset = 1.1176; //Field offset: 0x0
	private static readonly List<XRInputSubsystem> s_InputSubsystems; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The Camera to associate with the XR device.")]
	private Camera m_Camera; //Field offset: 0x20
	[CompilerGenerated]
	private Transform <TrackablesParent>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action<ARTrackablesParentTransformChangedEventArgs> TrackablesParentTransformChanged; //Field offset: 0x30
	[FormerlySerializedAs("m_RigBaseGameObject")]
	[SerializeField]
	private GameObject m_OriginBaseGameObject; //Field offset: 0x38
	[SerializeField]
	private GameObject m_CameraFloorOffsetObject; //Field offset: 0x40
	[SerializeField]
	private TrackingOriginMode m_RequestedTrackingOriginMode; //Field offset: 0x48
	[SerializeField]
	private float m_CameraYOffset; //Field offset: 0x4C
	[CompilerGenerated]
	private TrackingOriginModeFlags <CurrentTrackingOriginMode>k__BackingField; //Field offset: 0x50
	private bool m_CameraInitialized; //Field offset: 0x54
	private bool m_CameraInitializing; //Field offset: 0x55

	public event Action<ARTrackablesParentTransformChangedEventArgs> TrackablesParentTransformChanged
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public Camera Camera
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GameObject CameraFloorOffsetObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float CameraInOriginSpaceHeight
	{
		 get { } //Length: 20
	}

	public Vector3 CameraInOriginSpacePos
	{
		 get { } //Length: 84
	}

	public float CameraYOffset
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private TrackingOriginModeFlags CurrentTrackingOriginMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GameObject Origin
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Vector3 OriginInCameraSpacePos
	{
		 get { } //Length: 84
	}

	public TrackingOriginMode RequestedTrackingOriginMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public private Transform TrackablesParent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static XROrigin() { }

	public XROrigin() { }

	[CompilerGenerated]
	private bool <OnValidate>g__IsModeStale|60_0() { }

	[CompilerGenerated]
	public void add_TrackablesParentTransformChanged(Action<ARTrackablesParentTransformChangedEventArgs> value) { }

	protected void Awake() { }

	public Camera get_Camera() { }

	public GameObject get_CameraFloorOffsetObject() { }

	public float get_CameraInOriginSpaceHeight() { }

	public Vector3 get_CameraInOriginSpacePos() { }

	public float get_CameraYOffset() { }

	[CompilerGenerated]
	public TrackingOriginModeFlags get_CurrentTrackingOriginMode() { }

	public GameObject get_Origin() { }

	public Vector3 get_OriginInCameraSpacePos() { }

	public TrackingOriginMode get_RequestedTrackingOriginMode() { }

	[CompilerGenerated]
	public Transform get_TrackablesParent() { }

	private Pose GetCameraOriginPose() { }

	public bool MatchOriginUp(Vector3 destinationUp) { }

	public bool MatchOriginUpCameraForward(Vector3 destinationUp, Vector3 destinationForward) { }

	public bool MatchOriginUpOriginForward(Vector3 destinationUp, Vector3 destinationForward) { }

	public bool MoveCameraToWorldLocation(Vector3 desiredWorldLocation) { }

	private void MoveOffsetHeight() { }

	private void MoveOffsetHeight(float y) { }

	private void OnBeforeRender() { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnInputSubsystemTrackingOriginUpdated(XRInputSubsystem inputSubsystem) { }

	protected void OnValidate() { }

	[CompilerGenerated]
	public void remove_TrackablesParentTransformChanged(Action<ARTrackablesParentTransformChangedEventArgs> value) { }

	[IteratorStateMachine(typeof(<RepeatInitializeCamera>d__48))]
	private IEnumerator RepeatInitializeCamera() { }

	public bool RotateAroundCameraPosition(Vector3 vector, float angleDegrees) { }

	public bool RotateAroundCameraUsingOriginUp(float angleDegrees) { }

	public void set_Camera(Camera value) { }

	public void set_CameraFloorOffsetObject(GameObject value) { }

	public void set_CameraYOffset(float value) { }

	[CompilerGenerated]
	private void set_CurrentTrackingOriginMode(TrackingOriginModeFlags value) { }

	public void set_Origin(GameObject value) { }

	public void set_RequestedTrackingOriginMode(TrackingOriginMode value) { }

	[CompilerGenerated]
	private void set_TrackablesParent(Transform value) { }

	private bool SetupCamera(XRInputSubsystem inputSubsystem) { }

	private bool SetupCamera() { }

	protected void Start() { }

	private void TryInitializeCamera() { }

}

