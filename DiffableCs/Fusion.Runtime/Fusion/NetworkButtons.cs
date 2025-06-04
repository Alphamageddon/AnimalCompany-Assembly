namespace Fusion;

[NetworkStructWeaved(1)]
public struct NetworkButtons : INetworkStruct, IEquatable<NetworkButtons>
{
	private int _bits; //Field offset: 0x0

	public int Bits
	{
		 get { } //Length: 8
	}

	public NetworkButtons(int buttons) { }

	public override bool Equals(NetworkButtons other) { }

	public virtual bool Equals(object obj) { }

	public int get_Bits() { }

	public virtual int GetHashCode() { }

	public NetworkButtons GetPressed(NetworkButtons previous) { }

	public ValueTuple<NetworkButtons, NetworkButtons> GetPressedOrReleased(NetworkButtons previous) { }

	public NetworkButtons GetReleased(NetworkButtons previous) { }

	public bool IsSet(int button) { }

	public bool IsSet(T button) { }

	public void Set(T button, bool state) { }

	public void Set(int button, bool state) { }

	public void SetAllDown() { }

	public void SetAllUp() { }

	public void SetDown(T button) { }

	public void SetDown(int button) { }

	public void SetUp(int button) { }

	public void SetUp(T button) { }

	public bool WasPressed(NetworkButtons previous, int button) { }

	public bool WasPressed(NetworkButtons previous, T button) { }

	public bool WasReleased(NetworkButtons previous, int button) { }

	public bool WasReleased(NetworkButtons previous, T button) { }

}

