namespace SpatialSys.ObservableState;

[AttributeUsage(AttributeTargets::Property (128))]
public class NonSerializedStateAttribute : Attribute
{

	public NonSerializedStateAttribute() { }

}

