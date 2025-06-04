namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Debug/XR Controller Recorder", 11)]
[DefaultExecutionOrder(-30000)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRControllerRecorder.html")]
public class XRControllerRecorder : MonoBehaviour
{
	[Header("Input Recording/Playback")]
	[SerializeField]
	[Tooltip("Controls whether this recording will start playing when the component's Awake() method is called.")]
	private bool m_PlayOnStart; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Controller Recording asset for recording and playback of controller events.")]
	private XRControllerRecording m_Recording; //Field offset: 0x28
	[SerializeField]
	[Tooltip("XR Controller who's output will be recorded and played back")]
	private XRBaseController m_XRController; //Field offset: 0x30
	[SerializeField]
	[Tooltip("If true, every frame of the recording must be visited even if a larger time period has passed.")]
	private bool m_VisitEachFrame; //Field offset: 0x38
	private double m_CurrentTime; //Field offset: 0x40
	[CompilerGenerated]
	private float <recordingStartTime>k__BackingField; //Field offset: 0x48
	private bool m_IsRecording; //Field offset: 0x4C
	private bool m_IsPlaying; //Field offset: 0x4D
	private double m_LastPlaybackTime; //Field offset: 0x50
	private int m_LastFrameIdx; //Field offset: 0x58
	private bool m_PrevEnableInputActions; //Field offset: 0x5C
	private bool m_PrevEnableInputTracking; //Field offset: 0x5D

	public double currentTime
	{
		 get { } //Length: 8
	}

	public double duration
	{
		 get { } //Length: 132
	}

	public bool isPlaying
	{
		 get { } //Length: 8
		 set { } //Length: 300
	}

	public bool isRecording
	{
		 get { } //Length: 8
		 set { } //Length: 192
	}

	public bool playOnStart
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public XRControllerRecording recording
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected float recordingStartTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool visitEachFrame
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public XRBaseController xrController
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRControllerRecorder() { }

	protected void Awake() { }

	public double get_currentTime() { }

	public double get_duration() { }

	public bool get_isPlaying() { }

	public bool get_isRecording() { }

	public bool get_playOnStart() { }

	public XRControllerRecording get_recording() { }

	[CompilerGenerated]
	protected float get_recordingStartTime() { }

	public bool get_visitEachFrame() { }

	public XRBaseController get_xrController() { }

	public override bool GetControllerState(out XRControllerState controllerState) { }

	protected void OnDestroy() { }

	public void ResetPlayback() { }

	public void set_isPlaying(bool value) { }

	public void set_isRecording(bool value) { }

	public void set_playOnStart(bool value) { }

	public void set_recording(XRControllerRecording value) { }

	[CompilerGenerated]
	protected void set_recordingStartTime(float value) { }

	public void set_visitEachFrame(bool value) { }

	public void set_xrController(XRBaseController value) { }

	protected override void Update() { }

	private void UpdatePlaybackTime(double playbackTime) { }

}

