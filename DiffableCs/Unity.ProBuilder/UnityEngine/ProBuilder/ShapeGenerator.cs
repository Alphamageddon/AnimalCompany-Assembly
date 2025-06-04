namespace UnityEngine.ProBuilder;

public static class ShapeGenerator
{
	private static readonly Vector3[] k_IcosphereVertices; //Field offset: 0x0
	private static readonly Int32[] k_IcosphereTriangles; //Field offset: 0x8
	private static readonly Vector3[] k_CubeVertices; //Field offset: 0x10
	private static readonly Int32[] k_CubeTriangles; //Field offset: 0x18

	private static ShapeGenerator() { }

	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType = 0) { }

	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1) { }

	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices = true, bool manualUvs = true) { }

	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs = false) { }

	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

}

