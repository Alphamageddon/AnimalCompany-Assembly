namespace ExitGames.Client.Photon;

public struct SendOptions
{
	public static readonly SendOptions SendReliable; //Field offset: 0x0
	public static readonly SendOptions SendUnreliable; //Field offset: 0x8
	public DeliveryMode DeliveryMode; //Field offset: 0x0
	public bool Encrypt; //Field offset: 0x4
	public byte Channel; //Field offset: 0x5

	public bool Reliability
	{
		 get { } //Length: 16
		 set { } //Length: 12
	}

	private static SendOptions() { }

	public bool get_Reliability() { }

	public void set_Reliability(bool value) { }

}

