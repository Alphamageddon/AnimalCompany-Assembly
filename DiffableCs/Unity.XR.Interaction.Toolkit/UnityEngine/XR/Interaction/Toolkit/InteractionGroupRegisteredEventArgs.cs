namespace UnityEngine.XR.Interaction.Toolkit;

public class InteractionGroupRegisteredEventArgs : BaseRegistrationEventArgs
{
	[CompilerGenerated]
	private IXRInteractionGroup <interactionGroupObject>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IXRInteractionGroup <containingGroupObject>k__BackingField; //Field offset: 0x20

	public IXRInteractionGroup containingGroupObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public IXRInteractionGroup interactionGroupObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public InteractionGroupRegisteredEventArgs() { }

	[CompilerGenerated]
	public IXRInteractionGroup get_containingGroupObject() { }

	[CompilerGenerated]
	public IXRInteractionGroup get_interactionGroupObject() { }

	[CompilerGenerated]
	public void set_containingGroupObject(IXRInteractionGroup value) { }

	[CompilerGenerated]
	public void set_interactionGroupObject(IXRInteractionGroup value) { }

}

