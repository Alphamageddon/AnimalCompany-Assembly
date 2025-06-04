namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Plunger : NetworkBehaviour
{
	private const float STICK_ON_PUSH_DISTATNCE_SQR = 0.0025000002; //Field offset: 0x0
	private const float STICK_ON_GROUND_COLLISION_SPEED = 15; //Field offset: 0x0
	private const float STICK_ON_COLLSION_MIN_SPEED = 3; //Field offset: 0x0
	private const float STRETCH_DAMPENING = 8; //Field offset: 0x0
	private const float STRETCH_STIFFNESS = 200; //Field offset: 0x0
	private const float BREAK_SUCTION_DISTANCE = 0.2; //Field offset: 0x0
	private const float BREAK_SUCTION_DISTANCE_SQR = 0.040000003; //Field offset: 0x0
	private const float STICK_ON_PUSH_DISTATNCE = 0.05; //Field offset: 0x0
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0x80
	[SerializeField]
	private Transform _stickingPoint; //Field offset: 0x88
	[SerializeField]
	private Transform _stretchTransform; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _stickSFX; //Field offset: 0x98
	[SerializeField]
	private RandomSFX _unstickSFX; //Field offset: 0xA0
	[DefaultForProperty("isSuctioned", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isSuctioned; //Field offset: 0xA8
	private GrabbableItem _grabbable; //Field offset: 0xB0
	private StickyItem _stickyItem; //Field offset: 0xB8
	private Vector3 _grabbedPositionOffset; //Field offset: 0xC0
	private Vector3 _stretchVelocity; //Field offset: 0xCC
	private Transform _grabbedHandTransform; //Field offset: 0xD8
	private readonly int _pullPositionAttr; //Field offset: 0xE0
	private readonly int _stretchMtxAttr; //Field offset: 0xE4
	private bool _hasStuckAnchor; //Field offset: 0xE8
	private float _lastChangeTime; //Field offset: 0xEC

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsSuctionedChanged")]
	public bool isSuctioned
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	private LayerMask suctionToLayers
	{
		private get { } //Length: 172
	}

	public Plunger() { }

	private void Awake() { }

	private void CheckAndStick(float maxDistance) { }

	private void CheckCollision(Collision collision) { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	public bool get_isSuctioned() { }

	private LayerMask get_suctionToLayers() { }

	private void HandleGrabbedChanged() { }

	private void HandleIsGrabbedAndAnchoredChanged() { }

	private void HandleIsSuctionedChanged() { }

	private void HandleStuckAnchorChanged(Transform stuckAnchor) { }

	[ContextMenu("Init Matrix")]
	private void InitMtx() { }

	private void LateUpdate() { }

	private void OnCollisionEnter(Collision collision) { }

	private void OnDestroy() { }

	public void set_isSuctioned(bool value) { }

	private void UpdateStretchySuction() { }

}

