namespace UnityEngine.Rendering.Universal;

[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public abstract class ShadowCasterGroup2D : MonoBehaviour
{
	[SerializeField]
	internal int m_ShadowGroup; //Field offset: 0x20
	private List<ShadowCaster2D> m_ShadowCasters; //Field offset: 0x28

	protected ShadowCasterGroup2D() { }

	internal override void CacheValues() { }

	public List<ShadowCaster2D> GetShadowCasters() { }

	public int GetShadowGroup() { }

	public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

	public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D) { }

}

