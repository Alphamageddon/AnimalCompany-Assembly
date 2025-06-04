namespace UnityEngine.XR.Interaction.Toolkit;

public abstract class XRBaseControllerInteractor : XRBaseInteractor, IXRActivateInteractor, IXRInteractor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ActivateEventArgs> <>9__226_0; //Field offset: 0x8
		public static Func<DeactivateEventArgs> <>9__226_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ActivateEventArgs <.ctor>b__226_0() { }

		internal DeactivateEventArgs <.ctor>b__226_1() { }

	}

	internal enum InputTriggerType
	{
		State = 0,
		StateChange = 1,
		Toggle = 2,
		Sticky = 3,
	}

	private static readonly List<IXRActivateInteractable> s_ActivateTargets; //Field offset: 0x0
	[SerializeField]
	private InputTriggerType m_SelectActionTrigger; //Field offset: 0x1A8
	[SerializeField]
	private bool m_HideControllerOnSelect; //Field offset: 0x1AC
	[SerializeField]
	private bool m_AllowHoveredActivate; //Field offset: 0x1AD
	[SerializeField]
	private TargetPriorityMode m_TargetPriorityMode; //Field offset: 0x1B0
	[FormerlySerializedAs("m_PlayAudioClipOnSelectEnter")]
	[SerializeField]
	private bool m_PlayAudioClipOnSelectEntered; //Field offset: 0x1B4
	[FormerlySerializedAs("m_AudioClipForOnSelectEnter")]
	[SerializeField]
	private AudioClip m_AudioClipForOnSelectEntered; //Field offset: 0x1B8
	[FormerlySerializedAs("m_PlayAudioClipOnSelectExit")]
	[SerializeField]
	private bool m_PlayAudioClipOnSelectExited; //Field offset: 0x1C0
	[FormerlySerializedAs("m_AudioClipForOnSelectExit")]
	[SerializeField]
	private AudioClip m_AudioClipForOnSelectExited; //Field offset: 0x1C8
	[SerializeField]
	private bool m_PlayAudioClipOnSelectCanceled; //Field offset: 0x1D0
	[SerializeField]
	private AudioClip m_AudioClipForOnSelectCanceled; //Field offset: 0x1D8
	[FormerlySerializedAs("m_PlayAudioClipOnHoverEnter")]
	[SerializeField]
	private bool m_PlayAudioClipOnHoverEntered; //Field offset: 0x1E0
	[FormerlySerializedAs("m_AudioClipForOnHoverEnter")]
	[SerializeField]
	private AudioClip m_AudioClipForOnHoverEntered; //Field offset: 0x1E8
	[FormerlySerializedAs("m_PlayAudioClipOnHoverExit")]
	[SerializeField]
	private bool m_PlayAudioClipOnHoverExited; //Field offset: 0x1F0
	[FormerlySerializedAs("m_AudioClipForOnHoverExit")]
	[SerializeField]
	private AudioClip m_AudioClipForOnHoverExited; //Field offset: 0x1F8
	[SerializeField]
	private bool m_PlayAudioClipOnHoverCanceled; //Field offset: 0x200
	[SerializeField]
	private AudioClip m_AudioClipForOnHoverCanceled; //Field offset: 0x208
	[SerializeField]
	private bool m_AllowHoverAudioWhileSelecting; //Field offset: 0x210
	[FormerlySerializedAs("m_PlayHapticsOnSelectEnter")]
	[SerializeField]
	private bool m_PlayHapticsOnSelectEntered; //Field offset: 0x211
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticSelectEnterIntensity; //Field offset: 0x214
	[SerializeField]
	private float m_HapticSelectEnterDuration; //Field offset: 0x218
	[FormerlySerializedAs("m_PlayHapticsOnSelectExit")]
	[SerializeField]
	private bool m_PlayHapticsOnSelectExited; //Field offset: 0x21C
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticSelectExitIntensity; //Field offset: 0x220
	[SerializeField]
	private float m_HapticSelectExitDuration; //Field offset: 0x224
	[SerializeField]
	private bool m_PlayHapticsOnSelectCanceled; //Field offset: 0x228
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticSelectCancelIntensity; //Field offset: 0x22C
	[SerializeField]
	private float m_HapticSelectCancelDuration; //Field offset: 0x230
	[FormerlySerializedAs("m_PlayHapticsOnHoverEnter")]
	[SerializeField]
	private bool m_PlayHapticsOnHoverEntered; //Field offset: 0x234
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticHoverEnterIntensity; //Field offset: 0x238
	[SerializeField]
	private float m_HapticHoverEnterDuration; //Field offset: 0x23C
	[FormerlySerializedAs("m_PlayHapticsOnHoverExit")]
	[SerializeField]
	private bool m_PlayHapticsOnHoverExited; //Field offset: 0x240
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticHoverExitIntensity; //Field offset: 0x244
	[SerializeField]
	private float m_HapticHoverExitDuration; //Field offset: 0x248
	[SerializeField]
	private bool m_PlayHapticsOnHoverCanceled; //Field offset: 0x24C
	[Range(0, 1)]
	[SerializeField]
	private float m_HapticHoverCancelIntensity; //Field offset: 0x250
	[SerializeField]
	private float m_HapticHoverCancelDuration; //Field offset: 0x254
	[SerializeField]
	private bool m_AllowHoverHapticsWhileSelecting; //Field offset: 0x258
	private bool m_AllowActivate; //Field offset: 0x259
	private XRBaseController m_Controller; //Field offset: 0x260
	private readonly LinkedPool<ActivateEventArgs> m_ActivateEventArgs; //Field offset: 0x268
	private readonly LinkedPool<DeactivateEventArgs> m_DeactivateEventArgs; //Field offset: 0x270
	private bool m_ToggleSelectActive; //Field offset: 0x278
	private bool m_ToggleSelectDeactivatedThisFrame; //Field offset: 0x279
	private bool m_WaitingForSelectDeactivate; //Field offset: 0x27A
	private AudioSource m_EffectsAudioSource; //Field offset: 0x280
	[CompilerGenerated]
	private readonly List<XRBaseInteractable> <validTargets>k__BackingField; //Field offset: 0x288

	public bool allowActivate
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowHoverAudioWhileSelecting
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowHoveredActivate
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool allowHoverHapticsWhileSelecting
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public AudioClip audioClipForOnHoverCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("audioClipForOnHoverEnter has been deprecated. Use audioClipForOnHoverEntered instead. (UnityUpgradable) -> audioClipForOnHoverEntered")]
	public AudioClip audioClipForOnHoverEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("AudioClipForOnHoverEnter has been deprecated. Use audioClipForOnHoverEntered instead. (UnityUpgradable) -> audioClipForOnHoverEntered")]
	public AudioClip AudioClipForOnHoverEnter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioClip audioClipForOnHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("audioClipForOnHoverExit has been deprecated. Use audioClipForOnHoverExited instead. (UnityUpgradable) -> audioClipForOnHoverExited")]
	public AudioClip audioClipForOnHoverExit
	{
		 get { } //Length: 8
	}

	[Obsolete("AudioClipForOnHoverExit has been deprecated. Use audioClipForOnHoverExited instead. (UnityUpgradable) -> audioClipForOnHoverExited")]
	public AudioClip AudioClipForOnHoverExit
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioClip audioClipForOnHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioClip audioClipForOnSelectCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("audioClipForOnSelectEnter has been deprecated. Use audioClipForOnSelectEntered instead. (UnityUpgradable) -> audioClipForOnSelectEntered")]
	public AudioClip audioClipForOnSelectEnter
	{
		 get { } //Length: 8
	}

	[Obsolete("AudioClipForOnSelectEnter has been deprecated. Use audioClipForOnSelectEntered instead. (UnityUpgradable) -> audioClipForOnSelectEntered")]
	public AudioClip AudioClipForOnSelectEnter
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioClip audioClipForOnSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[Obsolete("audioClipForOnSelectExit has been deprecated. Use audioClipForOnSelectExited instead. (UnityUpgradable) -> audioClipForOnSelectExited")]
	public AudioClip audioClipForOnSelectExit
	{
		 get { } //Length: 8
	}

	[Obsolete("AudioClipForOnSelectExit has been deprecated. Use audioClipForOnSelectExited instead. (UnityUpgradable) -> audioClipForOnSelectExited")]
	public AudioClip AudioClipForOnSelectExit
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public AudioClip audioClipForOnSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverCancelDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverCancelIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverEnterDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverEnterIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverExitDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticHoverExitIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectCancelDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectCancelIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectEnterDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectEnterIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectExitDuration
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float hapticSelectExitIntensity
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool hideControllerOnSelect
	{
		 get { } //Length: 8
		 set { } //Length: 164
	}

	public virtual bool isSelectActive
	{
		 get { } //Length: 496
	}

	protected override bool isUISelectActive
	{
		 get { } //Length: 136
	}

	public bool playAudioClipOnHoverCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playAudioClipOnHoverEnter has been deprecated. Use playAudioClipOnHoverEntered instead. (UnityUpgradable) -> playAudioClipOnHoverEntered")]
	public bool playAudioClipOnHoverEnter
	{
		 get { } //Length: 8
	}

	public bool playAudioClipOnHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playAudioClipOnHoverExit has been deprecated. Use playAudioClipOnHoverExited instead. (UnityUpgradable) -> playAudioClipOnHoverExited")]
	public bool playAudioClipOnHoverExit
	{
		 get { } //Length: 8
	}

	public bool playAudioClipOnHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool playAudioClipOnSelectCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playAudioClipOnSelectEnter has been deprecated. Use playAudioClipOnSelectEntered instead. (UnityUpgradable) -> playAudioClipOnSelectEntered")]
	public bool playAudioClipOnSelectEnter
	{
		 get { } //Length: 8
	}

	public bool playAudioClipOnSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playAudioClipOnSelectExit has been deprecated. Use playAudioClipOnSelectExited instead. (UnityUpgradable) -> playAudioClipOnSelectExited")]
	public bool playAudioClipOnSelectExit
	{
		 get { } //Length: 8
	}

	public bool playAudioClipOnSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool playHapticsOnHoverCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playHapticsOnHoverEnter has been deprecated. Use playHapticsOnHoverEntered instead. (UnityUpgradable) -> playHapticsOnHoverEntered")]
	public bool playHapticsOnHoverEnter
	{
		 get { } //Length: 8
	}

	public bool playHapticsOnHoverEntered
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool playHapticsOnHoverExited
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool playHapticsOnSelectCanceled
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playHapticsOnSelectEnter has been deprecated. Use playHapticsOnSelectEntered instead. (UnityUpgradable) -> playHapticsOnSelectEntered")]
	public bool playHapticsOnSelectEnter
	{
		 get { } //Length: 8
	}

	public bool playHapticsOnSelectEntered
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	[Obsolete("playHapticsOnSelectExit has been deprecated. Use playHapticsOnSelectExited instead. (UnityUpgradable) -> playHapticsOnSelectExited")]
	public bool playHapticsOnSelectExit
	{
		 get { } //Length: 8
	}

	public bool playHapticsOnSelectExited
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public InputTriggerType selectActionTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override bool shouldActivate
	{
		 get { } //Length: 176
	}

	public override bool shouldDeactivate
	{
		 get { } //Length: 176
	}

	public virtual TargetPriorityMode targetPriorityMode
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected Vector2 uiScrollValue
	{
		 get { } //Length: 188
	}

	[Obsolete("validTargets has been deprecated. Use a property of type List<IXRInteractable> instead.")]
	protected override List<XRBaseInteractable> validTargets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public XRBaseController xrController
	{
		 get { } //Length: 8
		 set { } //Length: 152
	}

	private static XRBaseControllerInteractor() { }

	protected XRBaseControllerInteractor() { }

	protected virtual void Awake() { }

	private bool CanPlayHoverAudio(IXRHoverInteractable hoveredInteractable) { }

	private bool CanPlayHoverHaptics(IXRHoverInteractable hoveredInteractable) { }

	private void CreateEffectsAudioSource() { }

	internal XRBaseController FindControllerComponent() { }

	public bool get_allowActivate() { }

	public bool get_allowHoverAudioWhileSelecting() { }

	public bool get_allowHoveredActivate() { }

	public bool get_allowHoverHapticsWhileSelecting() { }

	public AudioClip get_audioClipForOnHoverCanceled() { }

	public AudioClip get_audioClipForOnHoverEnter() { }

	public AudioClip get_AudioClipForOnHoverEnter() { }

	public AudioClip get_audioClipForOnHoverEntered() { }

	public AudioClip get_audioClipForOnHoverExit() { }

	public AudioClip get_AudioClipForOnHoverExit() { }

	public AudioClip get_audioClipForOnHoverExited() { }

	public AudioClip get_audioClipForOnSelectCanceled() { }

	public AudioClip get_audioClipForOnSelectEnter() { }

	public AudioClip get_AudioClipForOnSelectEnter() { }

	public AudioClip get_audioClipForOnSelectEntered() { }

	public AudioClip get_audioClipForOnSelectExit() { }

	public AudioClip get_AudioClipForOnSelectExit() { }

	public AudioClip get_audioClipForOnSelectExited() { }

	public float get_hapticHoverCancelDuration() { }

	public float get_hapticHoverCancelIntensity() { }

	public float get_hapticHoverEnterDuration() { }

	public float get_hapticHoverEnterIntensity() { }

	public float get_hapticHoverExitDuration() { }

	public float get_hapticHoverExitIntensity() { }

	public float get_hapticSelectCancelDuration() { }

	public float get_hapticSelectCancelIntensity() { }

	public float get_hapticSelectEnterDuration() { }

	public float get_hapticSelectEnterIntensity() { }

	public float get_hapticSelectExitDuration() { }

	public float get_hapticSelectExitIntensity() { }

	public bool get_hideControllerOnSelect() { }

	public virtual bool get_isSelectActive() { }

	protected override bool get_isUISelectActive() { }

	public bool get_playAudioClipOnHoverCanceled() { }

	public bool get_playAudioClipOnHoverEnter() { }

	public bool get_playAudioClipOnHoverEntered() { }

	public bool get_playAudioClipOnHoverExit() { }

	public bool get_playAudioClipOnHoverExited() { }

	public bool get_playAudioClipOnSelectCanceled() { }

	public bool get_playAudioClipOnSelectEnter() { }

	public bool get_playAudioClipOnSelectEntered() { }

	public bool get_playAudioClipOnSelectExit() { }

	public bool get_playAudioClipOnSelectExited() { }

	public bool get_playHapticsOnHoverCanceled() { }

	public bool get_playHapticsOnHoverEnter() { }

	public bool get_playHapticsOnHoverEntered() { }

	public bool get_playHapticsOnHoverExited() { }

	public bool get_playHapticsOnSelectCanceled() { }

	public bool get_playHapticsOnSelectEnter() { }

	public bool get_playHapticsOnSelectEntered() { }

	public bool get_playHapticsOnSelectExit() { }

	public bool get_playHapticsOnSelectExited() { }

	public InputTriggerType get_selectActionTrigger() { }

	public override bool get_shouldActivate() { }

	public override bool get_shouldDeactivate() { }

	public virtual TargetPriorityMode get_targetPriorityMode() { }

	protected Vector2 get_uiScrollValue() { }

	[CompilerGenerated]
	protected override List<XRBaseInteractable> get_validTargets() { }

	public XRBaseController get_xrController() { }

	public override void GetActivateTargets(List<IXRActivateInteractable> targets) { }

	private void HandleDeselecting() { }

	private void HandleSelecting() { }

	protected virtual void OnHoverEntering(HoverEnterEventArgs args) { }

	protected virtual void OnHoverExiting(HoverExitEventArgs args) { }

	protected virtual void OnSelectEntering(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExiting(SelectExitEventArgs args) { }

	override void OnXRControllerChanged() { }

	protected override void PlayAudio(AudioClip audioClip) { }

	public virtual void PreprocessInteractor(UpdatePhase updatePhase) { }

	public virtual void ProcessInteractor(UpdatePhase updatePhase) { }

	private void SendActivateEvent(List<IXRActivateInteractable> targets) { }

	private void SendDeactivateEvent(List<IXRActivateInteractable> targets) { }

	public bool SendHapticImpulse(float amplitude, float duration) { }

	public void set_allowActivate(bool value) { }

	public void set_allowHoverAudioWhileSelecting(bool value) { }

	public void set_allowHoveredActivate(bool value) { }

	public void set_allowHoverHapticsWhileSelecting(bool value) { }

	public void set_audioClipForOnHoverCanceled(AudioClip value) { }

	public void set_AudioClipForOnHoverEnter(AudioClip value) { }

	public void set_audioClipForOnHoverEntered(AudioClip value) { }

	public void set_AudioClipForOnHoverExit(AudioClip value) { }

	public void set_audioClipForOnHoverExited(AudioClip value) { }

	public void set_audioClipForOnSelectCanceled(AudioClip value) { }

	public void set_AudioClipForOnSelectEnter(AudioClip value) { }

	public void set_audioClipForOnSelectEntered(AudioClip value) { }

	public void set_AudioClipForOnSelectExit(AudioClip value) { }

	public void set_audioClipForOnSelectExited(AudioClip value) { }

	public void set_hapticHoverCancelDuration(float value) { }

	public void set_hapticHoverCancelIntensity(float value) { }

	public void set_hapticHoverEnterDuration(float value) { }

	public void set_hapticHoverEnterIntensity(float value) { }

	public void set_hapticHoverExitDuration(float value) { }

	public void set_hapticHoverExitIntensity(float value) { }

	public void set_hapticSelectCancelDuration(float value) { }

	public void set_hapticSelectCancelIntensity(float value) { }

	public void set_hapticSelectEnterDuration(float value) { }

	public void set_hapticSelectEnterIntensity(float value) { }

	public void set_hapticSelectExitDuration(float value) { }

	public void set_hapticSelectExitIntensity(float value) { }

	public void set_hideControllerOnSelect(bool value) { }

	public void set_playAudioClipOnHoverCanceled(bool value) { }

	public void set_playAudioClipOnHoverEntered(bool value) { }

	public void set_playAudioClipOnHoverExited(bool value) { }

	public void set_playAudioClipOnSelectCanceled(bool value) { }

	public void set_playAudioClipOnSelectEntered(bool value) { }

	public void set_playAudioClipOnSelectExited(bool value) { }

	public void set_playHapticsOnHoverCanceled(bool value) { }

	public void set_playHapticsOnHoverEntered(bool value) { }

	public void set_playHapticsOnHoverExited(bool value) { }

	public void set_playHapticsOnSelectCanceled(bool value) { }

	public void set_playHapticsOnSelectEntered(bool value) { }

	public void set_playHapticsOnSelectExited(bool value) { }

	public void set_selectActionTrigger(InputTriggerType value) { }

	public virtual void set_targetPriorityMode(TargetPriorityMode value) { }

	public void set_xrController(XRBaseController value) { }

	private override Transform UnityEngine.XR.Interaction.Toolkit.IXRInteractor.get_transform() { }

}

