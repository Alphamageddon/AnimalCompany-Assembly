namespace AnimalCompany;

public class ArmTargetAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RaycastHit, Single> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <Update>b__14_0(RaycastHit hit) { }

	}

	private const float ARM_SPEED = 7; //Field offset: 0x0
	[SerializeField]
	private Transform _armTipTransform; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Parent of tip transform, to calculate original position in world space")]
	private Transform _armTipParentTransform; //Field offset: 0x28
	[SerializeField]
	private float _maxArmLength; //Field offset: 0x30
	[SerializeField]
	[Tooltip("To original position when the target is out of this distance")]
	private float _interestDistance; //Field offset: 0x34
	[SerializeField]
	private SphereCollider _sphereCollider; //Field offset: 0x38
	[Header("SFX")]
	[SerializeField]
	private RandomSFX _defaultFootstepSFX; //Field offset: 0x40
	private List<RaycastHit> _contactPoints; //Field offset: 0x48
	private Vector3 _originalPositionOS; //Field offset: 0x50
	private Vector3 _targetPosition; //Field offset: 0x5C
	private Vector3 _stepPositionPrev; //Field offset: 0x68

	private Vector3 centerPosition
	{
		private get { } //Length: 32
	}

	public ArmTargetAnimator() { }

	private void Awake() { }

	private Vector3 get_centerPosition() { }

	private void OnDrawGizmos() { }

	private void Update() { }

}

