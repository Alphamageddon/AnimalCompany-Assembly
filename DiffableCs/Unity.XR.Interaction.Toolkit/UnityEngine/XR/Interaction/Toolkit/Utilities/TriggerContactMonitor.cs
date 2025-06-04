namespace UnityEngine.XR.Interaction.Toolkit.Utilities;

internal class TriggerContactMonitor
{
	private static readonly List<Collider> s_ScratchColliders; //Field offset: 0x0
	private static readonly List<Collider> s_ExitedColliders; //Field offset: 0x8
	[CompilerGenerated]
	private Action<IXRInteractable> contactAdded; //Field offset: 0x10
	[CompilerGenerated]
	private Action<IXRInteractable> contactRemoved; //Field offset: 0x18
	[CompilerGenerated]
	private XRInteractionManager <interactionManager>k__BackingField; //Field offset: 0x20
	private readonly Dictionary<Collider, IXRInteractable> m_EnteredColliders; //Field offset: 0x28
	private readonly HashSet<IXRInteractable> m_UnorderedInteractables; //Field offset: 0x30
	private readonly HashSet<Collider> m_EnteredUnassociatedColliders; //Field offset: 0x38

	public event Action<IXRInteractable> contactAdded
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<IXRInteractable> contactRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public XRInteractionManager interactionManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static TriggerContactMonitor() { }

	public TriggerContactMonitor() { }

	[CompilerGenerated]
	public void add_contactAdded(Action<IXRInteractable> value) { }

	[CompilerGenerated]
	public void add_contactRemoved(Action<IXRInteractable> value) { }

	public void AddCollider(Collider collider) { }

	[CompilerGenerated]
	public XRInteractionManager get_interactionManager() { }

	public bool IsContacting(IXRInteractable interactable) { }

	private static bool IsDestroyed(Collider col) { }

	[CompilerGenerated]
	public void remove_contactAdded(Action<IXRInteractable> value) { }

	[CompilerGenerated]
	public void remove_contactRemoved(Action<IXRInteractable> value) { }

	public void RemoveCollider(Collider collider) { }

	private void RemoveFromUnassociatedColliders(Collider col) { }

	public void ResolveUnassociatedColliders() { }

	public void ResolveUnassociatedColliders(IXRInteractable interactable) { }

	[CompilerGenerated]
	public void set_interactionManager(XRInteractionManager value) { }

	public void UpdateStayedColliders(HashSet<Collider> stayedColliders) { }

}

