namespace UnityEngine.XR.Interaction.Toolkit;

public class XRControllerState
{
	public double time; //Field offset: 0x10
	public InputTrackingState inputTrackingState; //Field offset: 0x18
	public bool isTracked; //Field offset: 0x1C
	public Vector3 position; //Field offset: 0x20
	public Quaternion rotation; //Field offset: 0x2C
	public InteractionState selectInteractionState; //Field offset: 0x3C
	public InteractionState activateInteractionState; //Field offset: 0x44
	public InteractionState uiPressInteractionState; //Field offset: 0x4C
	public Vector2 uiScrollValue; //Field offset: 0x54

	[Obsolete("poseDataFlags has been deprecated. Use inputTrackingState instead.")]
	public PoseDataFlags poseDataFlags
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	protected XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked) { }

	public XRControllerState() { }

	public XRControllerState(XRControllerState value) { }

	public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked, bool selectActive, bool activateActive, bool pressActive) { }

	public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked, bool selectActive, bool activateActive, bool pressActive, float selectValue, float activateValue, float pressValue) { }

	[Obsolete("This constructor has been deprecated. Use the constructors with the inputTrackingState parameter.")]
	public XRControllerState(double time, Vector3 position, Quaternion rotation, bool selectActive, bool activateActive, bool pressActive) { }

	[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.")]
	protected XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState) { }

	[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.")]
	public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool selectActive, bool activateActive, bool pressActive) { }

	[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.")]
	public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool selectActive, bool activateActive, bool pressActive, float selectValue, float activateValue, float pressValue) { }

	public PoseDataFlags get_poseDataFlags() { }

	public void ResetFrameDependentStates() { }

	[Obsolete("ResetInputs has been renamed. Use ResetFrameDependentStates instead. (UnityUpgradable) -> ResetFrameDependentStates()")]
	public void ResetInputs() { }

	public void set_poseDataFlags(PoseDataFlags value) { }

	public virtual string ToString() { }

}

