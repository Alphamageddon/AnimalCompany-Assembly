//Type is in global namespace

[NetworkBehaviourWeaved(1)]
public class FlareGunProjectile : NetworkBehaviour
{
	private const float STUN_DURATION = 8; //Field offset: 0x0
	private const float EXPLOSION_RADIUS = 7; //Field offset: 0x0
	private const string STUN_HIT_NAME = "FlareGunExplosion"; //Field offset: 0x0
	public float lifetime; //Field offset: 0x80
	public RandomSFX explosionSound; //Field offset: 0x88
	private NetworkVFXType deathVFX; //Field offset: 0x90
	[DefaultForProperty("aliveTimer", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[WeaverGenerated]
	private TickTimer _aliveTimer; //Field offset: 0x94
	private List<IStunnable> _stunnables; //Field offset: 0x98

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

