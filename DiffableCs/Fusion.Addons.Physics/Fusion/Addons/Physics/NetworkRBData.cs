namespace Fusion.Addons.Physics;

[NetworkStructWeaved(38)]
public struct NetworkRBData : INetworkStruct
{
	public const int WORDS = 38; //Field offset: 0x0
	public const int SIZE = 152; //Field offset: 0x0
	public NetworkTRSPData TRSPData; //Field offset: 0x0
	public FloatCompressed Drag; //Field offset: 0x38
	public FloatCompressed AngularDrag; //Field offset: 0x3C
	public FloatCompressed Mass; //Field offset: 0x40
	private int _flags; //Field offset: 0x44
	public Vector3Compressed LinearVelocity; //Field offset: 0x48
	public Vector3Compressed AngularVelocity; //Field offset: 0x54
	public Vector3 FullPrecisionPosition; //Field offset: 0x60
	public Quaternion FullPrecisionRotation; //Field offset: 0x6C
	public Vector3Compressed TeleportPosition; //Field offset: 0x7C
	public QuaternionCompressed TeleportRotation; //Field offset: 0x88

	public float AngularVelocity2D
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"flags", "constraints"}])]
	public ValueTuple<NetworkRigidbodyFlags, Int32> Flags
	{
		 get { } //Length: 100
		 set { } //Length: 16
	}

	public float GravityScale2D
	{
		 get { } //Length: 12
		 set { } //Length: 12
	}

	public Vector2 LinearVelocity2D
	{
		 get { } //Length: 180
		 set { } //Length: 312
	}

	public float get_AngularVelocity2D() { }

	public ValueTuple<NetworkRigidbodyFlags, Int32> get_Flags() { }

	public float get_GravityScale2D() { }

	public Vector2 get_LinearVelocity2D() { }

	public void set_AngularVelocity2D(float value) { }

	public void set_Flags(ValueTuple<NetworkRigidbodyFlags, Int32> value) { }

	public void set_GravityScale2D(float value) { }

	public void set_LinearVelocity2D(Vector2 value) { }

}

