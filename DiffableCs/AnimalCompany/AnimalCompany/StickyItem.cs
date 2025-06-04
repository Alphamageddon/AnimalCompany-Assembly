namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class StickyItem : NetworkBehaviour
{
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private NetworkObject _stickyPointPrefab; //Field offset: 0x88

	public bool isStuck
	{
		 get { } //Length: 168
	}

	public StickyItem() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public bool get_isStuck() { }

	public void Stick(Vector3 position, Quaternion rotation, Transform parent, bool release = false) { }

	public void Unstick() { }

}

