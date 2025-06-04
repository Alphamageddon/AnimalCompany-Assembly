namespace AnimalCompany;

public class HandController : MonoBehaviour
{
	[SerializeField]
	private AvatarArmature _avatarArmature; //Field offset: 0x20
	[SerializeField]
	private bool _isLeftHand; //Field offset: 0x28
	[SerializeField]
	private SphereCollider _indexFingerCollider; //Field offset: 0x30
	[SerializeField]
	private SphereCollider _thumbFingerCollider; //Field offset: 0x38
	[SerializeField]
	private SphereCollider _middleFingerCollider; //Field offset: 0x40
	private XRController _xrController; //Field offset: 0x48
	private bool _prevIsTracked; //Field offset: 0x50

	public bool hasBeenTracked
	{
		 get { } //Length: 8
	}

	public XRController xrController
	{
		 get { } //Length: 8
	}

	public HandController() { }

	private void Awake() { }

	public bool get_hasBeenTracked() { }

	public XRController get_xrController() { }

	public void SetFingersExtended(bool thumbExtended, bool indexExtended, bool middleExtended) { }

	[ContextMenu("Test Primary Button")]
	private void TestPrimaryButton() { }

	[ContextMenu("Test Secondary Button")]
	private void TestSecondaryButton() { }

	[ContextMenu("Test Trigger")]
	private void TestTrigger() { }

	public void UpdateIsTracking(Transform head) { }

}

