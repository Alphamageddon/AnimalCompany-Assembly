namespace UnityEngine.Rendering.Universal.Internal;

internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
{
	private RTHandle[] m_ColorTargetIndentifiers; //Field offset: 0x198
	private RTHandle m_DepthTargetIndentifiers; //Field offset: 0x1A0

	public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	protected virtual void OnExecute(CommandBuffer cmd) { }

	public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment) { }

}

