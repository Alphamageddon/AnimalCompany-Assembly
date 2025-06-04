namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public struct PokeStateData : IEquatable<PokeStateData>
{
	[CompilerGenerated]
	private bool <meetsRequirements>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3 <pokeInteractionPoint>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private Vector3 <axisAlignedPokeInteractionPoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <interactionStrength>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Vector3 <axisNormal>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Transform <target>k__BackingField; //Field offset: 0x30

	public Vector3 axisAlignedPokeInteractionPoint
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector3 axisNormal
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public float interactionStrength
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool meetsRequirements
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector3 pokeInteractionPoint
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Transform target
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool Equals(PokeStateData other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_axisAlignedPokeInteractionPoint() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_axisNormal() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_interactionStrength() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_meetsRequirements() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_pokeInteractionPoint() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Transform get_target() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_axisAlignedPokeInteractionPoint(Vector3 value) { }

	[CompilerGenerated]
	public void set_axisNormal(Vector3 value) { }

	[CompilerGenerated]
	public void set_interactionStrength(float value) { }

	[CompilerGenerated]
	public void set_meetsRequirements(bool value) { }

	[CompilerGenerated]
	public void set_pokeInteractionPoint(Vector3 value) { }

	[CompilerGenerated]
	public void set_target(Transform value) { }

}

