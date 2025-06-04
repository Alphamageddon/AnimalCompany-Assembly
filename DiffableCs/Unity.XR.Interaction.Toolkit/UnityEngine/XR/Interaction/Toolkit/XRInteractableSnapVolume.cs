namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Interactable Snap Volume", 11)]
[DefaultExecutionOrder(-99)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRInteractableSnapVolume.html")]
public class XRInteractableSnapVolume : MonoBehaviour
{
	[SerializeField]
	private XRInteractionManager m_InteractionManager; //Field offset: 0x20
	[RequireInterface(typeof(IXRInteractable))]
	[SerializeField]
	private object m_InteractableObject; //Field offset: 0x28
	[SerializeField]
	private Collider m_SnapCollider; //Field offset: 0x30
	[SerializeField]
	private bool m_DisableSnapColliderWhenSelected; //Field offset: 0x38
	[SerializeField]
	private Collider m_SnapToCollider; //Field offset: 0x40
	private IXRInteractable m_Interactable; //Field offset: 0x48
	private IXRInteractable m_BoundInteractable; //Field offset: 0x50
	private IXRSelectInteractable m_BoundSelectInteractable; //Field offset: 0x58
	private XRInteractionManager m_RegisteredInteractionManager; //Field offset: 0x60

	public bool disableSnapColliderWhenSelected
	{
		 get { } //Length: 8
		 set { } //Length: 144
	}

	public IXRInteractable interactable
	{
		 get { } //Length: 8
		 set { } //Length: 216
	}

	public object interactableObject
	{
		 get { } //Length: 8
		 set { } //Length: 100
	}

	public XRInteractionManager interactionManager
	{
		 get { } //Length: 8
		 set { } //Length: 144
	}

	public Collider snapCollider
	{
		 get { } //Length: 8
		 set { } //Length: 232
	}

	public Collider snapToCollider
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRInteractableSnapVolume() { }

	protected override void Awake() { }

	private void FindCreateInteractionManager() { }

	protected static Collider FindSnapCollider(GameObject gameObject) { }

	public bool get_disableSnapColliderWhenSelected() { }

	public IXRInteractable get_interactable() { }

	public object get_interactableObject() { }

	public XRInteractionManager get_interactionManager() { }

	public Collider get_snapCollider() { }

	public Collider get_snapToCollider() { }

	public Vector3 GetClosestPoint(Vector3 point) { }

	public Vector3 GetClosestPointOfAttachTransform(IXRInteractor interactor) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	private void OnFirstSelectEntered(SelectEnterEventArgs args) { }

	private void OnLastSelectExited(SelectExitEventArgs args) { }

	private void RefreshSnapColliderEnabled() { }

	private void RegisterWithInteractionManager() { }

	[Conditional("UNITY_EDITOR")]
	protected override void Reset() { }

	public void set_disableSnapColliderWhenSelected(bool value) { }

	public void set_interactable(IXRInteractable value) { }

	public void set_interactableObject(object value) { }

	public void set_interactionManager(XRInteractionManager value) { }

	public void set_snapCollider(Collider value) { }

	public void set_snapToCollider(Collider value) { }

	private void SetBoundInteractable(IXRInteractable source) { }

	private void SetSnapColliderEnabled(bool enable) { }

	internal static bool SupportsTriggerCollider(Collider col) { }

	private void UnregisterWithInteractionManager() { }

	private void ValidateSnapCollider() { }

}

