namespace Fusion;

public abstract class DecoratingPropertyAttribute : PropertyAttribute
{
	public const int DefaultOrder = -10000; //Field offset: 0x0

	protected DecoratingPropertyAttribute() { }

	protected DecoratingPropertyAttribute(int order) { }

}

