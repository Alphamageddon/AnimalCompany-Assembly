namespace Unity.XR.Oculus;

public class OculusLoader : XRLoaderHelper
{
	private enum DeviceSupportedResult
	{
		Supported = 0,
		NotSupported = 1,
		ExitApplication = 2,
	}

	private static List<XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors; //Field offset: 0x0
	private static List<XRInputSubsystemDescriptor> s_InputSubsystemDescriptors; //Field offset: 0x8

	public XRDisplaySubsystem displaySubsystem
	{
		 get { } //Length: 100
	}

	public XRInputSubsystem inputSubsystem
	{
		 get { } //Length: 100
	}

	private static OculusLoader() { }

	public OculusLoader() { }

	private bool CheckUnityVersionCompatibility() { }

	public virtual bool Deinitialize() { }

	public XRDisplaySubsystem get_displaySubsystem() { }

	public XRInputSubsystem get_inputSubsystem() { }

	public OculusSettings GetSettings() { }

	public virtual bool Initialize() { }

	private static DeviceSupportedResult IsDeviceSupported() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterAssembliesLoaded (2))]
	private static void RuntimeLoadOVRPlugin() { }

	public virtual bool Start() { }

	public virtual bool Stop() { }

}

