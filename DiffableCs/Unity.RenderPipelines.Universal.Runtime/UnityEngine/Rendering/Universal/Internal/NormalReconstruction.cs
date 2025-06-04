namespace UnityEngine.Rendering.Universal.Internal;

public static class NormalReconstruction
{
	private static readonly int s_NormalReconstructionMatrixID; //Field offset: 0x0
	private static Matrix4x4[] s_NormalReconstructionMatrix; //Field offset: 0x8

	private static NormalReconstruction() { }

	public static void SetupProperties(CommandBuffer cmd, in CameraData cameraData) { }

}

