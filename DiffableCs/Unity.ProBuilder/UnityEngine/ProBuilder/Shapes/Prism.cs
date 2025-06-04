namespace UnityEngine.ProBuilder.Shapes;

[Shape("Prism")]
public class Prism : Shape
{

	public Prism() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

