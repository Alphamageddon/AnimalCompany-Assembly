namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class Crowbar : NetworkBehaviour
{
	private const int HIT_DAMAGE = 15; //Field offset: 0x0
	private const float MULTI_HIT_DEBOUNCE = 0.5; //Field offset: 0x0
	[SerializeField]
	private RandomSFX hitSFX; //Field offset: 0x80
	private Rigidbody _rigidbody; //Field offset: 0x88
	private GrabbableItem _grabbable; //Field offset: 0x90
	private float _lastHitTime; //Field offset: 0x98

	public Crowbar() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void OnCollisionEnter(Collision collision) { }

	private void OnTriggerEnter(Collider other) { }

}

