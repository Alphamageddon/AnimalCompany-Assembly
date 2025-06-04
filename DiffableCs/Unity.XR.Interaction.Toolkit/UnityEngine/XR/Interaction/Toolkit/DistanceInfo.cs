namespace UnityEngine.XR.Interaction.Toolkit;

public struct DistanceInfo
{
	[CompilerGenerated]
	private Vector3 <point>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <distanceSqr>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Collider <collider>k__BackingField; //Field offset: 0x10

	public Collider collider
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float distanceSqr
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Vector3 point
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[CompilerGenerated]
	[IsReadOnly]
	public Collider get_collider() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_distanceSqr() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_point() { }

	[CompilerGenerated]
	public void set_collider(Collider value) { }

	[CompilerGenerated]
	public void set_distanceSqr(float value) { }

	[CompilerGenerated]
	public void set_point(Vector3 value) { }

}

