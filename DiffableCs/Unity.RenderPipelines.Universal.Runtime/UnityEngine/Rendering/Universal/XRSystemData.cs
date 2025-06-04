namespace UnityEngine.Rendering.Universal;

public class XRSystemData : ScriptableObject
{
	[ReloadGroup]
	internal sealed class ShaderResources
	{
		[Reload("Shaders/XR/XROcclusionMesh.shader", Package::Root (1))]
		public Shader xrOcclusionMeshPS; //Field offset: 0x10
		[Reload("Shaders/XR/XRMirrorView.shader", Package::Root (1))]
		public Shader xrMirrorViewPS; //Field offset: 0x18

		public ShaderResources() { }

	}

	public ShaderResources shaders; //Field offset: 0x18

	public XRSystemData() { }

}

