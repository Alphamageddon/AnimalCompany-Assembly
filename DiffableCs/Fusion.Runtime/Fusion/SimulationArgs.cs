namespace Fusion;

internal struct SimulationArgs
{
	public SimulationModes Mode; //Field offset: 0x0
	public NetAddress Address; //Field offset: 0x8
	public INetSocket Socket; //Field offset: 0x20
	public NetworkProjectConfig Config; //Field offset: 0x28
	public ICallbacks Callbacks; //Field offset: 0x30
	public Tick ResumeTick; //Field offset: 0x38
	public Byte[] ResumeState; //Field offset: 0x40
	public NetworkId ResumeNetworkId; //Field offset: 0x48

	public bool IsPlayer
	{
		 get { } //Length: 28
	}

	public bool IsServer
	{
		 get { } //Length: 20
	}

	public bool get_IsPlayer() { }

	public bool get_IsServer() { }

}

