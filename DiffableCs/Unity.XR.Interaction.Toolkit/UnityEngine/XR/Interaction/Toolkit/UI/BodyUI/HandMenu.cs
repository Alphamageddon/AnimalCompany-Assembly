namespace UnityEngine.XR.Interaction.Toolkit.UI.BodyUI;

[AddComponentMenu("XR/Hand Menu", 22)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.UI.BodyUI.HandMenu.html")]
public class HandMenu : MonoBehaviour
{
	internal enum MenuHandedness
	{
		None = 0,
		Left = 1,
		Right = 2,
		Either = 3,
	}

	internal enum UpDirection
	{
		WorldUp = 0,
		TransformUp = 1,
		CameraUp = 2,
	}

	[SerializeField]
	[Tooltip("Child GameObject used to hold the hand menu UI. This is the transform that moves each frame.")]
	private GameObject m_HandMenuUIGameObject; //Field offset: 0x20
	[Header("Hand alignment")]
	[SerializeField]
	[Tooltip("Which hand should the menu anchor to. None will disable the hand menu. Either will try to follow the first hand to meet requirements.")]
	private MenuHandedness m_MenuHandedness; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Determines the up direction of the menu when the hand menu is looking at the camera.")]
	private UpDirection m_HandMenuUpDirection; //Field offset: 0x2C
	[Header("Palm anchor")]
	[SerializeField]
	[Tooltip("Anchor associated with the left palm pose for the hand.")]
	private Transform m_LeftPalmAnchor; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Anchor associated with the right palm pose for the hand.")]
	private Transform m_RightPalmAnchor; //Field offset: 0x38
	[Header("Position follow config.")]
	[SerializeField]
	[Tooltip("Minimum distance in meters from target before which tween starts.")]
	private float m_MinFollowDistance; //Field offset: 0x40
	[SerializeField]
	[Tooltip("Maximum distance in meters from target before tween targets, when time threshold is reached.")]
	private float m_MaxFollowDistance; //Field offset: 0x44
	[SerializeField]
	[Tooltip("Time required to elapse before the max distance allowed goes from the min distance to the max.")]
	private float m_MinToMaxDelaySeconds; //Field offset: 0x48
	[Header("Gaze Alignment Config")]
	[SerializeField]
	[Tooltip("If true, menu will hide when gaze to menu origin's divergence angle is above the threshold. In other words, the menu will only show if looking roughly in it's direction.")]
	private bool m_HideMenuWhenGazeDiverges; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Only show menu if gaze to menu origin's divergence angle is below this value.")]
	private float m_MenuVisibleGazeAngleDivergenceThreshold; //Field offset: 0x50
	private float m_MenuVisibilityDotThreshold; //Field offset: 0x54
	private readonly SmartFollowVector3TweenableVariable m_HandAnchorSmartFollow; //Field offset: 0x58
	private readonly QuaternionTweenableVariable m_RotTweenFollow; //Field offset: 0x60
	private readonly Vector3TweenableVariable m_MenuScaleTweenable; //Field offset: 0x68
	private readonly BindingsGroup m_BindingsGroup; //Field offset: 0x70
	private Transform m_CameraTransform; //Field offset: 0x78
	private bool m_WasMenuHiddenLastFrame; //Field offset: 0x80
	private MenuHandedness m_LastHandThatMetRequirements; //Field offset: 0x84
	[Header("Animation Settings")]
	[SerializeField]
	[Tooltip("Should the menu animate when it is revealed or hidden.")]
	private bool m_AnimateMenuHideAndReveal; //Field offset: 0x88
	[SerializeField]
	[Tooltip("Duration of the reveal/hide animation in seconds.")]
	private float m_RevealHideAnimationDuration; //Field offset: 0x8C
	[Header("Follow presets")]
	[SerializeField]
	private FollowPresetDatumProperty m_HandTrackingFollowPreset; //Field offset: 0x90
	[SerializeField]
	private FollowPresetDatumProperty m_ControllerFollowPreset; //Field offset: 0x98
	private InputMode m_CurrentInputMode; //Field offset: 0xA0
	private Transform m_LeftOffsetRoot; //Field offset: 0xA8
	private Transform m_RightOffsetRoot; //Field offset: 0xB0
	private Coroutine m_HideCoroutine; //Field offset: 0xB8
	private Coroutine m_ShowCoroutine; //Field offset: 0xC0
	private Transform m_LastValidCameraTransform; //Field offset: 0xC8
	private Transform m_LastValidPalmAnchor; //Field offset: 0xD0
	private Transform m_LastValidPalmAnchorOffset; //Field offset: 0xD8
	private Vector3 m_InitialMenuLocalScale; //Field offset: 0xE0
	private readonly BindableVariable<Boolean> m_MenuVisibleBindableVariable; //Field offset: 0xF0
	private float m_LastValidTrackingTime; //Field offset: 0xF8

	public bool animateMenuHideAndRevel
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GameObject handMenuUIGameObject
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public UpDirection handMenuUpDirection
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool hideMenuWhenGazeDiverges
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Transform leftPalmAnchor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maxFollowDistance
	{
		 get { } //Length: 8
		 set { } //Length: 36
	}

	public MenuHandedness menuHandedness
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float menuVisibleGazeDivergenceThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 40
	}

	public float minFollowDistance
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float minToMaxDelaySeconds
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float revealHideAnimationDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform rightPalmAnchor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public HandMenu() { }

	[CompilerGenerated]
	private void <OnEnable>b__72_0(float3 newPosition) { }

	[CompilerGenerated]
	private void <OnEnable>b__72_1(Quaternion newRot) { }

	[CompilerGenerated]
	private void <OnEnable>b__72_2(float3 value) { }

	[CompilerGenerated]
	private void <OnEnable>b__72_3(bool value) { }

	private static float AngleToDot(float angleDeg) { }

	protected void Awake() { }

	public bool get_animateMenuHideAndRevel() { }

	public GameObject get_handMenuUIGameObject() { }

	public UpDirection get_handMenuUpDirection() { }

	public bool get_hideMenuWhenGazeDiverges() { }

	public Transform get_leftPalmAnchor() { }

	public float get_maxFollowDistance() { }

	public MenuHandedness get_menuHandedness() { }

	public float get_menuVisibleGazeDivergenceThreshold() { }

	public float get_minFollowDistance() { }

	public float get_minToMaxDelaySeconds() { }

	public float get_revealHideAnimationDuration() { }

	public Transform get_rightPalmAnchor() { }

	private FollowPreset GetCurrentPreset() { }

	private Vector3 GetReferenceUpDirection(Transform cameraTransform) { }

	private void GetTransformAnchorsForHandedness(MenuHandedness handedness, out Transform palmAnchor, out Transform palmAnchorOffset) { }

	private void HideMenu() { }

	protected void LateUpdate() { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnInputModeChanged(InputMode newInputMode) { }

	private void OnMenuHidden() { }

	private void OnMenuVisible() { }

	protected void OnValidate() { }

	private bool PalmMeetsRequirements(Transform cameraTransform, Transform palmAnchor, bool isRightHand, in FollowPreset currentPresent) { }

	public void set_animateMenuHideAndRevel(bool value) { }

	public void set_handMenuUIGameObject(GameObject value) { }

	public void set_handMenuUpDirection(UpDirection value) { }

	public void set_hideMenuWhenGazeDiverges(bool value) { }

	public void set_leftPalmAnchor(Transform value) { }

	public void set_maxFollowDistance(float value) { }

	public void set_menuHandedness(MenuHandedness value) { }

	public void set_menuVisibleGazeDivergenceThreshold(float value) { }

	public void set_minFollowDistance(float value) { }

	public void set_minToMaxDelaySeconds(float value) { }

	public void set_revealHideAnimationDuration(float value) { }

	public void set_rightPalmAnchor(Transform value) { }

	private void ShowMenu() { }

	private bool TryGetCamera(out Transform cameraTransform) { }

	private bool TryGetTrackedAnchors(MenuHandedness desiredHandedness, in FollowPreset currentPreset, out MenuHandedness targetHandedness, out Transform cameraTransform, out Transform palmAnchor, out Transform palmAnchorOffset) { }

}

