namespace Fusion.XR.Host.Rig;

public struct HandCommand : INetworkStruct
{
	public float thumbTouchedCommand; //Field offset: 0x0
	public float indexTouchedCommand; //Field offset: 0x4
	public float gripCommand; //Field offset: 0x8
	public float triggerCommand; //Field offset: 0xC
	public int poseCommand; //Field offset: 0x10
	public float pinchCommand; //Field offset: 0x14

}

