namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshManager.h")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[StaticAccessor("NavMeshBindings", StaticAccessorType::DoubleColon (2))]
public static class NavMesh
{
	internal sealed class OnNavMeshPreUpdate : MulticastDelegate
	{

		public OnNavMeshPreUpdate(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	public static OnNavMeshPreUpdate onPreUpdate; //Field offset: 0x0

	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeName("AddLink")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeName("LoadData")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

	[RequiredByNativeCode]
	private static void Internal_CallOnNavMeshPreUpdate() { }

	[NativeName("SetLinkUserID")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[NativeName("SetSurfaceUserID")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessor("GetNavMeshManager()")]
	internal static bool IsValidLinkHandle(int handle) { }

	[NativeName("IsValidSurfaceID")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) { }

	private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) { }

	[NativeName("RemoveLink")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static void RemoveLinkInternal(int handle) { }

	[NativeName("UnloadData")]
	[StaticAccessor("GetNavMeshManager()")]
	internal static void RemoveNavMeshDataInternal(int handle) { }

}

