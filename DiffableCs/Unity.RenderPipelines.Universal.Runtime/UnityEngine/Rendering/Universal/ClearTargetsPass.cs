namespace UnityEngine.Rendering.Universal;

internal class ClearTargetsPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RenderFunc<PassData> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__2_0(PassData data, RenderGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle color; //Field offset: 0x10
		internal TextureHandle depth; //Field offset: 0x18
		internal RTClearFlags clearFlags; //Field offset: 0x20
		internal Color clearColor; //Field offset: 0x24

		public PassData() { }

	}

	private static ProfilingSampler s_ClearProfilingSampler; //Field offset: 0x0

	private static ClearTargetsPass() { }

	public ClearTargetsPass() { }

	internal static void Render(RenderGraph graph, UniversalRenderer renderer, RTClearFlags clearFlags, Color clearColor) { }

}

