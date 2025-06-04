namespace AnimalCompany;

public class SlowHoverButton : MonoBehaviour
{
	public Action OnActivate; //Field offset: 0x20
	public float holdTime; //Field offset: 0x28
	public RandomSFX activateSound; //Field offset: 0x30
	[Header("Look")]
	[Tooltip("Over the course of a hold this object will be scaled from the base to (1,1,1)")]
	public Transform scaler; //Field offset: 0x38
	public MeshRenderer scalerRenderer; //Field offset: 0x40
	public CanvasRenderer scalerCanvasRenderer; //Field offset: 0x48
	public Vector3 baseScale; //Field offset: 0x50
	private Collider _collider; //Field offset: 0x60
	private HandSide _handSide; //Field offset: 0x68
	private float _timer; //Field offset: 0x6C
	private bool _pressed; //Field offset: 0x70

	public SlowHoverButton() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void OnValidate() { }

	public void SetHoldTime(float time) { }

	private void SetHoverEffect(float t) { }

	private void Update() { }

}

