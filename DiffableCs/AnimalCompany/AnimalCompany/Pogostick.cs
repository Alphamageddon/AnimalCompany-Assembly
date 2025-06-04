namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class Pogostick : NetworkBehaviour
{
	private const float MAX_SPRING_DISTANCE = 0.3; //Field offset: 0x0
	[SerializeField]
	private TriggerDetector _triggerDetector; //Field offset: 0x80
	[SerializeField]
	private Transform _spring; //Field offset: 0x88
	[SerializeField]
	private Transform _stretchBase; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _bounceEnterSFX; //Field offset: 0x98
	[SerializeField]
	private RandomSFX _bounceExitSFX; //Field offset: 0xA0
	[SerializeField]
	private Transform _stretchTransform; //Field offset: 0xA8
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0xB0
	private GrabbableItem _grabbable; //Field offset: 0xB8
	private float _targetOffset; //Field offset: 0xC0
	private float _distancePressed; //Field offset: 0xC4
	private float _springVelocity; //Field offset: 0xC8
	private int _lastTriggerStayFrame; //Field offset: 0xCC
	private float _lastSprungTime; //Field offset: 0xD0
	private bool _isTriggered; //Field offset: 0xD4
	private bool _isCompressed; //Field offset: 0xD5
	private bool _prevCompressed; //Field offset: 0xD6
	private Vector3 _builtUpVelocity; //Field offset: 0xD8
	private readonly int _stretchMtxAttr; //Field offset: 0xE4

	public Pogostick() { }

	private void Awake() { }

	private void CalcCollisionBounce(Vector3 relativeVelocity) { }

	private void CalcHeldBounce() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void DoMoveUpdate() { }

	private void FixedUpdate() { }

	private void HandleMovementUpdate() { }

	private void HandleTriggerStay(Collider collider) { }

	private void OnCollisionEnter(Collision collision) { }

	private void OnDestroy() { }

	private bool TryCalculateApplyVelocity(Vector3 inputVelocity, out Vector3 counterVelocity) { }

	private bool TryGetItemToApplyTo(out GrabbableItem itemToApplyTo) { }

	private void Update() { }

	private void UpdateSpringDistance() { }

	private void UpdateSpringVisual() { }

}

