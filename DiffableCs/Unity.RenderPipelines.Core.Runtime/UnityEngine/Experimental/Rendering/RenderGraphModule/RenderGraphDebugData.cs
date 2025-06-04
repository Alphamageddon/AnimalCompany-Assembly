namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphDebugData
{
	[DebuggerDisplay("PassDebug: {name}")]
	internal struct PassDebugData
	{
		public string name; //Field offset: 0x0
		public List<Int32>[] resourceReadLists; //Field offset: 0x8
		public List<Int32>[] resourceWriteLists; //Field offset: 0x10
		public bool culled; //Field offset: 0x18
		public bool async; //Field offset: 0x19
		public int syncToPassIndex; //Field offset: 0x1C
		public int syncFromPassIndex; //Field offset: 0x20
		public bool generateDebugData; //Field offset: 0x24

	}

	[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
	internal struct ResourceDebugData
	{
		public string name; //Field offset: 0x0
		public bool imported; //Field offset: 0x8
		public int creationPassIndex; //Field offset: 0xC
		public int releasePassIndex; //Field offset: 0x10
		public List<Int32> consumerList; //Field offset: 0x18
		public List<Int32> producerList; //Field offset: 0x20

	}

	public List<PassDebugData> passList; //Field offset: 0x10
	public List<ResourceDebugData>[] resourceLists; //Field offset: 0x18

	public RenderGraphDebugData() { }

	public void Clear() { }

}

