namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Grab Move Provider", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.GrabMoveProvider.html")]
public class GrabMoveProvider : ConstrainedMoveProvider
{
	[SerializeField]
	[Tooltip("The controller Transform that will drive grab movement with its local position. Will use this GameObject's Transform if not set.")]
	private Transform m_ControllerTransform; //Field offset: 0x68
	[SerializeField]
	[Tooltip("Controls whether to allow grab move locomotion while the controller is selecting an interactable.")]
	private bool m_EnableMoveWhileSelecting; //Field offset: 0x70
	[SerializeField]
	[Tooltip("The ratio of actual movement distance to controller movement distance.")]
	private float m_MoveFactor; //Field offset: 0x74
	[SerializeField]
	[Tooltip("The Input System Action that will be used to perform grab movement while held. Must be a Button Control.")]
	private InputActionProperty m_GrabMoveAction; //Field offset: 0x78
	[CompilerGenerated]
	private bool <canMove>k__BackingField; //Field offset: 0x90
	private bool m_IsMoving; //Field offset: 0x91
	private Vector3 m_PreviousControllerLocalPosition; //Field offset: 0x94
	private readonly List<IXRSelectInteractor> m_ControllerInteractors; //Field offset: 0xA0

	public bool canMove
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Transform controllerTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool enableMoveWhileSelecting
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputActionProperty grabMoveAction
	{
		 get { } //Length: 20
		 set { } //Length: 48
	}

	public float moveFactor
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public GrabMoveProvider() { }

	protected virtual void Awake() { }

	protected virtual Vector3 ComputeDesiredMove(out bool attemptingMove) { }

	private bool ControllerHasSelection() { }

	private void GatherControllerInteractors() { }

	[CompilerGenerated]
	public bool get_canMove() { }

	public Transform get_controllerTransform() { }

	public bool get_enableMoveWhileSelecting() { }

	public InputActionProperty get_grabMoveAction() { }

	public float get_moveFactor() { }

	public bool IsGrabbing() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	public void set_canMove(bool value) { }

	public void set_controllerTransform(Transform value) { }

	public void set_enableMoveWhileSelecting(bool value) { }

	public void set_grabMoveAction(InputActionProperty value) { }

	public void set_moveFactor(float value) { }

	private void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value) { }

}

