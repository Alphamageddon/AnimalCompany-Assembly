namespace UnityEngine.ProBuilder.Poly2Tri;

internal class DTSweepBasin
{
	public AdvancingFrontNode leftNode; //Field offset: 0x10
	public AdvancingFrontNode bottomNode; //Field offset: 0x18
	public AdvancingFrontNode rightNode; //Field offset: 0x20
	public double width; //Field offset: 0x28
	public bool leftHighest; //Field offset: 0x30

	public DTSweepBasin() { }

}

