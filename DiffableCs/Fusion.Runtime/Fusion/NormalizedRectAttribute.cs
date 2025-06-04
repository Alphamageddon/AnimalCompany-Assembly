namespace Fusion;

public class NormalizedRectAttribute : PropertyAttribute
{
	public bool InvertY; //Field offset: 0x14
	public float AspectRatio; //Field offset: 0x18

	public NormalizedRectAttribute(bool invertY = true, float aspectRatio = 0) { }

}

