namespace UnityEngine.Rendering.Universal;

internal class Light2DCullResult : ILight2DCullResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Light2D> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SetupCulling>b__8_0(Light2D l1, Light2D l2) { }

	}

	private List<Light2D> m_VisibleLights; //Field offset: 0x10
	private List<ShadowCasterGroup2D> m_VisibleShadows; //Field offset: 0x18

	public override List<Light2D> visibleLights
	{
		 get { } //Length: 8
	}

	public override List<ShadowCasterGroup2D> visibleShadows
	{
		 get { } //Length: 8
	}

	public Light2DCullResult() { }

	public override List<Light2D> get_visibleLights() { }

	public override List<ShadowCasterGroup2D> get_visibleShadows() { }

	public override LightStats GetLightStatsByLayer(int layer) { }

	public override bool IsSceneLit() { }

	public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera) { }

}

