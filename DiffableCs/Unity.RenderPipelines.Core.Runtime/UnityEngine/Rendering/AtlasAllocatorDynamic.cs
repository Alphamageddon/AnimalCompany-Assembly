namespace UnityEngine.Rendering;

internal class AtlasAllocatorDynamic
{
	private struct AtlasNode
	{
		private enum AtlasNodeFlags
		{
			IsOccupied = 1,
		}

		public short m_Self; //Field offset: 0x0
		public short m_Parent; //Field offset: 0x2
		public short m_LeftChild; //Field offset: 0x4
		public short m_RightChild; //Field offset: 0x6
		public short m_FreelistNext; //Field offset: 0x8
		public ushort m_Flags; //Field offset: 0xA
		public Vector4 m_Rect; //Field offset: 0x10

		public AtlasNode(short self, short parent) { }

		public short Allocate(AtlasNodePool pool, int width, int height) { }

		public void ClearIsOccupied() { }

		public bool IsLeafNode() { }

		public bool IsMergeNeeded(AtlasNodePool pool) { }

		public bool IsOccupied() { }

		public void ReleaseAndMerge(AtlasNodePool pool) { }

		public void ReleaseChildren(AtlasNodePool pool) { }

		public void SetIsOccupied() { }

	}

	private class AtlasNodePool
	{
		internal AtlasNode[] m_Nodes; //Field offset: 0x10
		private short m_Next; //Field offset: 0x18
		private short m_FreelistHead; //Field offset: 0x1A

		public AtlasNodePool(short capacity) { }

		public short AtlasNodeCreate(short parent) { }

		public void AtlasNodeFree(short index) { }

		public void Clear() { }

		public void Dispose() { }

	}

	private int m_Width; //Field offset: 0x10
	private int m_Height; //Field offset: 0x14
	private AtlasNodePool m_Pool; //Field offset: 0x18
	private short m_Root; //Field offset: 0x20
	private Dictionary<Int32, Int16> m_NodeFromID; //Field offset: 0x28

	public AtlasAllocatorDynamic(int width, int height, int capacityAllocations) { }

	public bool Allocate(out Vector4 result, int key, int width, int height) { }

	private void DebugStringFromNode(ref string res, short n, int depthCurrent = 0, int depthMax = -1) { }

	public string DebugStringFromRoot(int depthMax = -1) { }

	public void Release(int key) { }

	public void Release() { }

}

