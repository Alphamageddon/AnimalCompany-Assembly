namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Socket Interactor", 11)]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRSocketInteractor.html")]
public class XRSocketInteractor : XRBaseInteractor
{
	[CompilerGenerated]
	private sealed class <UpdateCollidersAfterOnTriggerStay>d__67 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public XRSocketInteractor <>4__this; //Field offset: 0x20

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
		public <UpdateCollidersAfterOnTriggerStay>d__67(int <>1__state) { }

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

	private struct ShaderPropertyLookup
	{
		public static readonly int surface; //Field offset: 0x0
		public static readonly int mode; //Field offset: 0x4
		public static readonly int srcBlend; //Field offset: 0x8
		public static readonly int dstBlend; //Field offset: 0xC
		public static readonly int zWrite; //Field offset: 0x10
		public static readonly int baseColor; //Field offset: 0x14
		public static readonly int color; //Field offset: 0x18

		private static ShaderPropertyLookup() { }

	}

	private static readonly List<MeshFilter> s_MeshFilters; //Field offset: 0x0
	private static readonly WaitForFixedUpdate s_WaitForFixedUpdate; //Field offset: 0x8
	[SerializeField]
	private bool m_ShowInteractableHoverMeshes; //Field offset: 0x1A8
	[SerializeField]
	private Material m_InteractableHoverMeshMaterial; //Field offset: 0x1B0
	[SerializeField]
	private Material m_InteractableCantHoverMeshMaterial; //Field offset: 0x1B8
	[SerializeField]
	private bool m_SocketActive; //Field offset: 0x1C0
	[SerializeField]
	private float m_InteractableHoverScale; //Field offset: 0x1C4
	[SerializeField]
	private float m_RecycleDelayTime; //Field offset: 0x1C8
	private float m_LastRemoveTime; //Field offset: 0x1CC
	[SerializeField]
	private bool m_HoverSocketSnapping; //Field offset: 0x1D0
	[SerializeField]
	private float m_SocketSnappingRadius; //Field offset: 0x1D4
	[SerializeField]
	private SocketScaleMode m_SocketScaleMode; //Field offset: 0x1D8
	[SerializeField]
	private Vector3 m_FixedScale; //Field offset: 0x1DC
	[SerializeField]
	private Vector3 m_TargetBoundsSize; //Field offset: 0x1E8
	[CompilerGenerated]
	private readonly List<IXRInteractable> <unsortedValidTargets>k__BackingField; //Field offset: 0x1F8
	private readonly HashSet<Collider> m_StayedColliders; //Field offset: 0x200
	private readonly TriggerContactMonitor m_TriggerContactMonitor; //Field offset: 0x208
	private readonly Dictionary<IXRInteractable, ValueTuple`2<MeshFilter, Renderer>[]> m_MeshFilterCache; //Field offset: 0x210
	private IEnumerator m_UpdateCollidersAfterTriggerStay; //Field offset: 0x218
	private readonly XRSocketGrabTransformer m_SocketGrabTransformer; //Field offset: 0x220
	private readonly HashSetList<XRGrabInteractable> m_InteractablesWithSocketTransformer; //Field offset: 0x228

	protected override bool ejectExistingSocketsWhenSnapping
	{
		 get { } //Length: 8
	}

	public Vector3 fixedScale
	{
		 get { } //Length: 16
		 set { } //Length: 52
	}

	public bool hoverSocketSnapping
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public Material interactableCantHoverMeshMaterial
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public Material interactableHoverMeshMaterial
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float interactableHoverScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public virtual bool isHoverActive
	{
		 get { } //Length: 32
	}

	private bool isHoverRecycleAllowed
	{
		private get { } //Length: 84
	}

	public virtual bool isSelectActive
	{
		 get { } //Length: 32
	}

	public float recycleDelayTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public virtual Nullable<MovementType> selectedInteractableMovementTypeOverride
	{
		 get { } //Length: 84
	}

	public bool showInteractableHoverMeshes
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public bool socketActive
	{
		 get { } //Length: 8
		 set { } //Length: 60
	}

	public SocketScaleMode socketScaleMode
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	protected override int socketSnappingLimit
	{
		 get { } //Length: 8
	}

	public float socketSnappingRadius
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public Vector3 targetBoundsSize
	{
		 get { } //Length: 16
		 set { } //Length: 52
	}

	protected List<IXRInteractable> unsortedValidTargets
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private static XRSocketInteractor() { }

	public XRSocketInteractor() { }

	protected virtual void Awake() { }

	[Obsolete("CanHover(XRBaseInteractable) has been deprecated. Use CanHover(IXRHoverInteractable) instead.")]
	public virtual bool CanHover(XRBaseInteractable interactable) { }

	public virtual bool CanHover(IXRHoverInteractable interactable) { }

	protected override bool CanHoverSnap(IXRInteractable interactable) { }

	[Obsolete("CanSelect(XRBaseInteractable) has been deprecated. Use CanSelect(IXRSelectInteractable) instead.")]
	public virtual bool CanSelect(XRBaseInteractable interactable) { }

	public virtual bool CanSelect(IXRSelectInteractable interactable) { }

	protected override void CreateDefaultHoverMaterials() { }

	protected override void DrawHoveredInteractables() { }

	protected override bool EndSocketSnapping(XRGrabInteractable grabInteractable) { }

	protected override bool get_ejectExistingSocketsWhenSnapping() { }

	public Vector3 get_fixedScale() { }

	public bool get_hoverSocketSnapping() { }

	public Material get_interactableCantHoverMeshMaterial() { }

	public Material get_interactableHoverMeshMaterial() { }

	public float get_interactableHoverScale() { }

	public virtual bool get_isHoverActive() { }

	private bool get_isHoverRecycleAllowed() { }

	public virtual bool get_isSelectActive() { }

	public float get_recycleDelayTime() { }

	public virtual Nullable<MovementType> get_selectedInteractableMovementTypeOverride() { }

	public bool get_showInteractableHoverMeshes() { }

	public bool get_socketActive() { }

	public SocketScaleMode get_socketScaleMode() { }

	protected override int get_socketSnappingLimit() { }

	public float get_socketSnappingRadius() { }

	public Vector3 get_targetBoundsSize() { }

	[CompilerGenerated]
	protected List<IXRInteractable> get_unsortedValidTargets() { }

	protected override Material GetHoveredInteractableMaterial(IXRHoverInteractable interactable) { }

	private Matrix4x4 GetHoverMeshMatrix(IXRInteractable interactable, MeshFilter meshFilter, float hoverScale) { }

	public virtual void GetValidTargets(List<IXRInteractable> targets) { }

	private static Vector3 InverseTransformDirection(Pose pose, Vector3 direction) { }

	private void OnContactAdded(IXRInteractable interactable) { }

	private void OnContactRemoved(IXRInteractable interactable) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnHoverEntered(HoverEnterEventArgs args) { }

	protected virtual void OnHoverEntering(HoverEnterEventArgs args) { }

	protected virtual void OnHoverExiting(HoverExitEventArgs args) { }

	private void OnInteractableRegistered(InteractableRegisteredEventArgs args) { }

	private void OnInteractableUnregistered(InteractableUnregisteredEventArgs args) { }

	protected virtual void OnRegistered(InteractorRegisteredEventArgs args) { }

	protected virtual void OnSelectEntered(SelectEnterEventArgs args) { }

	protected virtual void OnSelectExited(SelectExitEventArgs args) { }

	protected virtual void OnSelectExiting(SelectExitEventArgs args) { }

	protected void OnTriggerEnter(Collider other) { }

	protected void OnTriggerExit(Collider other) { }

	protected void OnTriggerStay(Collider other) { }

	protected virtual void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	protected override void OnValidate() { }

	public virtual void ProcessInteractor(UpdatePhase updatePhase) { }

	private void ResetCollidersAndValidTargets() { }

	public void set_fixedScale(Vector3 value) { }

	public void set_hoverSocketSnapping(bool value) { }

	public void set_interactableCantHoverMeshMaterial(Material value) { }

	public void set_interactableHoverMeshMaterial(Material value) { }

	public void set_interactableHoverScale(float value) { }

	public void set_recycleDelayTime(float value) { }

	public void set_showInteractableHoverMeshes(bool value) { }

	public void set_socketActive(bool value) { }

	public void set_socketScaleMode(SocketScaleMode value) { }

	public void set_socketSnappingRadius(float value) { }

	public void set_targetBoundsSize(Vector3 value) { }

	private static void SetMaterialFade(Material material, Color color) { }

	protected override bool ShouldDrawHoverMesh(MeshFilter meshFilter, Renderer meshRenderer, Camera mainCamera) { }

	protected override bool StartSocketSnapping(XRGrabInteractable grabInteractable) { }

	private void SyncTransformerParams() { }

	[IteratorStateMachine(typeof(<UpdateCollidersAfterOnTriggerStay>d__67))]
	private IEnumerator UpdateCollidersAfterOnTriggerStay() { }

}

