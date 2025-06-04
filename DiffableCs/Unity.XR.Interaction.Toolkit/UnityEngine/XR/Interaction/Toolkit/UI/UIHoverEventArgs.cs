namespace UnityEngine.XR.Interaction.Toolkit.UI;

public class UIHoverEventArgs
{
	[CompilerGenerated]
	private IUIInteractor <interactorObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TrackedDeviceModel <deviceModel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GameObject <uiObject>k__BackingField; //Field offset: 0x170

	public TrackedDeviceModel deviceModel
	{
		[CompilerGenerated]
		 get { } //Length: 16
		[CompilerGenerated]
		 set { } //Length: 24
	}

	public IUIInteractor interactorObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public GameObject uiObject
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public UIHoverEventArgs() { }

	[CompilerGenerated]
	public TrackedDeviceModel get_deviceModel() { }

	[CompilerGenerated]
	public IUIInteractor get_interactorObject() { }

	[CompilerGenerated]
	public GameObject get_uiObject() { }

	[CompilerGenerated]
	public void set_deviceModel(TrackedDeviceModel value) { }

	[CompilerGenerated]
	public void set_interactorObject(IUIInteractor value) { }

	[CompilerGenerated]
	public void set_uiObject(GameObject value) { }

}

