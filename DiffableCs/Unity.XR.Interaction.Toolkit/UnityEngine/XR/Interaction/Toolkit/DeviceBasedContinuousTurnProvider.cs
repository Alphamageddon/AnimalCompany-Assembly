namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Continuous Turn Provider (Device-based)", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.DeviceBasedContinuousTurnProvider.html")]
public class DeviceBasedContinuousTurnProvider : ContinuousTurnProviderBase
{
	internal enum InputAxes
	{
		Primary2DAxis = 0,
		Secondary2DAxis = 1,
	}

	private static readonly InputFeatureUsage<Vector2>[] k_Vec2UsageList; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The 2D Input Axis on the controller devices that will be used to trigger a turn.")]
	private InputAxes m_InputBinding; //Field offset: 0x50
	[SerializeField]
	[Tooltip("A list of controllers that allow Turn.  If an XRController is not enabled, or does not have input actions enabled, turn will not work.")]
	private List<XRBaseController> m_Controllers; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Value below which input values will be clamped. After clamping, values will be renormalized to [0, 1] between min and max.")]
	private float m_DeadzoneMin; //Field offset: 0x60
	[SerializeField]
	[Tooltip("Value above which input values will be clamped. After clamping, values will be renormalized to [0, 1] between min and max.")]
	private float m_DeadzoneMax; //Field offset: 0x64

	public List<XRBaseController> controllers
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float deadzoneMax
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float deadzoneMin
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public InputAxes inputBinding
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	private static DeviceBasedContinuousTurnProvider() { }

	public DeviceBasedContinuousTurnProvider() { }

	public List<XRBaseController> get_controllers() { }

	public float get_deadzoneMax() { }

	public float get_deadzoneMin() { }

	public InputAxes get_inputBinding() { }

	protected Vector2 GetDeadzoneAdjustedValue(Vector2 value) { }

	protected float GetDeadzoneAdjustedValue(float value) { }

	protected virtual Vector2 ReadInput() { }

	public void set_controllers(List<XRBaseController> value) { }

	public void set_deadzoneMax(float value) { }

	public void set_deadzoneMin(float value) { }

	public void set_inputBinding(InputAxes value) { }

}

