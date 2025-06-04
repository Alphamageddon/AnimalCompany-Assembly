namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

[AddComponentMenu("Affordance System/Rendering/Material Instance Helper", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering.MaterialInstanceHelper.html")]
public class MaterialInstanceHelper : MaterialHelperBase
{
	private Material m_MaterialInstance; //Field offset: 0x30

	public MaterialInstanceHelper() { }

	protected virtual void Initialize() { }

	protected void OnDestroy() { }

	public bool TryGetMaterialInstance(out Material materialInstance) { }

}

