namespace UnityEngine.Rendering.Universal;

internal interface ILight2DCullResult
{

	public List<Light2D> visibleLights
	{
		 get { } //Length: 0
	}

	public List<ShadowCasterGroup2D> visibleShadows
	{
		 get { } //Length: 0
	}

	public List<Light2D> get_visibleLights() { }

	public List<ShadowCasterGroup2D> get_visibleShadows() { }

	public LightStats GetLightStatsByLayer(int layer) { }

	public bool IsSceneLit() { }

}

