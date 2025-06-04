namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Controller (Device-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRController.html")]
public class XRController : XRBaseController
{
	[SerializeField]
	private XRNode m_ControllerNode; //Field offset: 0xA4
	private XRNode m_InputDeviceControllerNode; //Field offset: 0xA8
	[SerializeField]
	private Button m_SelectUsage; //Field offset: 0xAC
	[SerializeField]
	private Button m_ActivateUsage; //Field offset: 0xB0
	[SerializeField]
	private Button m_UIPressUsage; //Field offset: 0xB4
	[SerializeField]
	private float m_AxisToPressThreshold; //Field offset: 0xB8
	[SerializeField]
	private Button m_RotateAnchorLeft; //Field offset: 0xBC
	[SerializeField]
	private Button m_RotateAnchorRight; //Field offset: 0xC0
	[SerializeField]
	private Button m_MoveObjectIn; //Field offset: 0xC4
	[SerializeField]
	private Button m_MoveObjectOut; //Field offset: 0xC8
	[SerializeField]
	private Axis2D m_DirectionalAnchorRotation; //Field offset: 0xCC
	[SerializeField]
	private BasePoseProvider m_PoseProvider; //Field offset: 0xD0
	private InputDevice m_InputDevice; //Field offset: 0xD8

	public Button activateUsage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float axisToPressThreshold
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRNode controllerNode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Axis2D directionalAnchorRotation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputDevice inputDevice
	{
		 get { } //Length: 76
	}

	public Button moveObjectIn
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Button moveObjectOut
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public BasePoseProvider poseProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Button rotateObjectLeft
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Button rotateObjectRight
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Button selectUsage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Button uiPressUsage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRController() { }

	public Button get_activateUsage() { }

	public float get_axisToPressThreshold() { }

	public XRNode get_controllerNode() { }

	public Axis2D get_directionalAnchorRotation() { }

	public InputDevice get_inputDevice() { }

	public Button get_moveObjectIn() { }

	public Button get_moveObjectOut() { }

	public BasePoseProvider get_poseProvider() { }

	public Button get_rotateObjectLeft() { }

	public Button get_rotateObjectRight() { }

	public Button get_selectUsage() { }

	public Button get_uiPressUsage() { }

	protected override bool IsPressed(Button button) { }

	protected override float ReadValue(Button button) { }

	public virtual bool SendHapticImpulse(float amplitude, float duration) { }

	public void set_activateUsage(Button value) { }

	public void set_axisToPressThreshold(float value) { }

	public void set_controllerNode(XRNode value) { }

	public void set_directionalAnchorRotation(Axis2D value) { }

	public void set_moveObjectIn(Button value) { }

	public void set_moveObjectOut(Button value) { }

	public void set_poseProvider(BasePoseProvider value) { }

	public void set_rotateObjectLeft(Button value) { }

	public void set_rotateObjectRight(Button value) { }

	public void set_selectUsage(Button value) { }

	public void set_uiPressUsage(Button value) { }

	protected virtual void UpdateInput(XRControllerState controllerState) { }

	protected virtual void UpdateTrackingInput(XRControllerState controllerState) { }

}

