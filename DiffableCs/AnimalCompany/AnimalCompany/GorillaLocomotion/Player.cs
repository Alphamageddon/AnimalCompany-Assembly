namespace AnimalCompany.GorillaLocomotion;

public class Player : MonoBehaviour
{
	internal struct ItemContactPoint
	{
		public Vector3 position; //Field offset: 0x0
		public Vector3 prevPosition; //Field offset: 0xC

	}

	private static Player _instance; //Field offset: 0x0
	private const float DEFAULT_MAX_SPEED = 8; //Field offset: 0x0
	public const float AFFECT_MOVEMENT_MASS_THRESHOLD = 20; //Field offset: 0x0
	public const float AFFECT_MOVEMENT_MASS_FACTOR = 10; //Field offset: 0x0
	public PlayerController playerController; //Field offset: 0x20
	public SphereCollider headCollider; //Field offset: 0x28
	public CapsuleCollider bodyCollider; //Field offset: 0x30
	public Transform leftHandFollower; //Field offset: 0x38
	public Transform rightHandFollower; //Field offset: 0x40
	public Transform rightHandTransform; //Field offset: 0x48
	public Transform leftHandTransform; //Field offset: 0x50
	public Transform rightHandItemTransform; //Field offset: 0x58
	public Transform leftHandItemTransform; //Field offset: 0x60
	private Vector3 lastLeftHandPosition; //Field offset: 0x68
	private Vector3 lastRightHandPosition; //Field offset: 0x74
	private Vector3 lastHeadPosition; //Field offset: 0x80
	private Rigidbody playerRigidBody; //Field offset: 0x90
	public int velocityHistorySize; //Field offset: 0x98
	public float maxArmLength; //Field offset: 0x9C
	public float unStickDistance; //Field offset: 0xA0
	public float velocityLimit; //Field offset: 0xA4
	public float maxJumpSpeed; //Field offset: 0xA8
	public float jumpMultiplier; //Field offset: 0xAC
	public float minimumRaycastDistance; //Field offset: 0xB0
	public float defaultSlideFactor; //Field offset: 0xB4
	public float defaultPrecision; //Field offset: 0xB8
	private Vector3[] velocityHistory; //Field offset: 0xC0
	private int velocityIndex; //Field offset: 0xC8
	private Vector3 currentVelocity; //Field offset: 0xCC
	private Vector3 denormalizedVelocityAverage; //Field offset: 0xD8
	private bool jumpHandIsLeft; //Field offset: 0xE4
	private Vector3 lastPosition; //Field offset: 0xE8
	public Vector3 rightHandOffset; //Field offset: 0xF4
	public Vector3 leftHandOffset; //Field offset: 0x100
	public LayerMask locomotionEnabledLayers; //Field offset: 0x10C
	public bool wasLeftHandTouching; //Field offset: 0x110
	public bool wasRightHandTouching; //Field offset: 0x111
	public bool disableMovement; //Field offset: 0x112
	private bool _disableHandCollisions; //Field offset: 0x113
	public AudioSource windAudioSource; //Field offset: 0x118
	[Tooltip("The inverse lerp range of speed to wind sound. X = speed with wind volume at 0, Y = speed with wind volume at 1")]
	public Vector2 windSpeedRange; //Field offset: 0x120
	private RaycastHit hitInfoLeftHand; //Field offset: 0x128
	private RaycastHit hitInfoRightHand; //Field offset: 0x154
	private RaycastHit hitInfoItem; //Field offset: 0x180
	public Action<RaycastHit, Vector3> onHandCollidingLeft; //Field offset: 0x1B0
	public Action<RaycastHit, Vector3> onHandCollidingRight; //Field offset: 0x1B8
	private Vector3 _externalForceVelocity; //Field offset: 0x1C0
	private List<ItemContactPoint> _itemContacts; //Field offset: 0x1D0
	private float _itemMass; //Field offset: 0x1D8

	public static Player Instance
	{
		 get { } //Length: 72
	}

	public Player() { }

	public void AddExternalForceVelocity(Vector3 velocity) { }

	public void AddItemContactPoint(Vector3 position, Vector3 prevPosition) { }

	private void Awake() { }

	public static bool CalculateClampedMovement(ref Vector3 movement, float mass, float dt) { }

	public static bool CalculateClampedVelocity(ref Vector3 velocity, float mass, float baseMaxSpeed, float massThreshold, float massFactor) { }

	private static float ClampMaxSpeed(float baseMaxSpeed, float mass, float massThreshold, float massFactor) { }

	private bool CollisionsSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 finalPosition, out RaycastHit hitInfo) { }

	private Vector3 CurrentLeftHandPosition() { }

	private Vector3 CurrentRightHandPosition() { }

	private void DoUpdate(float dt) { }

	public static Player get_Instance() { }

	public void InitializeValues() { }

	public bool IsHandTouching(bool forLeftHand) { }

	private bool IterativeCollisionSphereCast(Vector3 startPosition, float sphereRadius, Vector3 movementVector, float precision, out Vector3 endPosition, bool singleHand, out RaycastHit hitInfo) { }

	private Vector3 PositionWithOffset(Transform transformToModify, Vector3 offsetVector) { }

	public void Reposition(Vector3 targetPosition) { }

	public void Reposition(Vector3 targetPosition, Vector3 targetDirection) { }

	public void Rotate(Vector3 targetForward) { }

	public void SetActiveHandCollisions(bool enabled) { }

	public void SetItemWeight(float weight) { }

	private void StoreVelocities(float dt) { }

	public void Turn(float degrees) { }

	private void Update() { }

}

