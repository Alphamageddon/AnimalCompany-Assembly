namespace AnimalCompany;

public class UIScrollWheel : MonoBehaviour
{
	public Func<Single, Boolean> onScroll; //Field offset: 0x20
	public CollisionTrigger volumeTrigger; //Field offset: 0x28
	public Renderer meshRenderer; //Field offset: 0x30
	public Transform rotatingMesh; //Field offset: 0x38
	public Collider currentCollider; //Field offset: 0x40
	public Vector3 lastFramePosition; //Field offset: 0x48
	private float velocity; //Field offset: 0x54
	public float drag; //Field offset: 0x58
	private HandSide _handSide; //Field offset: 0x5C
	public float degPerTick; //Field offset: 0x60
	public RandomSFX tickSound; //Field offset: 0x68
	public RandomSFX badTickSound; //Field offset: 0x70
	private float distCounter; //Field offset: 0x78

	public UIScrollWheel() { }

	private void Awake() { }

	private void FixedUpdate() { }

	private void TriggerEnter(Collider col) { }

	private void TriggerExit(Collider col) { }

}

