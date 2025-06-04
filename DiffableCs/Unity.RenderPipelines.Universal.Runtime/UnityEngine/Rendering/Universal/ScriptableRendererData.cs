namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRendererData : ScriptableObject
{
	[ReloadGroup]
	internal sealed class DebugShaderResources
	{
		[Reload("Shaders/Debug/DebugReplacement.shader", Package::Root (1))]
		public Shader debugReplacementPS; //Field offset: 0x10
		[Reload("Shaders/Debug/HDRDebugView.shader", Package::Root (1))]
		public Shader hdrDebugViewPS; //Field offset: 0x18

		public DebugShaderResources() { }

	}

	[CompilerGenerated]
	private bool <isInvalidated>k__BackingField; //Field offset: 0x18
	public DebugShaderResources debugShaders; //Field offset: 0x20
	[SerializeField]
	internal List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x28
	[SerializeField]
	internal List<Int64> m_RendererFeatureMap; //Field offset: 0x30
	[SerializeField]
	private bool m_UseNativeRenderPass; //Field offset: 0x38

	internal bool isInvalidated
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public List<ScriptableRendererFeature> rendererFeatures
	{
		 get { } //Length: 8
	}

	public bool useNativeRenderPass
	{
		 get { } //Length: 8
		 set { } //Length: 20
	}

	protected ScriptableRendererData() { }

	protected abstract ScriptableRenderer Create() { }

	[CompilerGenerated]
	internal bool get_isInvalidated() { }

	public List<ScriptableRendererFeature> get_rendererFeatures() { }

	public bool get_useNativeRenderPass() { }

	internal ScriptableRenderer InternalCreateRenderer() { }

	protected override void OnEnable() { }

	protected override void OnValidate() { }

	[CompilerGenerated]
	internal void set_isInvalidated(bool value) { }

	public void set_useNativeRenderPass(bool value) { }

	public void SetDirty() { }

	internal bool TryGetRendererFeature(out T rendererFeature) { }

}

