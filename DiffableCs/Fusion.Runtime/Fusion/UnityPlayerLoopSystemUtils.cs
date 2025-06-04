namespace Fusion;

internal static class UnityPlayerLoopSystemUtils
{

	public static bool AddToPlayerLoop(ref PlayerLoopSystem parentSystem, Type referenceSystemType, UnityPlayerLoopSystemAddMode addMode, Type ownerType, UpdateFunction updateDelegate) { }

	private static void InsertSystem(ref PlayerLoopSystem[] systems, int position, Type ownerType, UpdateFunction updateDelegate) { }

	public static bool RemoveFromPlayerLoop(ref PlayerLoopSystem parentSystem, Type type) { }

}

