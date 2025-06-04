namespace UnityEngine.Rendering.Universal;

internal class PolyTree : PolyNode
{
	internal List<PolyNode> m_AllPolys; //Field offset: 0x40

	public int Total
	{
		 get { } //Length: 168
	}

	public PolyTree() { }

	public void Clear() { }

	public int get_Total() { }

	public PolyNode GetFirst() { }

}

