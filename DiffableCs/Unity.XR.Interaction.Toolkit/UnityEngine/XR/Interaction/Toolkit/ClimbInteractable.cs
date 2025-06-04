namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/Climb Interactable", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.ClimbInteractable.html")]
[RequireComponent(typeof(Rigidbody))]
[SelectionBase]
public class ClimbInteractable : XRBaseInteractable
{
	private const float k_DefaultMaxInteractionDistance = 0.1; //Field offset: 0x0
	[SerializeField]
	[Tooltip("The climb provider that performs locomotion while this interactable is selected. If no climb provider is configured, will attempt to find one.")]
	private ClimbProvider m_ClimbProvider; //Field offset: 0x1D0
	[SerializeField]
	[Tooltip("Transform that defines the coordinate space for climb locomotion. Will use this GameObject's Transform by default.")]
	private Transform m_ClimbTransform; //Field offset: 0x1D8
	[SerializeField]
	[Tooltip("Controls whether to apply a distance check when validating hover and select interaction.")]
	private bool m_FilterInteractionByDistance; //Field offset: 0x1E0
	[SerializeField]
	[Tooltip("The maximum distance that an interactor can be from this interactable to begin hover or select.")]
	private float m_MaxInteractionDistance; //Field offset: 0x1E4
	[SerializeField]
	[Tooltip("Optional override of locomotion settings specified in the climb provider. Only applies as an override if set to Use Value or if the asset reference is set.")]
	private ClimbSettingsDatumProperty m_ClimbSettingsOverride; //Field offset: 0x1E8

	public ClimbProvider climbProvider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ClimbSettingsDatumProperty climbSettingsOverride
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Transform climbTransform
	{
		 get { } //Length: 128
		 set { } //Length: 8
	}

	public bool filterInteractionByDistance
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float maxInteractionDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public ClimbInteractable() { }

	protected virtual void Awake() { }

	public ClimbProvider get_climbProvider() { }

	public ClimbSettingsDatumProperty get_climbSettingsOverride() { }

	public Transform get_climbTransform() { }

	public bool get_filterInteractionByDistance() { }

	public float get_maxInteractionDistance() { }

	public virtual bool IsHoverableBy(IXRHoverInteractor interactor) { }

	public virtual bool IsSelectableBy(IXRSelectInteractor interactor) { }

	protected virtual void OnSelectEntered(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExited(SelectExitEventArgs args) { }

	protected override void OnValidate() { }

	protected virtual void Reset() { }

	public void set_climbProvider(ClimbProvider value) { }

	public void set_climbSettingsOverride(ClimbSettingsDatumProperty value) { }

	public void set_climbTransform(Transform value) { }

	public void set_filterInteractionByDistance(bool value) { }

	public void set_maxInteractionDistance(float value) { }

}

