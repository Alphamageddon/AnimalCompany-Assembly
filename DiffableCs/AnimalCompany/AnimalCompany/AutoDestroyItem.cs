namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class AutoDestroyItem : NetworkBehaviour
{
	[SerializeField]
	private float _timeToDestroy; //Field offset: 0x80
	[DefaultForProperty("life", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _life; //Field offset: 0x84

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer life
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	public AutoDestroyItem() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private TickTimer get_life() { }

	private void set_life(TickTimer value) { }

	public virtual void Spawned() { }

}

