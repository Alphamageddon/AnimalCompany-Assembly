namespace Fusion;

[AttributeUsage(AttributeTargets::Field (256))]
public class HideArrayElementLabelAttribute : DecoratingPropertyAttribute
{
	private const int DefaultOrder = -11000; //Field offset: 0x0

	public HideArrayElementLabelAttribute() { }

}

