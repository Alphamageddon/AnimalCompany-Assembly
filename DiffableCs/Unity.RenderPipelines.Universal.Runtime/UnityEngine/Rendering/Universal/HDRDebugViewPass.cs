namespace UnityEngine.Rendering.Universal;

internal class HDRDebugViewPass : ScriptableRenderPass
{
	private enum HDRDebugPassId
	{
		CIExyPrepass = 0,
		DebugViewPass = 1,
	}

	private class PassData
	{
		internal Material material; //Field offset: 0x10
		internal HDRDebugMode hdrDebugMode; //Field offset: 0x18
		internal Vector4 luminanceParameters; //Field offset: 0x1C
		internal CameraData cameraData; //Field offset: 0x30

		public PassData() { }

	}

	public class ShaderConstants
	{
		public static readonly int _DebugHDRModeId; //Field offset: 0x0
		public static readonly int _HDRDebugParamsId; //Field offset: 0x4
		public static readonly int _xyTextureId; //Field offset: 0x8
		public static readonly int _SizeOfHDRXYMapping; //Field offset: 0xC
		public static readonly int _CIExyUAVIndex; //Field offset: 0x10

		private static ShaderConstants() { }

		public ShaderConstants() { }

	}

	private PassData m_PassData; //Field offset: 0xE0
	private RTHandle m_CIExyTarget; //Field offset: 0xE8
	private RTHandle m_PassthroughRT; //Field offset: 0xF0
	private RTHandle m_CameraTargetHandle; //Field offset: 0xF8

	public HDRDebugViewPass(Material mat) { }

	public static void ConfigureDescriptor(ref RenderTextureDescriptor descriptor) { }

	public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor) { }

	public void Dispose() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture) { }

	private static void ExecuteHDRDebugViewFinalPass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget) { }

	private void ExecutePass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget) { }

	internal static Vector4 GetLuminanceParameters(ref CameraData cameraData) { }

	public void Setup(ref CameraData cameraData, HDRDebugMode hdrdebugMode) { }

}

