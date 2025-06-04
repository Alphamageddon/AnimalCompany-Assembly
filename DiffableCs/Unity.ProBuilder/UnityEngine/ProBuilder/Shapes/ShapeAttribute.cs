namespace UnityEngine.ProBuilder.Shapes;

[AttributeUsage(AttributeTargets::Class (4))]
public class ShapeAttribute : Attribute
{
	public string name; //Field offset: 0x10

	public ShapeAttribute(string n) { }

}

