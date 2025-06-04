namespace UnityEngine.XR.Interaction.Toolkit.UI;

[DefaultExecutionOrder(-200)]
public abstract class UIInputModule : BaseInputModule
{
	[FormerlySerializedAs("clickSpeed")]
	[Header("Configuration")]
	[SerializeField]
	[Tooltip("The maximum time (in seconds) between two mouse presses for it to be consecutive click.")]
	private float m_ClickSpeed; //Field offset: 0x58
	[FormerlySerializedAs("moveDeadzone")]
	[SerializeField]
	[Tooltip("The absolute value required by a move action on either axis required to trigger a move event.")]
	private float m_MoveDeadzone; //Field offset: 0x5C
	[FormerlySerializedAs("repeatDelay")]
	[SerializeField]
	[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
	private float m_RepeatDelay; //Field offset: 0x60
	[FormerlySerializedAs("repeatRate")]
	[SerializeField]
	[Tooltip("The speed (in seconds) that the move action repeats itself once repeating.")]
	private float m_RepeatRate; //Field offset: 0x64
	[FormerlySerializedAs("trackedDeviceDragThresholdMultiplier")]
	[SerializeField]
	[Tooltip("Scales the EventSystem.pixelDragThreshold, for tracked devices, to make selection easier.")]
	private float m_TrackedDeviceDragThresholdMultiplier; //Field offset: 0x68
	[SerializeField]
	[Tooltip("Scales the scrollDelta in event data, for tracked devices, to scroll at an expected speed.")]
	private float m_TrackedScrollDeltaMultiplier; //Field offset: 0x6C
	private Camera m_UICamera; //Field offset: 0x70
	private Camera m_MainCameraCache; //Field offset: 0x78
	private AxisEventData m_CachedAxisEvent; //Field offset: 0x80
	private readonly Dictionary<Int32, PointerEventData> m_PointerEventByPointerId; //Field offset: 0x88
	private readonly Dictionary<Int32, TrackedDeviceEventData> m_TrackedDeviceEventByPointerId; //Field offset: 0x90
	[CompilerGenerated]
	private Action<PointerEventData, List`1<RaycastResult>> finalizeRaycastResults; //Field offset: 0x98
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerEnter; //Field offset: 0xA0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerExit; //Field offset: 0xA8
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerDown; //Field offset: 0xB0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerUp; //Field offset: 0xB8
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerClick; //Field offset: 0xC0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> pointerMove; //Field offset: 0xC8
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> initializePotentialDrag; //Field offset: 0xD0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> beginDrag; //Field offset: 0xD8
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> drag; //Field offset: 0xE0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> endDrag; //Field offset: 0xE8
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> drop; //Field offset: 0xF0
	[CompilerGenerated]
	private Action<GameObject, PointerEventData> scroll; //Field offset: 0xF8
	[CompilerGenerated]
	private Action<GameObject, BaseEventData> updateSelected; //Field offset: 0x100
	[CompilerGenerated]
	private Action<GameObject, AxisEventData> move; //Field offset: 0x108
	[CompilerGenerated]
	private Action<GameObject, BaseEventData> submit; //Field offset: 0x110
	[CompilerGenerated]
	private Action<GameObject, BaseEventData> cancel; //Field offset: 0x118

	public event Action<GameObject, PointerEventData> beginDrag
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, BaseEventData> cancel
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public event Action<GameObject, PointerEventData> drag
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> drop
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> endDrag
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<PointerEventData, List`1<RaycastResult>> finalizeRaycastResults
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> initializePotentialDrag
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, AxisEventData> move
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public event Action<GameObject, PointerEventData> pointerClick
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> pointerDown
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> pointerEnter
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> pointerExit
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> pointerMove
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> pointerUp
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, PointerEventData> scroll
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<GameObject, BaseEventData> submit
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public event Action<GameObject, BaseEventData> updateSelected
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public float clickSpeed
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float moveDeadzone
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float repeatDelay
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float repeatRate
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float trackedDeviceDragThresholdMultiplier
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float trackedScrollDeltaMultiplier
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Camera uiCamera
	{
		 get { } //Length: 200
		 set { } //Length: 8
	}

	protected UIInputModule() { }

	public virtual void ActivateModule() { }

	[CompilerGenerated]
	public void add_beginDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_cancel(Action<GameObject, BaseEventData> value) { }

	[CompilerGenerated]
	public void add_drag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_drop(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_endDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_finalizeRaycastResults(Action<PointerEventData, List`1<RaycastResult>> value) { }

	[CompilerGenerated]
	public void add_initializePotentialDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_move(Action<GameObject, AxisEventData> value) { }

	[CompilerGenerated]
	public void add_pointerClick(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_pointerDown(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_pointerEnter(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_pointerExit(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_pointerMove(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_pointerUp(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_scroll(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void add_submit(Action<GameObject, BaseEventData> value) { }

	[CompilerGenerated]
	public void add_updateSelected(Action<GameObject, BaseEventData> value) { }

	protected override void DoProcess() { }

	public float get_clickSpeed() { }

	public float get_moveDeadzone() { }

	public float get_repeatDelay() { }

	public float get_repeatRate() { }

	public float get_trackedDeviceDragThresholdMultiplier() { }

	public float get_trackedScrollDeltaMultiplier() { }

	public Camera get_uiCamera() { }

	public GameObject GetCurrentGameObject(int pointerId) { }

	private AxisEventData GetOrCreateCachedAxisEvent() { }

	private PointerEventData GetOrCreateCachedPointerEvent(int pointerId) { }

	private TrackedDeviceEventData GetOrCreateCachedTrackedDeviceEvent(int pointerId) { }

	public virtual bool IsPointerOverGameObject(int pointerId) { }

	private RaycastResult PerformRaycast(PointerEventData eventData) { }

	public virtual void Process() { }

	internal void ProcessMouseState(ref MouseModel mouseState) { }

	internal void ProcessNavigationState(ref NavigationModel navigationState) { }

	private void ProcessPointerButton(ButtonDeltaState mouseButtonChanges, PointerEventData eventData) { }

	private void ProcessPointerButtonDrag(PointerEventData eventData, UIPointerType pointerType, float pixelDragThresholdMultiplier = 1) { }

	private void ProcessPointerMovement(PointerEventData eventData) { }

	private void ProcessScrollWheel(PointerEventData eventData) { }

	internal void ProcessTouch(ref TouchModel touchState) { }

	internal void ProcessTrackedDevice(ref TrackedDeviceModel deviceState, bool force = false) { }

	[CompilerGenerated]
	public void remove_beginDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_cancel(Action<GameObject, BaseEventData> value) { }

	[CompilerGenerated]
	public void remove_drag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_drop(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_endDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_finalizeRaycastResults(Action<PointerEventData, List`1<RaycastResult>> value) { }

	[CompilerGenerated]
	public void remove_initializePotentialDrag(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_move(Action<GameObject, AxisEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerClick(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerDown(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerEnter(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerExit(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerMove(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_pointerUp(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_scroll(Action<GameObject, PointerEventData> value) { }

	[CompilerGenerated]
	public void remove_submit(Action<GameObject, BaseEventData> value) { }

	[CompilerGenerated]
	public void remove_updateSelected(Action<GameObject, BaseEventData> value) { }

	internal void RemovePointerEventData(int pointerId) { }

	protected bool SendUpdateEventToSelectedObject() { }

	public void set_clickSpeed(float value) { }

	public void set_moveDeadzone(float value) { }

	public void set_repeatDelay(float value) { }

	public void set_repeatRate(float value) { }

	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	public void set_trackedScrollDeltaMultiplier(float value) { }

	public void set_uiCamera(Camera value) { }

	private bool TryGetCamera(PointerEventData eventData, out Camera screenPointCamera) { }

	protected override void Update() { }

}

