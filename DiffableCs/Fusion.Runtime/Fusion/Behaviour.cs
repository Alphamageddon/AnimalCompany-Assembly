namespace Fusion;

[ScriptHelp]
public abstract class Behaviour : MonoBehaviour, ILogSource, ILogDumpable
{
	private const string NameUnavailable = "(unavailable)"; //Field offset: 0x0
	private const string NameDestroyed = "(destroyed)"; //Field offset: 0x0

	internal string DebugNameThreadSafe
	{
		internal get { } //Length: 264
	}

	protected Behaviour() { }

	public T AddBehaviour() { }

	public static void DestroyBehaviour(Behaviour behaviour) { }

	private override void Fusion.ILogDumpable.Dump(StringBuilder builder) { }

	internal string get_DebugNameThreadSafe() { }

	public T GetBehaviour() { }

	protected private override void GetDumpString(StringBuilder builder) { }

	public bool TryGetBehaviour(out T behaviour) { }

}

