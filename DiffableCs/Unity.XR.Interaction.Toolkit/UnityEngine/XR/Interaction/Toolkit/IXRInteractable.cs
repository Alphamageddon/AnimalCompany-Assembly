namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractable
{

	public event Action<InteractableRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<InteractableUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public List<Collider> colliders
	{
		 get { } //Length: 0
	}

	public InteractionLayerMask interactionLayers
	{
		 get { } //Length: 0
	}

	public Transform transform
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_registered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_unregistered(Action<InteractableUnregisteredEventArgs> value) { }

	public List<Collider> get_colliders() { }

	public InteractionLayerMask get_interactionLayers() { }

	public Transform get_transform() { }

	public Transform GetAttachTransform(IXRInteractor interactor) { }

	public float GetDistanceSqrToInteractor(IXRInteractor interactor) { }

	public void OnRegistered(InteractableRegisteredEventArgs args) { }

	public void OnUnregistered(InteractableUnregisteredEventArgs args) { }

	public void ProcessInteractable(UpdatePhase updatePhase) { }

	[CompilerGenerated]
	public void remove_registered(Action<InteractableRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_unregistered(Action<InteractableUnregisteredEventArgs> value) { }

}

