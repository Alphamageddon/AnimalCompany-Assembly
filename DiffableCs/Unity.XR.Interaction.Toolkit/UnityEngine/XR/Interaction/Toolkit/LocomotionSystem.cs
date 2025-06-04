namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Locomotion System", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.LocomotionSystem.html")]
public class LocomotionSystem : MonoBehaviour
{
	private LocomotionProvider m_CurrentExclusiveProvider; //Field offset: 0x20
	private float m_TimeMadeExclusive; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The timeout (in seconds) for exclusive access to the XR Origin.")]
	private float m_Timeout; //Field offset: 0x2C
	[FormerlySerializedAs("m_XRRig")]
	[SerializeField]
	[Tooltip("The XR Origin object to provide access control to.")]
	private XROrigin m_XROrigin; //Field offset: 0x30

	public bool busy
	{
		 get { } //Length: 96
	}

	[Obsolete("Busy has been deprecated. Use busy instead. (UnityUpgradable) -> busy")]
	public bool Busy
	{
		 get { } //Length: 4
	}

	public float timeout
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XROrigin xrOrigin
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("xrRig is marked for deprecation and will be removed in a future version. Please use xrOrigin instead.")]
	public XRRig xrRig
	{
		 get { } //Length: 124
		 set { } //Length: 8
	}

	public LocomotionSystem() { }

	protected void Awake() { }

	public RequestResult FinishExclusiveOperation(LocomotionProvider provider) { }

	public bool get_busy() { }

	public bool get_Busy() { }

	public float get_timeout() { }

	public XROrigin get_xrOrigin() { }

	public XRRig get_xrRig() { }

	public RequestResult RequestExclusiveOperation(LocomotionProvider provider) { }

	private void ResetExclusivity() { }

	public void set_timeout(float value) { }

	public void set_xrOrigin(XROrigin value) { }

	public void set_xrRig(XRRig value) { }

	protected void Update() { }

}

