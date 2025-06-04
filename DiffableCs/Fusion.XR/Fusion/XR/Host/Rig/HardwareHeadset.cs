namespace Fusion.XR.Host.Rig;

public class HardwareHeadset : MonoBehaviour
{
	public Fader fader; //Field offset: 0x20
	public NetworkTransform networkTransform; //Field offset: 0x28

	public HardwareHeadset() { }

	private void Awake() { }

}

