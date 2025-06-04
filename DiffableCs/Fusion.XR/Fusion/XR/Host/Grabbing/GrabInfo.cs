namespace Fusion.XR.Host.Grabbing;

public struct GrabInfo : INetworkStruct
{
	public NetworkBehaviourId grabbedObjectId; //Field offset: 0x0
	public Vector3 localPositionOffset; //Field offset: 0x8
	public Quaternion localRotationOffset; //Field offset: 0x14
	public Vector3 ungrabPosition; //Field offset: 0x24
	public Quaternion ungrabRotation; //Field offset: 0x30
	public Vector3 ungrabVelocity; //Field offset: 0x40
	public Vector3 ungrabAngularVelocity; //Field offset: 0x4C

}

