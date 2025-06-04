namespace UnityEngine.XR.Interaction.Toolkit;

[CreateAssetMenu(menuName = "XR/XR Controller Recording")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRControllerRecording.html")]
[PreferBinarySerialization]
public class XRControllerRecording : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private bool m_SelectActivatedInFirstFrame; //Field offset: 0x18
	[SerializeField]
	private bool m_ActivateActivatedInFirstFrame; //Field offset: 0x19
	[SerializeField]
	private bool m_FirstUIPressActivatedInFirstFrame; //Field offset: 0x1A
	[SerializeField]
	private List<XRControllerState> m_Frames; //Field offset: 0x20

	public double duration
	{
		 get { } //Length: 124
	}

	public List<XRControllerState> frames
	{
		 get { } //Length: 8
	}

	public XRControllerRecording() { }

	public void AddRecordingFrame(XRControllerState state) { }

	[Obsolete("AddRecordingFrame has been deprecated. Use the overload method with the XRControllerState parameter or the method AddRecordingFrameNonAlloc.")]
	public void AddRecordingFrame(double time, Vector3 position, Quaternion rotation, bool selectActive, bool activateActive, bool pressActive) { }

	public void AddRecordingFrameNonAlloc(XRControllerState state) { }

	public double get_duration() { }

	public List<XRControllerState> get_frames() { }

	public void InitRecording() { }

	public void SaveRecording() { }

	internal void SetFrameDependentData() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

