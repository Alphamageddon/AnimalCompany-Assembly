namespace AnimalCompany;

[NetworkInputWeaved(42)]
public struct NetPlayerInput : INetworkInput
{
	public Vector3 bodyPosition; //Field offset: 0x0
	public Quaternion bodyRotation; //Field offset: 0xC
	public Vector3 headPosition; //Field offset: 0x1C
	public Quaternion headRotation; //Field offset: 0x28
	public Vector3 rightHandPosition; //Field offset: 0x38
	public Quaternion rightHandRotation; //Field offset: 0x44
	public Vector3 leftHandPosition; //Field offset: 0x54
	public Quaternion leftHandRotation; //Field offset: 0x60
	public Vector3 leftControllerPosition; //Field offset: 0x70
	public Quaternion leftControllerRotation; //Field offset: 0x7C
	public Vector3 rightControllerPosition; //Field offset: 0x8C
	public Quaternion rightControllerRotation; //Field offset: 0x98

}

