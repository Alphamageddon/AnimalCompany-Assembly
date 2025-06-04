namespace UnityEngine.Rendering.Universal.LibTessDotNet;

internal static class MeshUtils
{
	internal class Edge : Pooled<Edge>
	{
		internal EdgePair _pair; //Field offset: 0x10
		internal Edge _next; //Field offset: 0x20
		internal Edge _Sym; //Field offset: 0x28
		internal Edge _Onext; //Field offset: 0x30
		internal Edge _Lnext; //Field offset: 0x38
		internal Vertex _Org; //Field offset: 0x40
		internal Face _Lface; //Field offset: 0x48
		internal ActiveRegion _activeRegion; //Field offset: 0x50
		internal int _winding; //Field offset: 0x58

		internal Edge _Dnext
		{
			internal get { } //Length: 36
			internal set { } //Length: 36
		}

		internal Edge _Dprev
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		internal Vertex _Dst
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		internal Edge _Lprev
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		internal Edge _Oprev
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		internal Face _Rface
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		internal Edge _Rnext
		{
			internal get { } //Length: 36
			internal set { } //Length: 36
		}

		internal Edge _Rprev
		{
			internal get { } //Length: 28
			internal set { } //Length: 28
		}

		public Edge() { }

		internal static void EnsureFirst(ref Edge e) { }

		internal Edge get__Dnext() { }

		internal Edge get__Dprev() { }

		internal Vertex get__Dst() { }

		internal Edge get__Lprev() { }

		internal Edge get__Oprev() { }

		internal Face get__Rface() { }

		internal Edge get__Rnext() { }

		internal Edge get__Rprev() { }

		public virtual void Reset() { }

		internal void set__Dnext(Edge value) { }

		internal void set__Dprev(Edge value) { }

		internal void set__Dst(Vertex value) { }

		internal void set__Lprev(Edge value) { }

		internal void set__Oprev(Edge value) { }

		internal void set__Rface(Face value) { }

		internal void set__Rnext(Edge value) { }

		internal void set__Rprev(Edge value) { }

	}

	internal struct EdgePair
	{
		internal Edge _e; //Field offset: 0x0
		internal Edge _eSym; //Field offset: 0x8

		public static EdgePair Create() { }

		public void Reset() { }

	}

	internal class Face : Pooled<Face>
	{
		internal Face _prev; //Field offset: 0x10
		internal Face _next; //Field offset: 0x18
		internal Edge _anEdge; //Field offset: 0x20
		internal Face _trail; //Field offset: 0x28
		internal int _n; //Field offset: 0x30
		internal bool _marked; //Field offset: 0x34
		internal bool _inside; //Field offset: 0x35

		internal int VertsCount
		{
			internal get { } //Length: 52
		}

		public Face() { }

		internal int get_VertsCount() { }

		public virtual void Reset() { }

	}

	internal abstract class Pooled
	{
		private static Stack<T> _stack; //Field offset: 0x0

		protected Pooled`1() { }

		public static T Create() { }

		public void Free() { }

		public override void OnFree() { }

		public abstract void Reset() { }

	}

	internal class Vertex : Pooled<Vertex>
	{
		internal Vertex _prev; //Field offset: 0x10
		internal Vertex _next; //Field offset: 0x18
		internal Edge _anEdge; //Field offset: 0x20
		internal Vec3 _coords; //Field offset: 0x28
		internal float _s; //Field offset: 0x34
		internal float _t; //Field offset: 0x38
		internal PQHandle _pqHandle; //Field offset: 0x3C
		internal int _n; //Field offset: 0x40
		internal object _data; //Field offset: 0x48

		public Vertex() { }

		public virtual void Reset() { }

	}

	public const int Undef = -1; //Field offset: 0x0

	public static float FaceArea(Face f) { }

	public static void KillEdge(Edge eDel) { }

	public static void KillFace(Face fDel, Face newLFace) { }

	public static void KillVertex(Vertex vDel, Vertex newOrg) { }

	public static Edge MakeEdge(Edge eNext) { }

	public static void MakeFace(Edge eOrig, Face fNext) { }

	public static void MakeVertex(Edge eOrig, Vertex vNext) { }

	public static void Splice(Edge a, Edge b) { }

}

