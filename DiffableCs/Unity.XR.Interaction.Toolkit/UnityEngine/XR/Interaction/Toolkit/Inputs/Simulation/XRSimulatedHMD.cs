namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

[InputControlLayout(stateType = typeof(XRSimulatedHMDState), isGenericTypeOfDevice = False, displayName = "XR Simulated HMD", updateBeforeRender = True)]
[Preserve]
public class XRSimulatedHMD : XRHMD
{

	public XRSimulatedHMD() { }

	protected virtual long ExecuteCommand(InputDeviceCommand* commandPtr) { }

}

