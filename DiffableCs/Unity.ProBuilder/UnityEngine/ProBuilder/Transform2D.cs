namespace UnityEngine.ProBuilder;

internal sealed class Transform2D
{
	public Vector2 position; //Field offset: 0x10
	public float rotation; //Field offset: 0x18
	public Vector2 scale; //Field offset: 0x1C

	public Transform2D(Vector2 position, float rotation, Vector2 scale) { }

	public virtual string ToString() { }

	public Vector2 TransformPoint(Vector2 p) { }

}

