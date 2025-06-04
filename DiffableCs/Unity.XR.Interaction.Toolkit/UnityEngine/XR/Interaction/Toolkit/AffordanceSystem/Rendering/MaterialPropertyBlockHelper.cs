namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

[AddComponentMenu("Affordance System/Rendering/Material Property Block Helper", 12)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering.MaterialPropertyBlockHelper.html")]
public class MaterialPropertyBlockHelper : MaterialHelperBase
{
	private MaterialPropertyBlock m_PropertyBlock; //Field offset: 0x30
	private bool m_IsDirty; //Field offset: 0x38

	public MaterialPropertyBlockHelper() { }

	public MaterialPropertyBlock GetMaterialPropertyBlock(bool markPropertyBlockAsDirty = true) { }

	protected virtual void Initialize() { }

	protected void LateUpdate() { }

	protected void OnDestroy() { }

}

