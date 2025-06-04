//Type is in global namespace

[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	private Plane m_Plane; //Field offset: 0x38

	public DynamicBonePlaneCollider() { }

	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	private void OnDrawGizmosSelected() { }

	private void OnValidate() { }

	public virtual void Prepare() { }

}

