namespace MagicLightProbes;

public class MLPTracePoint
{
	public Vector3 position; //Field offset: 0x10
	public Vector3 forward; //Field offset: 0x1C
	public string name; //Field offset: 0x28
	public GameObject pointGameObject; //Field offset: 0x30

	public MLPTracePoint() { }

}

