namespace UnityEngine.XR.Management;

public abstract class XRLoader : ScriptableObject
{

	protected XRLoader() { }

	public override bool Deinitialize() { }

	public abstract T GetLoadedSubsystem() { }

	public override List<GraphicsDeviceType> GetSupportedGraphicsDeviceTypes(bool buildingPlayer) { }

	public override bool Initialize() { }

	public override bool Start() { }

	public override bool Stop() { }

}

