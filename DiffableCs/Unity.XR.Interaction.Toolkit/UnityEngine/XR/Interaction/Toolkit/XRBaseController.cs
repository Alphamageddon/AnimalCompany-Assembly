namespace UnityEngine.XR.Interaction.Toolkit;

[DefaultExecutionOrder(-29990)]
[DisallowMultipleComponent]
public abstract class XRBaseController : MonoBehaviour
{
	internal enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2,
		Fixed = 3,
	}

	[SerializeField]
	private UpdateType m_UpdateTrackingType; //Field offset: 0x20
	[SerializeField]
	private bool m_EnableInputTracking; //Field offset: 0x24
	[SerializeField]
	private bool m_EnableInputActions; //Field offset: 0x25
	[SerializeField]
	private Transform m_ModelPrefab; //Field offset: 0x28
	[FormerlySerializedAs("m_ModelTransform")]
	[SerializeField]
	private Transform m_ModelParent; //Field offset: 0x30
	[SerializeField]
	private Transform m_Model; //Field offset: 0x38
	[SerializeField]
	private bool m_AnimateModel; //Field offset: 0x40
	[SerializeField]
	private string m_ModelSelectTransition; //Field offset: 0x48
	[SerializeField]
	private string m_ModelDeSelectTransition; //Field offset: 0x50
	private bool m_HideControllerModel; //Field offset: 0x58
	private InteractionState m_SelectInteractionState; //Field offset: 0x5C
	private InteractionState m_ActivateInteractionState; //Field offset: 0x64
	private InteractionState m_UIPressInteractionState; //Field offset: 0x6C
	private Vector2 m_UIScrollValue; //Field offset: 0x74
	private XRControllerState m_ControllerState; //Field offset: 0x80
	private bool m_CreateControllerState; //Field offset: 0x88
	private Animator m_ModelAnimator; //Field offset: 0x90
	private bool m_HasWarnedAnimatorMissing; //Field offset: 0x98
	private bool m_PerformSetup; //Field offset: 0x99
	[CompilerGenerated]
	private float <anchorControlDeadzone>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private float <anchorControlOffAxisDeadzone>k__BackingField; //Field offset: 0xA0

	public InteractionState activateInteractionState
	{
		 get { } //Length: 8
	}

	[Obsolete("anchorControlDeadzone is obsolete. Please configure deadzone on the Rotate Anchor and Translate Anchor Actions.", True)]
	public float anchorControlDeadzone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Obsolete("anchorControlOffAxisDeadzone is obsolete. Please configure deadzone on the Rotate Anchor and Translate Anchor Actions.", True)]
	public float anchorControlOffAxisDeadzone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool animateModel
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public XRControllerState currentControllerState
	{
		 get { } //Length: 24
		 set { } //Length: 12
	}

	public bool enableInputActions
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool enableInputTracking
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool hideControllerModel
	{
		 get { } //Length: 8
		 set { } //Length: 176
	}

	public Transform model
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string modelDeSelectTransition
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform modelParent
	{
		 get { } //Length: 8
		 set { } //Length: 156
	}

	public Transform modelPrefab
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public string modelSelectTransition
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("modelTransform has been deprecated due to being renamed. Use modelParent instead. (UnityUpgradable) -> modelParent")]
	public Transform modelTransform
	{
		 get { } //Length: 8
		 set { } //Length: 4
	}

	public InteractionState selectInteractionState
	{
		 get { } //Length: 8
	}

	public InteractionState uiPressInteractionState
	{
		 get { } //Length: 8
	}

	public Vector2 uiScrollValue
	{
		 get { } //Length: 8
	}

	public UpdateType updateTrackingType
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected XRBaseController() { }

	protected override void ApplyControllerState(UpdatePhase updatePhase, XRControllerState controllerState) { }

	protected override void Awake() { }

	protected override void FixedUpdate() { }

	public InteractionState get_activateInteractionState() { }

	[CompilerGenerated]
	public float get_anchorControlDeadzone() { }

	[CompilerGenerated]
	public float get_anchorControlOffAxisDeadzone() { }

	public bool get_animateModel() { }

	public XRControllerState get_currentControllerState() { }

	public bool get_enableInputActions() { }

	public bool get_enableInputTracking() { }

	public bool get_hideControllerModel() { }

	public Transform get_model() { }

	public string get_modelDeSelectTransition() { }

	public Transform get_modelParent() { }

	public Transform get_modelPrefab() { }

	public string get_modelSelectTransition() { }

	public Transform get_modelTransform() { }

	public InteractionState get_selectInteractionState() { }

	public InteractionState get_uiPressInteractionState() { }

	public Vector2 get_uiScrollValue() { }

	public UpdateType get_updateTrackingType() { }

	[Obsolete("GetControllerState has been deprecated. Use currentControllerState instead.")]
	public override bool GetControllerState(out XRControllerState controllerState) { }

	protected override GameObject GetModelPrefab() { }

	protected override void OnBeforeRender() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public override bool SendHapticImpulse(float amplitude, float duration) { }

	[CompilerGenerated]
	public void set_anchorControlDeadzone(float value) { }

	[CompilerGenerated]
	public void set_anchorControlOffAxisDeadzone(float value) { }

	public void set_animateModel(bool value) { }

	public void set_currentControllerState(XRControllerState value) { }

	public void set_enableInputActions(bool value) { }

	public void set_enableInputTracking(bool value) { }

	public void set_hideControllerModel(bool value) { }

	public void set_model(Transform value) { }

	public void set_modelDeSelectTransition(string value) { }

	public void set_modelParent(Transform value) { }

	public void set_modelPrefab(Transform value) { }

	public void set_modelSelectTransition(string value) { }

	public void set_modelTransform(Transform value) { }

	public void set_updateTrackingType(UpdateType value) { }

	[Obsolete("SetControllerState has been deprecated. Use currentControllerState instead.")]
	public override void SetControllerState(XRControllerState controllerState) { }

	private void SetupControllerState() { }

	private void SetupModel() { }

	protected void Update() { }

	protected override void UpdateController() { }

	protected override void UpdateControllerModelAnimation() { }

	protected override void UpdateInput(XRControllerState controllerState) { }

	protected override void UpdateTrackingInput(XRControllerState controllerState) { }

}

