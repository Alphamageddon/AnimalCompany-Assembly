namespace UnityEngine.XR.Management;

public abstract class XRLoaderHelper : XRLoader
{
	protected Dictionary<Type, ISubsystem> m_SubsystemInstanceMap; //Field offset: 0x18

	protected XRLoaderHelper() { }

	[Obsolete("This method is obsolete. Please use the geenric CreateSubsystem method.", False)]
	protected void CreateIntegratedSubsystem(List<TDescriptor> descriptors, string id) { }

	[Obsolete("This method is obsolete. Please use the generic CreateSubsystem method.", False)]
	protected void CreateStandaloneSubsystem(List<TDescriptor> descriptors, string id) { }

	protected void CreateSubsystem(List<TDescriptor> descriptors, string id) { }

	public virtual bool Deinitialize() { }

	protected void DestroySubsystem() { }

	public virtual T GetLoadedSubsystem() { }

	protected void StartSubsystem() { }

	protected void StopSubsystem() { }

}

