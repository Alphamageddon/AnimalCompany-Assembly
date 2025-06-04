namespace UnityEngine.ProBuilder.Poly2Tri;

internal class PointOnEdgeException : NotImplementedException
{
	public readonly TriangulationPoint A; //Field offset: 0x90
	public readonly TriangulationPoint B; //Field offset: 0x98
	public readonly TriangulationPoint C; //Field offset: 0xA0

	public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }

}

