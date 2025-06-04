namespace Fusion;

[NetworkStructWeaved(22)]
public struct NetworkCCData : INetworkStruct
{
	public const int WORDS = 18; //Field offset: 0x0
	public const int SIZE = 72; //Field offset: 0x0
	public NetworkTRSPData TRSPData; //Field offset: 0x0
	private int _grounded; //Field offset: 0x38
	private Vector3Compressed _velocityData; //Field offset: 0x3C

	public bool Grounded
	{
		 get { } //Length: 16
		 set { } //Length: 12
	}

	public Vector3 Velocity
	{
		 get { } //Length: 20
		 set { } //Length: 32
	}

	public bool get_Grounded() { }

	public Vector3 get_Velocity() { }

	public void set_Grounded(bool value) { }

	public void set_Velocity(Vector3 value) { }

}

