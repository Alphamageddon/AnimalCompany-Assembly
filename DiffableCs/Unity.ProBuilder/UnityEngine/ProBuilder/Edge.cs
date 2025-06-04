namespace UnityEngine.ProBuilder;

public struct Edge : IEquatable<Edge>
{
	public static readonly Edge Empty; //Field offset: 0x0
	public int a; //Field offset: 0x0
	public int b; //Field offset: 0x4

	private static Edge() { }

	public Edge(int a, int b) { }

	public static Edge Add(Edge a, Edge b) { }

	internal bool Contains(int index, Dictionary<Int32, Int32> lookup) { }

	public bool Contains(Edge other) { }

	public bool Contains(int index) { }

	public override bool Equals(Edge other) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(Edge other, Dictionary<Int32, Int32> lookup) { }

	public virtual int GetHashCode() { }

	internal static void GetIndices(IEnumerable<Edge> edges, List<Int32> indices) { }

	public bool IsValid() { }

	public static Edge op_Addition(Edge a, Edge b) { }

	public static Edge op_Addition(Edge a, int b) { }

	public static bool op_Equality(Edge a, Edge b) { }

	public static bool op_Inequality(Edge a, Edge b) { }

	public static Edge op_Subtraction(Edge a, int b) { }

	public static Edge op_Subtraction(Edge a, Edge b) { }

	public static Edge Subtract(Edge a, Edge b) { }

	public virtual string ToString() { }

}

