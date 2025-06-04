namespace Fusion;

[DisallowMultipleComponent]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Sand (8))]
public class RunnerLagCompensationGizmos : Behaviour
{
	public bool DrawSnapshotHistory; //Field offset: 0x20
	public bool DrawBroadphaseNodes; //Field offset: 0x21
	public Color StateAuthHitboxCollor; //Field offset: 0x24
	public Color NonStateAuthHitboxCollor; //Field offset: 0x34
	private NetworkRunner _runner; //Field offset: 0x48

	public RunnerLagCompensationGizmos() { }

	private void Awake() { }

	private void OnDrawGizmos() { }

	private void RenderBHVBroadphase() { }

	private void RenderHitboxHistory() { }

}

