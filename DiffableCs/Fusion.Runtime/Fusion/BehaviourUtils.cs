namespace Fusion;

internal static class BehaviourUtils
{
	internal struct DeferredJoin
	{
		public IEnumerable _enumerable; //Field offset: 0x0

		public virtual string ToString() { }

	}

	public struct NameDeferred
	{
		private Behaviour _behaviour; //Field offset: 0x0

		public NameDeferred(Behaviour behaviour) { }

		public static NameDeferred op_Explicit(Behaviour behaviour) { }

		public static string op_Implicit(NameDeferred wrapper) { }

		public virtual string ToString() { }

	}


	public static NameDeferred GetName(Behaviour obj) { }

	public static bool IsAlive(NetworkRunner obj) { }

	public static bool IsAlive(SimulationBehaviour obj) { }

	public static bool IsAlive(NetworkObject obj) { }

	public static bool IsNotAlive(NetworkRunner obj) { }

	public static bool IsNotAlive(SimulationBehaviour obj) { }

	public static bool IsNotAlive(NetworkObject obj) { }

	public static bool IsNotNull(Behaviour obj) { }

	public static bool IsNull(Behaviour obj) { }

	public static bool IsSame(Behaviour a, Behaviour b) { }

	public static bool IsSameNotNull(Behaviour a, Behaviour b) { }

	public static DeferredJoin Join(IEnumerable objects) { }

}

