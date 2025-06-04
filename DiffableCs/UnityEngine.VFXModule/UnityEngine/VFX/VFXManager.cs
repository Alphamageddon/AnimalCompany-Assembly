namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[RequiredByNativeCode]
[StaticAccessor("GetVFXManager()", StaticAccessorType::Dot (0))]
public static class VFXManager
{
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings; //Field offset: 0x0

	private static VFXManager() { }

	private static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults) { }

	private static void Internal_ProcessCameraCommand_Injected(Camera cam, CommandBuffer cmd, ref VFXCameraXRSettings camXRSettings, IntPtr cullResults) { }

	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

}

