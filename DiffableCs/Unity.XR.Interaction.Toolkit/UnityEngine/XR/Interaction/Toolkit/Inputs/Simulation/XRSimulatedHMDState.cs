namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public struct XRSimulatedHMDState : IInputStateTypeInfo
{
	[InputControl(usage = "LeftEyePosition", offset = 0)]
	public Vector3 leftEyePosition; //Field offset: 0x0
	[InputControl(usage = "LeftEyeRotation", offset = 12)]
	public Quaternion leftEyeRotation; //Field offset: 0xC
	[InputControl(usage = "RightEyePosition", offset = 28)]
	public Vector3 rightEyePosition; //Field offset: 0x1C
	[InputControl(usage = "RightEyeRotation", offset = 40)]
	public Quaternion rightEyeRotation; //Field offset: 0x28
	[InputControl(usage = "CenterEyePosition", offset = 56)]
	public Vector3 centerEyePosition; //Field offset: 0x38
	[InputControl(usage = "CenterEyeRotation", offset = 68)]
	public Quaternion centerEyeRotation; //Field offset: 0x44
	[InputControl(usage = "TrackingState", layout = "Integer", offset = 84)]
	public int trackingState; //Field offset: 0x54
	[InputControl(usage = "IsTracked", layout = "Button", offset = 88)]
	public bool isTracked; //Field offset: 0x58
	[InputControl(usage = "DevicePosition", offset = 89)]
	public Vector3 devicePosition; //Field offset: 0x59
	[InputControl(usage = "DeviceRotation", offset = 101)]
	public Quaternion deviceRotation; //Field offset: 0x65

	public override FourCC format
	{
		 get { } //Length: 48
	}

	public static FourCC formatId
	{
		 get { } //Length: 48
	}

	public override FourCC get_format() { }

	public static FourCC get_formatId() { }

	public void Reset() { }

}

