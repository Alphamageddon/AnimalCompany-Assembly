namespace Fusion.XR.Host.Rig;

public struct RigInput : INetworkInput
{
	public Vector3 playAreaPosition; //Field offset: 0x0
	public Quaternion playAreaRotation; //Field offset: 0xC
	public Vector3 leftHandPosition; //Field offset: 0x1C
	public Quaternion leftHandRotation; //Field offset: 0x28
	public Vector3 rightHandPosition; //Field offset: 0x38
	public Quaternion rightHandRotation; //Field offset: 0x44
	public Vector3 headsetPosition; //Field offset: 0x54
	public Quaternion headsetRotation; //Field offset: 0x60
	public HandCommand leftHandCommand; //Field offset: 0x70
	public HandCommand rightHandCommand; //Field offset: 0x88
	public GrabInfo leftGrabInfo; //Field offset: 0xA0
	public GrabInfo rightGrabInfo; //Field offset: 0xF8

}

