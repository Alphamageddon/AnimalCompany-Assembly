namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Character Controller Driver", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.CharacterControllerDriver.html")]
public class CharacterControllerDriver : MonoBehaviour
{
	[SerializeField]
	[Tooltip("The Locomotion Provider object to listen to.")]
	private LocomotionProvider m_LocomotionProvider; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The minimum height of the character's capsule that will be set by this behavior.")]
	private float m_MinHeight; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The maximum height of the character's capsule that will be set by this behavior.")]
	private float m_MaxHeight; //Field offset: 0x2C
	private XROrigin m_XROrigin; //Field offset: 0x30
	private CharacterController m_CharacterController; //Field offset: 0x38

	protected CharacterController characterController
	{
		 get { } //Length: 8
	}

	public LocomotionProvider locomotionProvider
	{
		 get { } //Length: 8
		 set { } //Length: 76
	}

	public float maxHeight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float minHeight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected XROrigin xrOrigin
	{
		 get { } //Length: 8
	}

	[Obsolete("xrRig has been deprecated. Use xrOrigin instead.")]
	protected XRRig xrRig
	{
		 get { } //Length: 124
	}

	public CharacterControllerDriver() { }

	protected void Awake() { }

	protected CharacterController get_characterController() { }

	public LocomotionProvider get_locomotionProvider() { }

	public float get_maxHeight() { }

	public float get_minHeight() { }

	protected XROrigin get_xrOrigin() { }

	protected XRRig get_xrRig() { }

	private void OnBeginLocomotion(LocomotionSystem system) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnEndLocomotion(LocomotionSystem system) { }

	public void set_locomotionProvider(LocomotionProvider value) { }

	public void set_maxHeight(float value) { }

	public void set_minHeight(float value) { }

	private void SetupCharacterController() { }

	protected void Start() { }

	private void Subscribe(LocomotionProvider provider) { }

	private void Unsubscribe(LocomotionProvider provider) { }

	protected override void UpdateCharacterController() { }

}

