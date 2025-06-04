namespace UnityEngine.XR.Interaction.Toolkit;

[DefaultExecutionOrder(-210)]
public abstract class LocomotionProvider : MonoBehaviour
{
	[CompilerGenerated]
	private Action<LocomotionSystem> beginLocomotion; //Field offset: 0x20
	[CompilerGenerated]
	private Action<LocomotionSystem> endLocomotion; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The Locomotion System that this locomotion provider communicates with for exclusive access to an XR Origin. If one is not provided, the behavior will attempt to locate one during its Awake call.")]
	private LocomotionSystem m_System; //Field offset: 0x30
	[CompilerGenerated]
	private LocomotionPhase <locomotionPhase>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Action<LocomotionSystem> startLocomotion; //Field offset: 0x40

	public event Action<LocomotionSystem> beginLocomotion
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<LocomotionSystem> endLocomotion
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	[Obsolete("startLocomotion has been deprecated. Use beginLocomotion instead. (UnityUpgradable) -> beginLocomotion", True)]
	public event Action<LocomotionSystem> startLocomotion
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public LocomotionPhase locomotionPhase
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public LocomotionSystem system
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected LocomotionProvider() { }

	[CompilerGenerated]
	public void add_beginLocomotion(Action<LocomotionSystem> value) { }

	[CompilerGenerated]
	public void add_endLocomotion(Action<LocomotionSystem> value) { }

	[CompilerGenerated]
	public void add_startLocomotion(Action<LocomotionSystem> value) { }

	protected override void Awake() { }

	protected bool BeginLocomotion() { }

	protected bool CanBeginLocomotion() { }

	protected bool EndLocomotion() { }

	[CompilerGenerated]
	public LocomotionPhase get_locomotionPhase() { }

	public LocomotionSystem get_system() { }

	[CompilerGenerated]
	public void remove_beginLocomotion(Action<LocomotionSystem> value) { }

	[CompilerGenerated]
	public void remove_endLocomotion(Action<LocomotionSystem> value) { }

	[CompilerGenerated]
	public void remove_startLocomotion(Action<LocomotionSystem> value) { }

	[CompilerGenerated]
	protected void set_locomotionPhase(LocomotionPhase value) { }

	public void set_system(LocomotionSystem value) { }

}

