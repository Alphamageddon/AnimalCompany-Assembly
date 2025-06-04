namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer
{

	public Mesh additionalVertexStreams
	{
		 get { } //Length: 60
	}

	public MeshRenderer() { }

	[RequiredByNativeCode]
	private void DontStripMeshRenderer() { }

	public Mesh get_additionalVertexStreams() { }

}

