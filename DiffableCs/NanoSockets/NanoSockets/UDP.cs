namespace NanoSockets;

public static class UDP
{
	private const string NativeLibrary = "nanosockets"; //Field offset: 0x0
	public const int HostNameSize = 1025; //Field offset: 0x0

	public static int Bind(long socket, IntPtr address) { }

	public static int Bind(long socket, ref Address address) { }

	public static int Connect(long socket, ref Address address) { }

	public static long Create(int sendBufferSize, int receiveBufferSize) { }

	public static void Deinitialize() { }

	public static void Destroy(ref long socket) { }

	public static Status GetAddress(long socket, ref Address address) { }

	public static Status GetHostName(ref Address address, StringBuilder name, int nameLength) { }

	public static Status GetHostName(ref Address address, IntPtr name, int nameLength) { }

	public static Status GetIP(ref Address address, StringBuilder ip, int ipLength) { }

	public static Status GetIP(ref Address address, IntPtr ip, int ipLength) { }

	public static Status GetOption(long socket, int level, int optionName, ref int optionValue, ref int optionLength) { }

	public static Status Initialize() { }

	public static Status IsEqual(ref Address left, ref Address right) { }

	public static int Poll(long socket, long timeout) { }

	public static int Receive(long socket, IntPtr address, IntPtr buffer, int bufferLength) { }

	public static int Receive(long socket, IntPtr address, Byte[] buffer, int bufferLength) { }

	public static int Receive(long socket, ref Address address, IntPtr buffer, int bufferLength) { }

	public static int Receive(long socket, ref Address address, Byte[] buffer, int bufferLength) { }

	public static int Receive(long socket, Address* address, Byte* buffer, int bufferLength) { }

	public static int Send(long socket, ref Address address, IntPtr buffer, int bufferLength) { }

	public static int Send(long socket, IntPtr address, Byte[] buffer, int bufferLength) { }

	public static int Send(long socket, Address* address, Byte* buffer, int bufferLength) { }

	public static int Send(long socket, ref Address address, Byte[] buffer, int bufferLength) { }

	public static int Send(long socket, IntPtr address, IntPtr buffer, int bufferLength) { }

	public static Status SetDontFragment(long socket, byte df) { }

	public static Status SetHostName(ref Address address, IntPtr name) { }

	public static Status SetHostName(ref Address address, string name) { }

	public static Status SetIP(ref Address address, IntPtr ip) { }

	public static Status SetIP(ref Address address, string ip) { }

	public static Status SetNonBlocking(long socket) { }

	public static Status SetOption(long socket, int level, int optionName, ref int optionValue, int optionLength) { }

}

