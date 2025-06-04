namespace UnityEngine.ProBuilder.Poly2Tri;

internal class AdvancingFront
{
	public AdvancingFrontNode Head; //Field offset: 0x10
	public AdvancingFrontNode Tail; //Field offset: 0x18
	protected AdvancingFrontNode Search; //Field offset: 0x20

	public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	public void AddNode(AdvancingFrontNode node) { }

	private AdvancingFrontNode FindSearchNode(double x) { }

	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	private AdvancingFrontNode LocateNode(double x) { }

	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }

	public void RemoveNode(AdvancingFrontNode node) { }

	public virtual string ToString() { }

}

