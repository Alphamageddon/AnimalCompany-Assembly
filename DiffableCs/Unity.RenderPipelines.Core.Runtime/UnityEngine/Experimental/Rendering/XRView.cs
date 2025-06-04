namespace UnityEngine.Experimental.Rendering;

[IsReadOnly]
internal struct XRView
{
	internal readonly Matrix4x4 projMatrix; //Field offset: 0x0
	internal readonly Matrix4x4 viewMatrix; //Field offset: 0x40
	internal readonly Rect viewport; //Field offset: 0x80
	internal readonly Mesh occlusionMesh; //Field offset: 0x90
	internal readonly int textureArraySlice; //Field offset: 0x98
	internal readonly Vector2 eyeCenterUV; //Field offset: 0x9C

	internal XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice) { }

	private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj) { }

}

