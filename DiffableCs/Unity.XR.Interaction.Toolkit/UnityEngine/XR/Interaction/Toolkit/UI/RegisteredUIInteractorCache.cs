namespace UnityEngine.XR.Interaction.Toolkit.UI;

internal class RegisteredUIInteractorCache
{
	private XRUIInputModule m_InputModule; //Field offset: 0x10
	private XRUIInputModule m_RegisteredInputModule; //Field offset: 0x18
	private readonly IUIInteractor m_UiInteractor; //Field offset: 0x20
	private readonly XRBaseInteractor m_BaseInteractor; //Field offset: 0x28

	public RegisteredUIInteractorCache(IUIInteractor uiInteractor) { }

	private void FindOrCreateXRUIInputModule() { }

	public bool IsOverUIGameObject() { }

	public void RegisterOrUnregisterXRUIInputModule(bool enabled) { }

	public void RegisterWithXRUIInputModule() { }

	public bool TryGetUIModel(out TrackedDeviceModel model) { }

	public void UnregisterFromXRUIInputModule() { }

}

