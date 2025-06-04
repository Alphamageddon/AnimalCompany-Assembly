namespace AnimalCompany;

public class AvatarItemPromotionPedestalView : MonoBehaviour
{
	private const float TIME_PER_ITEM = 5; //Field offset: 0x0
	public AvatarView avatarView; //Field offset: 0x20
	public Animator avatarAnimator; //Field offset: 0x28
	public int avatarAnimatorNumPoses; //Field offset: 0x30
	public TextMeshPro[] nameLabels; //Field offset: 0x38
	public float rotationTweenDuration; //Field offset: 0x40
	public Transform rotationPivot; //Field offset: 0x48
	public float cullingDistance; //Field offset: 0x50
	private AvatarItemState[] _items; //Field offset: 0x58
	private int _currentItemIndex; //Field offset: 0x60
	private bool _isCulled; //Field offset: 0x64
	private float _timer; //Field offset: 0x68
	private float _cullingCheckTimer; //Field offset: 0x6C
	private TempStateRoot<UserAvatarState> _mannequinAvatarState; //Field offset: 0x70
	private TempStateRoot<UserAvatarState> _avatarState; //Field offset: 0x78
	private int _poseIndexPropertyId; //Field offset: 0x80

	public AvatarItemPromotionPedestalView() { }

	[CompilerGenerated]
	private void <ChangeDisplayItem>b__19_0(float value) { }

	private void Awake() { }

	private void ChangeDisplayItem(AvatarItemState item) { }

	public void SetItems(AvatarItemState[] items) { }

	private void Update() { }

}

