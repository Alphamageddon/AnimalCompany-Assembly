//Type is in global namespace

[NetworkBehaviourWeaved(1)]
public class FlareGunProjectile : NetworkBehaviour
{
	public float lifetime; //Field offset: 0x80
	public int damage; //Field offset: 0x84
	public float explosionRadius; //Field offset: 0x88
	public RandomSFX explosionSound; //Field offset: 0x90
	private NetworkVFXType deathVFX; //Field offset: 0x98
	private float explosionForce; //Field offset: 0x9C
	[DefaultForProperty("aliveTimer", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _aliveTimer; //Field offset: 0xA0

	[Networked]
	[NetworkedWeaved(0, 1)]
	private TickTimer aliveTimer
	{
		private get { } //Length: 96
		private set { } //Length: 96
	}

	public FlareGunProjectile() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public virtual void FixedUpdateNetwork() { }

	private TickTimer get_aliveTimer() { }

	private void OnDrawGizmosSelected() { }

	private void set_aliveTimer(TickTimer value) { }

	public virtual void Spawned() { }

}

