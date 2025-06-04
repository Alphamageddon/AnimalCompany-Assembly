namespace UnityEngine;

public struct Pose : IEquatable<Pose>
{
	private static readonly Pose k_Identity; //Field offset: 0x0
	public Vector3 position; //Field offset: 0x0
	public Quaternion rotation; //Field offset: 0xC

	public Vector3 forward
	{
		 get { } //Length: 112
	}

	public static Pose identity
	{
		 get { } //Length: 104
	}

	public Vector3 right
	{
		 get { } //Length: 112
	}

	public Vector3 up
	{
		 get { } //Length: 112
	}

	private static Pose() { }

	public Pose(Vector3 position, Quaternion rotation) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Pose other) { }

	public Vector3 get_forward() { }

	public static Pose get_identity() { }

	public Vector3 get_right() { }

	public Vector3 get_up() { }

	public virtual int GetHashCode() { }

	public Pose GetTransformedBy(Pose lhs) { }

	public Pose GetTransformedBy(Transform lhs) { }

	public virtual string ToString() { }

}

