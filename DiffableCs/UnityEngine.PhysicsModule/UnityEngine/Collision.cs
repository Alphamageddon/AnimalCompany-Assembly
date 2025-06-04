namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header; //Field offset: 0x10
	private ContactPair m_Pair; //Field offset: 0x38
	private bool m_Flipped; //Field offset: 0x60
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	public Component body
	{
		 get { } //Length: 20
	}

	public Collider collider
	{
		 get { } //Length: 20
	}

	public int contactCount
	{
		 get { } //Length: 8
	}

	public ContactPoint[] contacts
	{
		 get { } //Length: 164
	}

	internal bool Flipped
	{
		internal set { } //Length: 12
	}

	public GameObject gameObject
	{
		 get { } //Length: 148
	}

	public Vector3 relativeVelocity
	{
		 get { } //Length: 44
	}

	public Rigidbody rigidbody
	{
		 get { } //Length: 128
	}

	public Collision() { }

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	public Component get_body() { }

	public Collider get_collider() { }

	public int get_contactCount() { }

	public ContactPoint[] get_contacts() { }

	public GameObject get_gameObject() { }

	public Vector3 get_relativeVelocity() { }

	public Rigidbody get_rigidbody() { }

	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	internal void set_Flipped(bool value) { }

}

