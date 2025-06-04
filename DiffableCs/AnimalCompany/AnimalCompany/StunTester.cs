namespace AnimalCompany;

[NetworkBehaviourWeaved(0)]
public class StunTester : NetworkBehaviour
{
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private RandomSFX _SFXswitch; //Field offset: 0x88
	[SerializeField]
	[Space(10)]
	private float _stunRange; //Field offset: 0x90
	[SerializeField]
	private float _stunDuration; //Field offset: 0x94
	private List<IStunnable> _stunnables; //Field offset: 0x98

	public GrabbableItem grabbable
	{
		 get { } //Length: 8
	}

	public StunTester() { }

	[CompilerGenerated]
	private void <Awake>b__7_0(CallbackContext ctx) { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	private void Detonate() { }

	public GrabbableItem get_grabbable() { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

}

