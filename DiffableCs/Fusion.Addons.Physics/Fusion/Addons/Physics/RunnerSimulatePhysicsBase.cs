namespace Fusion.Addons.Physics;

public abstract class RunnerSimulatePhysicsBase : SimulationBehaviour, IBeforeTick
{
	protected static PhysicsTimings _physicsAutoSimRestore; //Field offset: 0x0
	private static int _enabledRunnersCount; //Field offset: 0x4
	[InlineHelp]
	[SerializeField]
	protected PhysicsAuthorities _physicsAuthority; //Field offset: 0x48
	[DrawIf("_physicsAuthority", 1, CompareOperator::NotEqual (1), DrawIfMode::ReadOnly (0), Hide = True)]
	[InlineHelp]
	[SerializeField]
	[WarnIf("WarnAutoSyncTransforms", "<b>AutoSyncTransforms</b> is enabled in Unity's Project Settings.\n\n<i>This is potentially costly due to interpolation moving the Rigidbody transform every <b>Update()</b>. If you have <b>NetworkRigidbody</b> instances which do not have <b>InterpolationTarget</b> set, then it may be preferable to disable <b>AutoSyncTransforms</b> and manually call <b>SyncTransforms()</b> before Raycast/Overlap queries.</i>", AsBox = True)]
	protected PhysicsTimings _physicsTiming; //Field offset: 0x4C
	[DrawIf("ShowClientPhysicsSimulation", Hide = True)]
	[InlineHelp]
	public ClientPhysicsSimulation ClientPhysicsSimulation; //Field offset: 0x50
	[DisplayName("DeltaTime Multiplier")]
	[DrawIf("ShowMultiplier", Hide = True)]
	[InlineHelp]
	[SerializeField]
	public float DeltaTimeMultiplier; //Field offset: 0x54
	[InlineHelp]
	[SerializeField]
	public bool SetUnityFixedTimestep; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnBeforeSimulate; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnAfterSimulate; //Field offset: 0x68
	private readonly Queue<Action> _onAfterSimulateCallbacks; //Field offset: 0x70
	private readonly Queue<Action> _onBeforeSimulateCallbacks; //Field offset: 0x78
	[CompilerGenerated]
	private bool <HasSimulatedThisTick>k__BackingField; //Field offset: 0x80
	private bool _isInitialized; //Field offset: 0x81

	public event Action OnAfterSimulate
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public event Action OnBeforeSimulate
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	protected abstract bool AutoSyncTransforms
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public private bool HasSimulatedThisTick
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public PhysicsAuthorities PhysicsAuthority
	{
		 get { } //Length: 8
	}

	public override float PhysicsSimulationDeltaTime
	{
		 get { } //Length: 28
	}

	public PhysicsTimings PhysicsTiming
	{
		 get { } //Length: 8
	}

	internal bool ShowClientPhysicsSimulation
	{
		internal get { } //Length: 16
	}

	internal bool ShowMultiplier
	{
		internal get { } //Length: 16
	}

	protected abstract PhysicsTimings UnityPhysicsMode
	{
		 get { } //Length: 0
	}

	internal bool WarnAutoSyncTransforms
	{
		internal get { } //Length: 64
	}

	protected RunnerSimulatePhysicsBase() { }

	[CompilerGenerated]
	public void add_OnAfterSimulate(Action value) { }

	[CompilerGenerated]
	public void add_OnBeforeSimulate(Action value) { }

	protected override bool AnySceneRequiresSyncTransform() { }

	protected bool CanSimulatePhysics(ClientPhysicsSimulation clientPhysicsSimulation) { }

	protected override void DoSimulatePrimaryScene(float deltaTime) { }

	public void FixedUpdate() { }

	public virtual void FixedUpdateNetwork() { }

	private override void Fusion.IBeforeTick.BeforeTick() { }

	protected abstract bool get_AutoSyncTransforms() { }

	[CompilerGenerated]
	public bool get_HasSimulatedThisTick() { }

	public PhysicsAuthorities get_PhysicsAuthority() { }

	public override float get_PhysicsSimulationDeltaTime() { }

	public PhysicsTimings get_PhysicsTiming() { }

	internal bool get_ShowClientPhysicsSimulation() { }

	internal bool get_ShowMultiplier() { }

	protected abstract PhysicsTimings get_UnityPhysicsMode() { }

	internal bool get_WarnAutoSyncTransforms() { }

	private void OnDestroy() { }

	protected abstract void OverrideAutoSimulate(bool enabled) { }

	public void QueueAfterSimulationCallback(Action callback) { }

	public void QueueBeforeSimulationCallback(Action callback) { }

	[CompilerGenerated]
	public void remove_OnAfterSimulate(Action value) { }

	[CompilerGenerated]
	public void remove_OnBeforeSimulate(Action value) { }

	protected bool RequiresSyncTransform(ClientPhysicsSimulation clientPhysicsSimulation) { }

	protected abstract void RestoreAutoSimulate() { }

	protected abstract void set_AutoSyncTransforms(bool value) { }

	[CompilerGenerated]
	private void set_HasSimulatedThisTick(bool value) { }

	protected override void Shutdown() { }

	protected abstract void SimulateAdditionalScenes(float deltaTime, bool checkPhysicsSimulation) { }

	protected abstract void SimulatePrimaryScene(float deltaTime) { }

	private void SimulationExecute(float deltaTime, bool checkPhysicsSimulation) { }

	protected override void Startup() { }

	private void Update() { }

}

