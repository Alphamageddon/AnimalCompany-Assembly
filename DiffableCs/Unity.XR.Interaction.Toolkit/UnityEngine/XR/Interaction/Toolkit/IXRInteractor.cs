namespace UnityEngine.XR.Interaction.Toolkit;

public interface IXRInteractor
{

	public event Action<InteractorRegisteredEventArgs> registered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<InteractorUnregisteredEventArgs> unregistered
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
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
	public void add_registered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void add_unregistered(Action<InteractorUnregisteredEventArgs> value) { }

	public InteractionLayerMask get_interactionLayers() { }

	public Transform get_transform() { }

	public Transform GetAttachTransform(IXRInteractable interactable) { }

	public void GetValidTargets(List<IXRInteractable> targets) { }

	public void OnRegistered(InteractorRegisteredEventArgs args) { }

	public void OnUnregistered(InteractorUnregisteredEventArgs args) { }

	public void PreprocessInteractor(UpdatePhase updatePhase) { }

	public void ProcessInteractor(UpdatePhase updatePhase) { }

	[CompilerGenerated]
	public void remove_registered(Action<InteractorRegisteredEventArgs> value) { }

	[CompilerGenerated]
	public void remove_unregistered(Action<InteractorUnregisteredEventArgs> value) { }

}

