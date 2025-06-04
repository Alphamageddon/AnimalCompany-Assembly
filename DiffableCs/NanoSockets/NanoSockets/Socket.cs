namespace NanoSockets;

public struct Socket
{
	public long handle; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 16
	}

	public bool get_IsCreated() { }

	public static long op_Implicit(Socket socket) { }

	public static Socket op_Implicit(long handle) { }

}

