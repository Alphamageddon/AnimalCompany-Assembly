namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Umbrella : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Umbrella <>4__this; //Field offset: 0x10
		public float endVal; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <AnimateOpenClose>b__0(float val) { }

		internal void <AnimateOpenClose>b__1() { }

	}

	[SerializeField]
	private Renderer _renderer; //Field offset: 0x80
	[SerializeField]
	private Transform _stretchTransform; //Field offset: 0x88
	[SerializeField]
	private Transform _tipTransform; //Field offset: 0x90
	[SerializeField]
	private Collider _openCollider; //Field offset: 0x98
	[SerializeField]
	private Collider _closedCollider; //Field offset: 0xA0
	[SerializeField]
	private RandomSFX _openSFX; //Field offset: 0xA8
	[SerializeField]
	private RandomSFX _closeSFX; //Field offset: 0xB0
	[SerializeField]
	private Transform _backAttachOpen; //Field offset: 0xB8
	[SerializeField]
	private Transform _backAttachClosed; //Field offset: 0xC0
	[DefaultForProperty("isOpen", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isOpen; //Field offset: 0xC8
	private GrabbableItem _grabbable; //Field offset: 0xD0
	private int _openCloseTweenID; //Field offset: 0xD8
	private float _openedValue; //Field offset: 0xDC
	private readonly Vector3 openedPos; //Field offset: 0xE0
	private readonly Vector3 closedPos; //Field offset: 0xEC
	private readonly Vector3 closedScale; //Field offset: 0xF8
	private readonly int _stretchMtxAttr; //Field offset: 0x104

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsOpenChanged")]
	public bool isOpen
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public Umbrella() { }

	private void AnimateOpenClose() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public bool get_isOpen() { }

	private void HandleIsOpenChanged() { }

	private void HandlePreGrabbed() { }

	private void HandleUse() { }

	private void OnDestroy() { }

	public void set_isOpen(bool value) { }

	public virtual void Spawned() { }

	private bool TryCalculateApplyVelocity(float verticalVelocity, out Vector3 counterVelocity) { }

	private void Update() { }

	private void UpdateOpenedAmount() { }

}

