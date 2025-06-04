namespace UnityEngine.Rendering.Universal;

[Obsolete("ForwardRenderer has been deprecated (UnityUpgradable) -> UniversalRenderer", True)]
public sealed class ForwardRenderer : ScriptableRenderer
{
	private static readonly string k_ErrorMessage; //Field offset: 0x0

	private static ForwardRenderer() { }

	public ForwardRenderer(ForwardRendererData data) { }

	public virtual void FinishRendering(CommandBuffer cmd) { }

	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	internal virtual void SwapColorBuffer(CommandBuffer cmd) { }

}

