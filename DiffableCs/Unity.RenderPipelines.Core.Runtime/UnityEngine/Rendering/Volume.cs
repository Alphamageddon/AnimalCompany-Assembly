namespace UnityEngine.Rendering;

[AddComponentMenu("Miscellaneous/Volume")]
[ExecuteAlways]
public class Volume : MonoBehaviour, IVolume
{
	[FormerlySerializedAs("isGlobal")]
	[SerializeField]
	private bool m_IsGlobal; //Field offset: 0x20
	[Delayed]
	[Tooltip("A value which determines which Volume is being used when Volumes have an equal amount of influence on the Scene. Volumes with a higher priority will override lower ones.")]
	public float priority; //Field offset: 0x24
	[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
	public float blendDistance; //Field offset: 0x28
	[Range(0, 1)]
	[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
	public float weight; //Field offset: 0x2C
	public VolumeProfile sharedProfile; //Field offset: 0x30
	internal List<Collider> m_Colliders; //Field offset: 0x38
	private int m_PreviousLayer; //Field offset: 0x40
	private float m_PreviousPriority; //Field offset: 0x44
	private VolumeProfile m_InternalProfile; //Field offset: 0x48

	public override List<Collider> colliders
	{
		 get { } //Length: 8
	}

	[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
	public override bool isGlobal
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public VolumeProfile profile
	{
		 get { } //Length: 720
		 set { } //Length: 8
	}

	internal VolumeProfile profileRef
	{
		internal get { } //Length: 120
	}

	public Volume() { }

	public override List<Collider> get_colliders() { }

	public override bool get_isGlobal() { }

	public VolumeProfile get_profile() { }

	internal VolumeProfile get_profileRef() { }

	public bool HasInstantiatedProfile() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void set_isGlobal(bool value) { }

	public void set_profile(VolumeProfile value) { }

	private void Update() { }

	internal void UpdateLayer() { }

}

