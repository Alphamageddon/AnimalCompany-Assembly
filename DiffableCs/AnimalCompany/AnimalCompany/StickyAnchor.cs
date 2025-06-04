namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class StickyAnchor : NetworkBehaviour
{
	public Action<StickyAnchor> onDespawned; //Field offset: 0x80

	public StickyAnchor() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void Despawned(NetworkRunner runner, bool hasState) { }

}

