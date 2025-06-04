namespace Fusion;

[HelpURL("https://doc.photonengine.com/fusion/current/manual/network-object#simulationbehaviour")]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Green (4))]
public abstract class SimulationBehaviour : Behaviour
{
	internal SimulationBehaviour Prev; //Field offset: 0x20
	internal SimulationBehaviour Next; //Field offset: 0x28
	internal SimulationBehaviourRuntimeFlags Flags; //Field offset: 0x30
	private NetworkRunner _runner; //Field offset: 0x38
	private NetworkObject _object; //Field offset: 0x40

	public bool CanReceiveRenderCallback
	{
		 get { } //Length: 16
	}

	public bool CanReceiveSimulationCallback
	{
		 get { } //Length: 28
	}

	public NetworkObject Object
	{
		 get { } //Length: 8
	}

	public NetworkRunner Runner
	{
		 get { } //Length: 8
	}

	protected SimulationBehaviour() { }

	[Conditional("DEBUG")]
	internal void DebugNotifyDespawned() { }

	[Conditional("DEBUG")]
	internal void DebugNotifySpawned() { }

	public override void FixedUpdateNetwork() { }

	public bool get_CanReceiveRenderCallback() { }

	public bool get_CanReceiveSimulationCallback() { }

	public NetworkObject get_Object() { }

	public NetworkRunner get_Runner() { }

	protected private virtual void GetDumpString(StringBuilder builder) { }

	internal void MakeOwned(NetworkRunner runner, NetworkObject obj) { }

	internal void MakeUnowned() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	internal override void PreRender() { }

	public override void Render() { }

}

