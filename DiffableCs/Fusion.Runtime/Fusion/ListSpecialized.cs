namespace Fusion;

[Extension]
internal static class ListSpecialized
{

	[Extension]
	public static bool AddUnique(List<NetworkId> list, NetworkId value) { }

	[Extension]
	public static int BinarySearchSpecialized(List<NetworkId> list, NetworkId value) { }

	[Extension]
	public static bool RemoveUnique(List<NetworkId> list, NetworkId value) { }

}

