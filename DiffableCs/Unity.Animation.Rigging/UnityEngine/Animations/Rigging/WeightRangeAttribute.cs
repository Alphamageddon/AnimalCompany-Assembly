namespace UnityEngine.Animations.Rigging;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class WeightRangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x14
	public readonly float max; //Field offset: 0x18

	public WeightRangeAttribute(float min, float max) { }

}

