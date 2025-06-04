namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class HandInteractor : NetworkBehaviour
{
	[SerializeField]
	private HandSide _handSide; //Field offset: 0x80
	[SerializeField]
	private LayerMask _grabbableLayerMask; //Field offset: 0x84
	private AttachedItemAnchor _itemAnchor; //Field offset: 0x88
	private NetPlayer _netPlayer; //Field offset: 0x90

	public HandSide handSide
	{
		 get { } //Length: 8
	}

	public AttachedItemAnchor itemAnchor
	{
		 get { } //Length: 8
	}

	public HandInteractor() { }

	[CompilerGenerated]
	private int <CheckAndTryGrab>b__17_0(Collider a, Collider b) { }

	private void Awake() { }

	private bool CheckAndAttach() { }

	private void CheckAndTryGrab() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

	public HandSide get_handSide() { }

	public AttachedItemAnchor get_itemAnchor() { }

	private void HandleAltGrabButtonPressed() { }

	private void HandleGrabButtonPressed() { }

	private bool IsByBackAttachment() { }

	private bool ReattachToAnchorIfFree(AttachedItemAnchor anchor) { }

	public virtual void Spawned() { }

	[ContextMenu("Test Grab")]
	public void TestGrab() { }

}

