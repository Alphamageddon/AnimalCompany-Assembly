namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Snap Turn Provider (Device-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.html")]
public class DeviceBasedSnapTurnProvider : SnapTurnProviderBase
{
	internal enum InputAxes
	{
		Primary2DAxis = 0,
		Secondary2DAxis = 1,
	}

	private static readonly InputFeatureUsage<Vector2>[] k_Vec2UsageList; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The 2D Input Axis on the controller devices that will be used to trigger a snap turn.")]
	private InputAxes m_TurnUsage; //Field offset: 0x64
	[SerializeField]
	[Tooltip("A list of controllers that allow Snap Turn.  If an XRController is not enabled, or does not have input actions enabled, snap turn will not work.")]
	private List<XRBaseController> m_Controllers; //Field offset: 0x68
	[SerializeField]
	[Tooltip("The deadzone that the controller movement will have to be above to trigger a snap turn.")]
	private float m_DeadZone; //Field offset: 0x70

	public List<XRBaseController> controllers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float deadZone
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputAxes turnUsage
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static DeviceBasedSnapTurnProvider() { }

	public DeviceBasedSnapTurnProvider() { }

	public List<XRBaseController> get_controllers() { }

	public float get_deadZone() { }

	public InputAxes get_turnUsage() { }

	protected virtual Vector2 ReadInput() { }

	public void set_controllers(List<XRBaseController> value) { }

	public void set_deadZone(float value) { }

	public void set_turnUsage(InputAxes value) { }

}

