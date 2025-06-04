namespace UnityEngine.ProBuilder.Shapes;

public abstract class Shape
{

	protected Shape() { }

	public abstract void CopyShape(Shape shape) { }

	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

}

