//Type is in global namespace

public class DynamicBoneColliderBase : MonoBehaviour
{
	internal enum Bound
	{
		Outside = 0,
		Inside = 1,
	}

	internal enum Direction
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[Tooltip("The axis of the capsule's height.")]
	public Direction m_Direction; //Field offset: 0x20
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center; //Field offset: 0x24
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public Bound m_Bound; //Field offset: 0x30
	[CompilerGenerated]
	private int <PrepareFrame>k__BackingField; //Field offset: 0x34

	public int PrepareFrame
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public DynamicBoneColliderBase() { }

	public override bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	[CompilerGenerated]
	public int get_PrepareFrame() { }

	public override void Prepare() { }

	[CompilerGenerated]
	public void set_PrepareFrame(int value) { }

	public override void Start() { }

}

