namespace Fusion.LagCompensation;

public class ColliderDrawInfo
{
	internal int Index; //Field offset: 0x10
	internal IHitboxColliderContainer Container; //Field offset: 0x18

	public Vector3 BoxExtents
	{
		 get { } //Length: 184
	}

	public Vector3 CapsuleBottomCenter
	{
		 get { } //Length: 180
	}

	public float CapsuleExtents
	{
		 get { } //Length: 180
	}

	public Vector3 CapsuleTopCenter
	{
		 get { } //Length: 180
	}

	public Matrix4x4 LocalToWorldMatrix
	{
		 get { } //Length: 216
	}

	public Vector3 Offset
	{
		 get { } //Length: 184
	}

	public float Radius
	{
		 get { } //Length: 180
	}

	public HitboxTypes Type
	{
		 get { } //Length: 180
	}

	public ColliderDrawInfo() { }

	internal ColliderDrawInfo FromHitboxCollider(int colliderIndex) { }

	public Vector3 get_BoxExtents() { }

	public Vector3 get_CapsuleBottomCenter() { }

	public float get_CapsuleExtents() { }

	public Vector3 get_CapsuleTopCenter() { }

	public Matrix4x4 get_LocalToWorldMatrix() { }

	public Vector3 get_Offset() { }

	public float get_Radius() { }

	public HitboxTypes get_Type() { }

	internal void SetContainer(IHitboxColliderContainer container) { }

}

