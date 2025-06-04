//Type is in global namespace

[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius; //Field offset: 0x38
	[Tooltip("The height of the capsule.")]
	public float m_Height; //Field offset: 0x3C
	[Tooltip("The other radius of the capsule.")]
	public float m_Radius2; //Field offset: 0x40
	private float m_ScaledRadius; //Field offset: 0x44
	private float m_ScaledRadius2; //Field offset: 0x48
	private Vector3 m_C0; //Field offset: 0x4C
	private Vector3 m_C1; //Field offset: 0x58
	private float m_C01Distance; //Field offset: 0x64
	private int m_CollideType; //Field offset: 0x68

	public DynamicBoneCollider() { }

	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	private static void DrawCapsule(Vector3 c0, Vector3 c1, float radius0, float radius1) { }

	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	private static bool InsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	private void OnDrawGizmosSelected() { }

	private void OnValidate() { }

	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	private static bool OutsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	public virtual void Prepare() { }

}

