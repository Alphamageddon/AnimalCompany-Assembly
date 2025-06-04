namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[Extension]
internal static class TargetedDevicesExtensions
{

	[Extension]
	public static bool HasDevice(TargetedDevices devices, TargetedDevices device) { }

	[Extension]
	public static TargetedDevices WithDevice(TargetedDevices devices, TargetedDevices device) { }

	[Extension]
	public static TargetedDevices WithoutDevice(TargetedDevices devices, TargetedDevices device) { }

}

