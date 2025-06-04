namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Locomotion/Climb Provider", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ClimbProvider.html")]
public class ClimbProvider : LocomotionProvider
{
	private readonly List<IXRSelectInteractor> m_GrabbingInteractors; //Field offset: 0x48
	private readonly List<ClimbInteractable> m_GrabbedClimbables; //Field offset: 0x50
	private Vector3 m_InteractorAnchorWorldPosition; //Field offset: 0x58
	private Vector3 m_InteractorAnchorClimbSpacePosition; //Field offset: 0x64
	[SerializeField]
	[Tooltip("Climb locomotion settings. Can be overridden by the Climb Interactable used for locomotion.")]
	private ClimbSettingsDatumProperty m_ClimbSettings; //Field offset: 0x70

	public ClimbSettingsDatumProperty climbSettings
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ClimbProvider() { }

	protected virtual void Awake() { }

	public void FinishClimbGrab(IXRSelectInteractor interactor) { }

	private void FinishLocomotion() { }

	public ClimbSettingsDatumProperty get_climbSettings() { }

	private ClimbSettings GetActiveClimbSettings(ClimbInteractable climbInteractable) { }

	public void set_climbSettings(ClimbSettingsDatumProperty value) { }

	public void StartClimbGrab(ClimbInteractable climbInteractable, IXRSelectInteractor interactor) { }

	private void StepClimbMovement(ClimbInteractable currentClimbInteractable, IXRSelectInteractor currentInteractor) { }

	protected override void Update() { }

	private void UpdateClimbAnchor(ClimbInteractable climbInteractable, IXRInteractor interactor) { }

}

