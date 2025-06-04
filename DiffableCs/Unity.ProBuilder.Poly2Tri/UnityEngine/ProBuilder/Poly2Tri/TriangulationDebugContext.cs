namespace UnityEngine.ProBuilder.Poly2Tri;

internal abstract class TriangulationDebugContext
{
	protected TriangulationContext _tcx; //Field offset: 0x10

	public TriangulationDebugContext(TriangulationContext tcx) { }

	public abstract void Clear() { }

}

