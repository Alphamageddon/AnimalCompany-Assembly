namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class Crossbow : NetworkBehaviour
{
	private const float STIFFNESS = 400; //Field offset: 0x0
	private const float DAMPENING = 5; //Field offset: 0x0
	private const float PULLED_BACK_POS = 0.46; //Field offset: 0x0
	[SerializeField]
	private AttachedItemAnchor _attachAnchor; //Field offset: 0x80
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x88
	[SerializeField]
	private RandomSFX _sfxLoad; //Field offset: 0x90
	[SerializeField]
	private RandomSFX _sfxFire; //Field offset: 0x98
	private GrabbableItem _grabbable; //Field offset: 0xA0
	private float _pull; //Field offset: 0xA8
	private float _pullVelocity; //Field offset: 0xAC
	private readonly int _pullPositionAttr; //Field offset: 0xB0

	public Crossbow() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void HandleAttachedChanged(AttachedLocation location, GrabbableItem item) { }

	private void HandleTriggerUse() { }

	private void HandleUse() { }

	private void OnDestroy() { }

	private bool ReleaseIfHeld(Vector3 velocity) { }

	private void Update() { }

	private void UpdatePull() { }

}

