namespace Fusion.XR.Host.Rig;

[RequireComponent(typeof(NetworkTransform))]
public class NetworkHeadset : NetworkBehaviour
{
	[HideInInspector]
	public NetworkTransform networkTransform; //Field offset: 0x80

	public NetworkHeadset() { }

	private void Awake() { }

}

