namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal class Tess
{
	public class ActiveRegion
	{
		internal Edge _eUp; //Field offset: 0x10
		internal Node<ActiveRegion> _nodeUp; //Field offset: 0x18
		internal int _windingNumber; //Field offset: 0x20
		internal bool _inside; //Field offset: 0x24
		internal bool _sentinel; //Field offset: 0x25
		internal bool _dirty; //Field offset: 0x26
		internal bool _fixUpperEdge; //Field offset: 0x27

		public ActiveRegion() { }

	}

	private Mesh _mesh; //Field offset: 0x10
	private Vec3 _normal; //Field offset: 0x18
	private Vec3 _sUnit; //Field offset: 0x24
	private Vec3 _tUnit; //Field offset: 0x30
	private float _bminX; //Field offset: 0x3C
	private float _bminY; //Field offset: 0x40
	private float _bmaxX; //Field offset: 0x44
	private float _bmaxY; //Field offset: 0x48
	private WindingRule _windingRule; //Field offset: 0x4C
	private Dict<ActiveRegion> _dict; //Field offset: 0x50
	private PriorityQueue<Vertex> _pq; //Field offset: 0x58
	private Vertex _event; //Field offset: 0x60
	private CombineCallback _combineCallback; //Field offset: 0x68
	private ContourVertex[] _vertices; //Field offset: 0x70
	private int _vertexCount; //Field offset: 0x78
	private Int32[] _elements; //Field offset: 0x80
	private int _elementCount; //Field offset: 0x88
	public float SUnitX; //Field offset: 0x8C
	public float SUnitY; //Field offset: 0x90
	public float SentinelCoord; //Field offset: 0x94
	public bool NoEmptyPolygons; //Field offset: 0x98
	public bool UsePooling; //Field offset: 0x99

	public int ElementCount
	{
		 get { } //Length: 8
	}

	public Int32[] Elements
	{
		 get { } //Length: 8
	}

	public Vec3 Normal
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public int VertexCount
	{
		 get { } //Length: 8
	}

	public ContourVertex[] Vertices
	{
		 get { } //Length: 8
	}

	public Tess() { }

	public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation) { }

	public void AddContour(ContourVertex[] vertices) { }

	private ActiveRegion AddRegionBelow(ActiveRegion regAbove, Edge eNewUp) { }

	private void AddRightEdges(ActiveRegion regUp, Edge eFirst, Edge eLast, Edge eTopLeft, bool cleanUp) { }

	private void AddSentinel(float smin, float smax, float t) { }

	private bool CheckForIntersect(ActiveRegion regUp) { }

	private bool CheckForLeftSplice(ActiveRegion regUp) { }

	private bool CheckForRightSplice(ActiveRegion regUp) { }

	private void CheckOrientation() { }

	protected void ComputeInterior() { }

	private void ComputeNormal(ref Vec3 norm) { }

	private void ComputeWinding(ActiveRegion reg) { }

	private void ConnectLeftDegenerate(ActiveRegion regUp, Vertex vEvent) { }

	private void ConnectLeftVertex(Vertex vEvent) { }

	private void ConnectRightVertex(ActiveRegion regUp, Edge eBottomLeft) { }

	private void DeleteRegion(ActiveRegion reg) { }

	private void DiscardExterior() { }

	private void DoneEdgeDict() { }

	private void DonePriorityQ() { }

	private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2) { }

	private Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast) { }

	private void FinishRegion(ActiveRegion reg) { }

	private void FixUpperEdge(ActiveRegion reg, Edge newEdge) { }

	public int get_ElementCount() { }

	public Int32[] get_Elements() { }

	public Vec3 get_Normal() { }

	public int get_VertexCount() { }

	public ContourVertex[] get_Vertices() { }

	private void GetIntersectData(Vertex isect, Vertex orgUp, Vertex dstUp, Vertex orgLo, Vertex dstLo) { }

	private int GetNeighbourFace(Edge edge) { }

	private void InitEdgeDict() { }

	private void InitPriorityQ() { }

	private void OutputContours() { }

	private void OutputPolymesh(ElementType elementType, int polySize) { }

	private void ProjectPolygon() { }

	private ActiveRegion RegionAbove(ActiveRegion reg) { }

	private ActiveRegion RegionBelow(ActiveRegion reg) { }

	private void RemoveDegenerateEdges() { }

	private void RemoveDegenerateFaces() { }

	public void set_Normal(Vec3 value) { }

	private void SetWindingNumber(int value, bool keepOnlyBoundary) { }

	private float SignedArea(ContourVertex[] vertices) { }

	private void SpliceMergeVertices(Edge e1, Edge e2) { }

	private void SweepEvent(Vertex vEvent) { }

	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize) { }

	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback) { }

	private void TessellateInterior() { }

	private void TessellateMonoRegion(Face face) { }

	private ActiveRegion TopLeftRegion(ActiveRegion reg) { }

	private ActiveRegion TopRightRegion(ActiveRegion reg) { }

	private void VertexWeights(Vertex isect, Vertex org, Vertex dst, out float w0, out float w1) { }

	private void WalkDirtyRegions(ActiveRegion regUp) { }

}

