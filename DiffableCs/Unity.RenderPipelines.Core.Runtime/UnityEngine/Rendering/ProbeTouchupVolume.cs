namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Probe Volume Touchup")]
[ExecuteAlways]
public class ProbeTouchupVolume : MonoBehaviour
{
	[Range(0.0001, 2)]
	public float intensityScale; //Field offset: 0x20
	public bool invalidateProbes; //Field offset: 0x24
	public bool overrideDilationThreshold; //Field offset: 0x25
	[Range(0, 0.99)]
	public float overriddenDilationThreshold; //Field offset: 0x28
	public Vector3 size; //Field offset: 0x2C

	public ProbeTouchupVolume() { }

}

