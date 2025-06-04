namespace UnityEngine.SubsystemsImplementation;

public abstract class SubsystemWithProvider : ISubsystem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <running>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SubsystemProvider <providerBase>k__BackingField; //Field offset: 0x18

	internal SubsystemProvider providerBase
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public private override bool running
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	protected SubsystemWithProvider() { }

	public override void Destroy() { }

	[CompilerGenerated]
	internal SubsystemProvider get_providerBase() { }

	[CompilerGenerated]
	public override bool get_running() { }

	protected abstract void OnDestroy() { }

	protected abstract void OnStart() { }

	protected abstract void OnStop() { }

	[CompilerGenerated]
	private void set_running(bool value) { }

	public override void Start() { }

	public override void Stop() { }

}

