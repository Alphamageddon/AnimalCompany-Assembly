namespace UnityEngine.ProBuilder;

public struct Normal : IEquatable<Normal>
{
	[CompilerGenerated]
	private Vector3 <normal>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector4 <tangent>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Vector3 <bitangent>k__BackingField; //Field offset: 0x1C

	public Vector3 bitangent
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector3 normal
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector4 tangent
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Normal other) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_bitangent() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_normal() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector4 get_tangent() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Normal a, Normal b) { }

	public static bool op_Inequality(Normal a, Normal b) { }

	[CompilerGenerated]
	public void set_bitangent(Vector3 value) { }

	[CompilerGenerated]
	public void set_normal(Vector3 value) { }

	[CompilerGenerated]
	public void set_tangent(Vector4 value) { }

}

