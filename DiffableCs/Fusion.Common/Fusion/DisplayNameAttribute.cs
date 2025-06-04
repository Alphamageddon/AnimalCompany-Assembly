namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public class DisplayNameAttribute : DecoratingPropertyAttribute
{
	public readonly string Name; //Field offset: 0x18

	public DisplayNameAttribute(string name) { }

}

