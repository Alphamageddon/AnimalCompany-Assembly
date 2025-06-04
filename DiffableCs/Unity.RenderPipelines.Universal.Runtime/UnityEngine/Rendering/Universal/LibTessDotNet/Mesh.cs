namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal class Mesh : Pooled<Mesh>
{
	internal Vertex _vHead; //Field offset: 0x10
	internal Face _fHead; //Field offset: 0x18
	internal Edge _eHead; //Field offset: 0x20
	internal Edge _eHeadSym; //Field offset: 0x28

	public Mesh() { }

	public Edge AddEdgeVertex(Edge eOrg) { }

	[Conditional("DEBUG")]
	public void Check() { }

	public Edge Connect(Edge eOrg, Edge eDst) { }

	public void Delete(Edge eDel) { }

	public Edge MakeEdge() { }

	public void MergeConvexFaces(int maxVertsPerFace) { }

	public virtual void OnFree() { }

	public virtual void Reset() { }

	public void Splice(Edge eOrg, Edge eDst) { }

	public Edge SplitEdge(Edge eOrg) { }

	public void ZapFace(Face fZap) { }

}

