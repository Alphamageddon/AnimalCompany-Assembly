//Type is in global namespace

[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public Transform root; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <SetupParticles>b__0(ParticleTree x) { }

	}

	internal enum FreezeAxis
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3,
	}

	private class Particle
	{
		public Transform m_Transform; //Field offset: 0x10
		public int m_ParentIndex; //Field offset: 0x18
		public int m_ChildCount; //Field offset: 0x1C
		public float m_Damping; //Field offset: 0x20
		public float m_Elasticity; //Field offset: 0x24
		public float m_Stiffness; //Field offset: 0x28
		public float m_Inert; //Field offset: 0x2C
		public float m_Friction; //Field offset: 0x30
		public float m_Radius; //Field offset: 0x34
		public float m_BoneLength; //Field offset: 0x38
		public bool m_isCollide; //Field offset: 0x3C
		public bool m_TransformNotNull; //Field offset: 0x3D
		public Vector3 m_Position; //Field offset: 0x40
		public Vector3 m_PrevPosition; //Field offset: 0x4C
		public Vector3 m_EndOffset; //Field offset: 0x58
		public Vector3 m_InitLocalPosition; //Field offset: 0x64
		public Quaternion m_InitLocalRotation; //Field offset: 0x70
		public Vector3 m_TransformPosition; //Field offset: 0x80
		public Vector3 m_TransformLocalPosition; //Field offset: 0x8C
		public Matrix4x4 m_TransformLocalToWorldMatrix; //Field offset: 0x98

		public Particle() { }

	}

	private class ParticleTree
	{
		public Transform m_Root; //Field offset: 0x10
		public Vector3 m_LocalGravity; //Field offset: 0x18
		public Matrix4x4 m_RootWorldToLocalMatrix; //Field offset: 0x24
		public float m_BoneTotalLength; //Field offset: 0x64
		public List<Particle> m_Particles; //Field offset: 0x68
		public Vector3 m_RestGravity; //Field offset: 0x70

		public ParticleTree() { }

	}

	internal enum UpdateMode
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2,
		Default = 3,
	}

	private static int s_UpdateCount; //Field offset: 0x0
	private static int s_PrepareFrame; //Field offset: 0x4
	[Tooltip("The roots of the transform hierarchy to apply physics.")]
	public Transform m_Root; //Field offset: 0x20
	public List<Transform> m_Roots; //Field offset: 0x28
	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate; //Field offset: 0x30
	public UpdateMode m_UpdateMode; //Field offset: 0x34
	[Range(0, 1)]
	[Tooltip("How much the bones slowed down.")]
	public float m_Damping; //Field offset: 0x38
	public AnimationCurve m_DampingDistrib; //Field offset: 0x40
	[Range(0, 1)]
	[Tooltip("How much the force applied to return each bone to original orientation.")]
	public float m_Elasticity; //Field offset: 0x48
	public AnimationCurve m_ElasticityDistrib; //Field offset: 0x50
	[Range(0, 1)]
	[Tooltip("How much bone's original orientation are preserved.")]
	public float m_Stiffness; //Field offset: 0x58
	public AnimationCurve m_StiffnessDistrib; //Field offset: 0x60
	[Range(0, 1)]
	[Tooltip("How much character's position change is ignored in physics simulation.")]
	public float m_Inert; //Field offset: 0x68
	public AnimationCurve m_InertDistrib; //Field offset: 0x70
	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction; //Field offset: 0x78
	public AnimationCurve m_FrictionDistrib; //Field offset: 0x80
	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius; //Field offset: 0x88
	public AnimationCurve m_RadiusDistrib; //Field offset: 0x90
	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength; //Field offset: 0x98
	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset; //Field offset: 0x9C
	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity; //Field offset: 0xA8
	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force; //Field offset: 0xB4
	[Range(0, 1)]
	[Tooltip("Control how physics blends with existing animation.")]
	public float m_BlendWeight; //Field offset: 0xC0
	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders; //Field offset: 0xC8
	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions; //Field offset: 0xD0
	[Tooltip("Constrain bones to move on specified plane.")]
	public FreezeAxis m_FreezeAxis; //Field offset: 0xD8
	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable; //Field offset: 0xDC
	public Transform m_ReferenceObject; //Field offset: 0xE0
	public float m_DistanceToObject; //Field offset: 0xE8
	[HideInInspector]
	public bool m_Multithread; //Field offset: 0xEC
	private Vector3 m_ObjectMove; //Field offset: 0xF0
	private Vector3 m_ObjectPrevPosition; //Field offset: 0xFC
	private float m_ObjectScale; //Field offset: 0x108
	private float m_Time; //Field offset: 0x10C
	private float m_Weight; //Field offset: 0x110
	private bool m_DistantDisabled; //Field offset: 0x114
	private int m_PreUpdateCount; //Field offset: 0x118
	private List<ParticleTree> m_ParticleTrees; //Field offset: 0x120
	private float m_DeltaTime; //Field offset: 0x128
	private List<DynamicBoneColliderBase> m_EffectiveColliders; //Field offset: 0x130

	public DynamicBone() { }

	private void AppendParticles(ParticleTree pt, Transform b, int parentIndex, float boneLength) { }

	private void AppendParticleTree(Transform root) { }

	private void ApplyParticlesToTransforms() { }

	private void ApplyParticlesToTransforms(ParticleTree pt, Vector3 ax, Vector3 ay, Vector3 az, bool nx, bool ny, bool nz) { }

	private void CheckDistance() { }

	private void DrawGizmos(ParticleTree pt) { }

	private void FixedUpdate() { }

	public float GetWeight() { }

	private void InitTransforms(ParticleTree pt) { }

	private void InitTransforms() { }

	private bool IsNeedUpdate() { }

	private bool IsRootChanged() { }

	private void LateUpdate() { }

	private static Vector3 MirrorVector(Vector3 v, Vector3 axis) { }

	private void OnDidApplyAnimationProperties() { }

	private void OnDisable() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnValidate() { }

	private void Prepare() { }

	private void PreUpdate() { }

	private void ResetParticlesPosition(ParticleTree pt) { }

	private void ResetParticlesPosition() { }

	public void SetupParticles() { }

	public void SetWeight(float w) { }

	private void SkipUpdateParticles() { }

	private void SkipUpdateParticles(ParticleTree pt) { }

	private void Start() { }

	private void Update() { }

	public void UpdateParameters() { }

	private void UpdateParameters(ParticleTree pt) { }

	private void UpdateParticles() { }

	private void UpdateParticles1(float timeVar, int loopIndex) { }

	private void UpdateParticles1(ParticleTree pt, float timeVar, int loopIndex) { }

	private void UpdateParticles2(float timeVar) { }

	private void UpdateParticles2(ParticleTree pt, float timeVar) { }

}

