namespace UnityEngine.ProBuilder.Shapes;

[Shape("Sprite")]
public class Sprite : Shape
{

	public Sprite() { }

	public virtual void CopyShape(Shape shape) { }

	public virtual Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

}

