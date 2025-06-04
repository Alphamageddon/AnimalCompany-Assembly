namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

[AddComponentMenu("Affordance System/XR Interactable Affordance State Provider", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State.XRInteractableAffordanceStateProvider.html")]
public class XRInteractableAffordanceStateProvider : BaseAffordanceStateProvider
{
	[CompilerGenerated]
	private sealed class <ClickAnimation>d__91 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public XRInteractableAffordanceStateProvider <>4__this; //Field offset: 0x28
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
		public <ClickAnimation>d__91(int <>1__state) { }

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
	private sealed class <HoveredPriorityRoutine>d__93 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XRInteractableAffordanceStateProvider <>4__this; //Field offset: 0x20

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
		public <HoveredPriorityRoutine>d__93(int <>1__state) { }

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

	[RequireInterface(typeof(IXRInteractable))]
	[SerializeField]
	[Tooltip("The interactable component that drives the affordance states. If null, Unity will try and find an interactable component attached.")]
	private object m_InteractableSource; //Field offset: 0x60
	[Header("Event Constraints")]
	[SerializeField]
	[Tooltip("When hover events are registered and this is true, the state will fallback to idle or disabled.")]
	private bool m_IgnoreHoverEvents; //Field offset: 0x68
	[SerializeField]
	[Tooltip("When this is true, the state will fallback to hover if the later is not ignored. When this is false, this provider will check if the Interactable Source has priority for selection when hovered, and update its state accordingly.")]
	private bool m_IgnoreHoverPriorityEvents; //Field offset: 0x69
	[SerializeField]
	[Tooltip("When focus events are registered and this is true, the state will fallback to idle or disabled.")]
	private bool m_IgnoreFocusEvents; //Field offset: 0x6A
	[SerializeField]
	[Tooltip("When select events are registered and this is true, the state will fallback to idle or disabled. Note this will not affect click animations which can be disabled separately.")]
	private bool m_IgnoreSelectEvents; //Field offset: 0x6B
	[SerializeField]
	[Tooltip("When activate events are registered and this is true, the state will fallback to idle or disabled.Note this will not affect click animations which can be disabled separately.")]
	private bool m_IgnoreActivateEvents; //Field offset: 0x6C
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
	[Tooltip("Animation curve reference for click animation events. Select the More menu (⋮) to choose between a direct reference and a reusable scriptable object animation curve datum.")]
	private AnimationCurveDatumProperty m_ClickAnimationCurve; //Field offset: 0x80
	private IXRInteractable m_Interactable; //Field offset: 0x88
	private IXRHoverInteractable m_HoverInteractable; //Field offset: 0x90
	private IXRSelectInteractable m_SelectInteractable; //Field offset: 0x98
	private IXRFocusInteractable m_FocusInteractable; //Field offset: 0xA0
	private IXRActivateInteractable m_ActivateInteractable; //Field offset: 0xA8
	private IXRInteractionStrengthInteractable m_InteractionStrengthInteractable; //Field offset: 0xB0
	private Coroutine m_SelectedClickAnimation; //Field offset: 0xB8
	private Coroutine m_ActivatedClickAnimation; //Field offset: 0xC0
	private Coroutine m_HoveredPriorityRoutine; //Field offset: 0xC8
	private bool m_IsBoundToInteractionEvents; //Field offset: 0xD0
	private bool m_IsActivated; //Field offset: 0xD1
	private bool m_IsRegistered; //Field offset: 0xD2
	private bool m_IsHoveredPriority; //Field offset: 0xD3
	private bool m_HasHoverInteractable; //Field offset: 0xD4
	private bool m_HasSelectInteractable; //Field offset: 0xD5
	private bool m_HasInteractionStrengthInteractable; //Field offset: 0xD6
	private int m_HoveringPriorityInteractorCount; //Field offset: 0xD8

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

	public bool ignoreActivateEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreFocusEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreHoverEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool ignoreHoverPriorityEvents
	{
		 get { } //Length: 8
		 set { } //Length: 192
	}

	public bool ignoreSelectEvents
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public object interactableSource
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	protected override bool isActivated
	{
		 get { } //Length: 8
	}

	protected override bool isFocused
	{
		 get { } //Length: 176
	}

	protected override bool isHovered
	{
		 get { } //Length: 188
	}

	protected override bool isRegistered
	{
		 get { } //Length: 8
	}

	protected override bool isSelected
	{
		 get { } //Length: 188
	}

	public SelectClickAnimationMode selectClickAnimationMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRInteractableAffordanceStateProvider() { }

	[CompilerGenerated]
	private void <ActivatedClickBehavior>b__87_0() { }

	[CompilerGenerated]
	private void <SelectedClickBehavior>b__86_0() { }

	protected override void ActivatedClickBehavior() { }

	protected void Awake() { }

	protected virtual void BindToProviders() { }

	protected virtual void ClearBindings() { }

	[IteratorStateMachine(typeof(<ClickAnimation>d__91))]
	protected override IEnumerator ClickAnimation(byte targetStateIndex, float duration, Action onComplete = null) { }

	protected override AffordanceStateData GenerateNewAffordanceState() { }

	public ActivateClickAnimationMode get_activateClickAnimationMode() { }

	public AnimationCurveDatumProperty get_clickAnimationCurve() { }

	public float get_clickAnimationDuration() { }

	public bool get_ignoreActivateEvents() { }

	public bool get_ignoreFocusEvents() { }

	public bool get_ignoreHoverEvents() { }

	public bool get_ignoreHoverPriorityEvents() { }

	public bool get_ignoreSelectEvents() { }

	public object get_interactableSource() { }

	protected override bool get_isActivated() { }

	protected override bool get_isFocused() { }

	protected override bool get_isHovered() { }

	protected override bool get_isRegistered() { }

	protected override bool get_isSelected() { }

	public SelectClickAnimationMode get_selectClickAnimationMode() { }

	[IteratorStateMachine(typeof(<HoveredPriorityRoutine>d__93))]
	private IEnumerator HoveredPriorityRoutine() { }

	protected override void OnActivatedEvent(ActivateEventArgs args) { }

	protected override void OnDeactivatedEvent(DeactivateEventArgs args) { }

	protected override void OnFirstFocusEntered(FocusEnterEventArgs args) { }

	protected override void OnFirstHoverEntered(HoverEnterEventArgs args) { }

	protected override void OnFirstSelectEntered(SelectEnterEventArgs args) { }

	protected override void OnHoverEntered(HoverEnterEventArgs args) { }

	protected override void OnHoverExited(HoverExitEventArgs args) { }

	protected override void OnLargestInteractionStrengthChanged(float value) { }

	protected override void OnLastFocusExited(FocusExitEventArgs args) { }

	protected override void OnLastHoverExited(HoverExitEventArgs args) { }

	protected override void OnLastSelectExited(SelectExitEventArgs args) { }

	protected override void OnRegistered(InteractableRegisteredEventArgs args) { }

	protected override void OnUnregistered(InteractableUnregisteredEventArgs args) { }

	protected virtual void OnValidate() { }

	public void RefreshState() { }

	protected override void SelectedClickBehavior() { }

	public void set_activateClickAnimationMode(ActivateClickAnimationMode value) { }

	public void set_clickAnimationCurve(AnimationCurveDatumProperty value) { }

	public void set_clickAnimationDuration(float value) { }

	public void set_ignoreActivateEvents(bool value) { }

	public void set_ignoreFocusEvents(bool value) { }

	public void set_ignoreHoverEvents(bool value) { }

	public void set_ignoreHoverPriorityEvents(bool value) { }

	public void set_ignoreSelectEvents(bool value) { }

	public void set_interactableSource(object value) { }

	public void set_selectClickAnimationMode(SelectClickAnimationMode value) { }

	public bool SetBoundInteractionReceiver(IXRInteractable receiver) { }

	private void StopActivatedCoroutine() { }

	private void StopAllClickAnimations() { }

	private void StopHoveredPriorityRoutine() { }

	private void StopSelectedCoroutine() { }

}

