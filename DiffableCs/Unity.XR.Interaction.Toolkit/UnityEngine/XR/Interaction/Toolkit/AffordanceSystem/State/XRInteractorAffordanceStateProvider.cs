namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

[AddComponentMenu("Affordance System/XR Interactor Affordance State Provider", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State.XRInteractorAffordanceStateProvider.html")]
public class XRInteractorAffordanceStateProvider : BaseAffordanceStateProvider
{
	[CompilerGenerated]
	private sealed class <ClickAnimation>d__96 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public XRInteractorAffordanceStateProvider <>4__this; //Field offset: 0x28
		public byte targetStateIndex; //Field offset: 0x30
		public Action onComplete; //Field offset: 0x38
		private float <elapsedTime>5__2; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <ClickAnimation>d__96(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UIUpdateCheckCoroutine>d__97 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XRInteractorAffordanceStateProvider <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <UIUpdateCheckCoroutine>d__97(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum ActivateClickAnimationMode
	{
		None = 0,
		Activated = 1,
		Deactivated = 2,
	}

	internal enum SelectClickAnimationMode
	{
		None = 0,
		SelectEntered = 1,
		SelectExited = 2,
	}

	[RequireInterface(typeof(IXRInteractor))]
	[SerializeField]
	[Tooltip("The interactor component that drives the affordance states. If null, Unity will try and find an interactor component attached.")]
	private object m_InteractorSource; //Field offset: 0x60
	[Header("Event Constraints")]
	[SerializeField]
	[Tooltip("When hover events are registered and this is true, the state will fallback to idle or disabled.")]
	private bool m_IgnoreHoverEvents; //Field offset: 0x68
	[SerializeField]
	[Tooltip("When select events are registered and this is true, the state will fallback to idle or disabled. \nNote: Click animations must be disabled separately.")]
	private bool m_IgnoreSelectEvents; //Field offset: 0x69
	[SerializeField]
	[Tooltip("When activate events are registered and this is true, the state will fallback to idle or disabled.\nNote: Click animations must be disabled separately.")]
	private bool m_IgnoreActivateEvents; //Field offset: 0x6A
	[SerializeField]
	[Tooltip("With the XR Ray Interactor it is possible to trigger select events from the ray interactor overlapping with a canvas.")]
	private bool m_IgnoreUGUIHover; //Field offset: 0x6B
	[SerializeField]
	[Tooltip("With the XR Ray Interactor it is possible to trigger select events from the ray interactor overlapping with a canvas and triggering the select input.")]
	private bool m_IgnoreUGUISelect; //Field offset: 0x6C
	[SerializeField]
	[Tooltip("This option will prevent Hover, Select, and Activate events from being triggered when they come from the XR Interaction Manager. UGUI hover and select events will still come through.")]
	private bool m_IgnoreXRInteractionEvents; //Field offset: 0x6D
	[Header("Click Animation Config")]
	[SerializeField]
	[Tooltip("Condition to trigger click animation for Selected interaction events.")]
	private SelectClickAnimationMode m_SelectClickAnimationMode; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Condition to trigger click animation for activated interaction events.")]
	private ActivateClickAnimationMode m_ActivateClickAnimationMode; //Field offset: 0x74
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Duration of click animations for selected and activated events.")]
	private float m_ClickAnimationDuration; //Field offset: 0x78
	[SerializeField]
	[Tooltip("Animation curve reference for click animation events. Select the More menu (⋮) to choose between a direct reference and a reusable asset.")]
	private AnimationCurveDatumProperty m_ClickAnimationCurve; //Field offset: 0x80
	private IXRInteractor m_Interactor; //Field offset: 0x88
	private IXRHoverInteractor m_HoverInteractor; //Field offset: 0x90
	private IXRSelectInteractor m_SelectInteractor; //Field offset: 0x98
	private IXRInteractionStrengthInteractor m_InteractionStrengthInteractor; //Field offset: 0xA0
	private XRRayInteractor m_RayInteractor; //Field offset: 0xA8
	private bool m_IsBoundToInteractionEvents; //Field offset: 0xB0
	private bool m_HasRayInteractor; //Field offset: 0xB1
	private bool m_HasHoverInteractor; //Field offset: 0xB2
	private bool m_HasSelectInteractor; //Field offset: 0xB3
	private bool m_HasInteractionStrengthInteractor; //Field offset: 0xB4
	private bool m_IsIXRInteractor; //Field offset: 0xB5
	private Coroutine m_SelectedClickAnimation; //Field offset: 0xB8
	private Coroutine m_ActivatedClickAnimation; //Field offset: 0xC0
	private bool m_IsActivated; //Field offset: 0xC8
	private bool m_IsRegistered; //Field offset: 0xC9
	private readonly HashSet<IXRActivateInteractable> m_BoundActivateInteractable; //Field offset: 0xD0
	private bool m_UIHovering; //Field offset: 0xD8
	private bool m_UISelecting; //Field offset: 0xD9
	private Coroutine m_UGUIUpdateCoroutine; //Field offset: 0xE0

	public ActivateClickAnimationMode activateClickAnimationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AnimationCurveDatumProperty clickAnimationCurve
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float clickAnimationDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected override bool hasUIHover
	{
		 get { } //Length: 32
	}

	protected override bool hasUISelection
	{
		 get { } //Length: 32
	}

	protected override bool hasXRHover
	{
		 get { } //Length: 196
	}

	protected override bool hasXRSelection
	{
		 get { } //Length: 196
	}

	public bool ignoreActivateEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreHoverEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreSelectEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreUGUIHover
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreUGUISelect
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreXRInteractionEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public object interactorSource
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	protected override bool isActivated
	{
		 get { } //Length: 32
	}

	protected override bool isBlockedByGroup
	{
		 get { } //Length: 40
	}

	protected override bool isRegistered
	{
		 get { } //Length: 8
	}

	public SelectClickAnimationMode selectClickAnimationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRInteractorAffordanceStateProvider() { }

	[CompilerGenerated]
	private void <ActivatedClickBehavior>b__95_0() { }

	[CompilerGenerated]
	private void <SelectedClickBehavior>b__94_0() { }

	protected override void ActivatedClickBehavior() { }

	protected void Awake() { }

	protected virtual void BindToProviders() { }

	protected virtual void ClearBindings() { }

	[IteratorStateMachine(typeof(<ClickAnimation>d__96))]
	protected override IEnumerator ClickAnimation(byte targetStateIndex, float duration, Action onComplete = null) { }

	protected override AffordanceStateData GenerateNewAffordanceState() { }

	public ActivateClickAnimationMode get_activateClickAnimationMode() { }

	public AnimationCurveDatumProperty get_clickAnimationCurve() { }

	public float get_clickAnimationDuration() { }

	protected override bool get_hasUIHover() { }

	protected override bool get_hasUISelection() { }

	protected override bool get_hasXRHover() { }

	protected override bool get_hasXRSelection() { }

	public bool get_ignoreActivateEvents() { }

	public bool get_ignoreHoverEvents() { }

	public bool get_ignoreSelectEvents() { }

	public bool get_ignoreUGUIHover() { }

	public bool get_ignoreUGUISelect() { }

	public bool get_ignoreXRInteractionEvents() { }

	public object get_interactorSource() { }

	protected override bool get_isActivated() { }

	protected override bool get_isBlockedByGroup() { }

	protected override bool get_isRegistered() { }

	public SelectClickAnimationMode get_selectClickAnimationMode() { }

	private void OnActivated(ActivateEventArgs args) { }

	private void OnDeactivated(DeactivateEventArgs args) { }

	protected override void OnHoverEntered(HoverEnterEventArgs args) { }

	protected override void OnHoverExited(HoverExitEventArgs args) { }

	protected override void OnLargestInteractionStrengthChanged(float value) { }

	protected override void OnRegistered(InteractorRegisteredEventArgs args) { }

	protected override void OnSelectEntered(SelectEnterEventArgs args) { }

	protected override void OnSelectExited(SelectExitEventArgs args) { }

	protected override void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	public void RefreshState() { }

	protected override void SelectedClickBehavior() { }

	public void set_activateClickAnimationMode(ActivateClickAnimationMode value) { }

	public void set_clickAnimationCurve(AnimationCurveDatumProperty value) { }

	public void set_clickAnimationDuration(float value) { }

	public void set_ignoreActivateEvents(bool value) { }

	public void set_ignoreHoverEvents(bool value) { }

	public void set_ignoreSelectEvents(bool value) { }

	public void set_ignoreUGUIHover(bool value) { }

	public void set_ignoreUGUISelect(bool value) { }

	public void set_ignoreXRInteractionEvents(bool value) { }

	public void set_interactorSource(object value) { }

	public void set_selectClickAnimationMode(SelectClickAnimationMode value) { }

	public bool SetBoundInteractionReceiver(IXRInteractor interactor) { }

	[IteratorStateMachine(typeof(<UIUpdateCheckCoroutine>d__97))]
	private IEnumerator UIUpdateCheckCoroutine() { }

}

