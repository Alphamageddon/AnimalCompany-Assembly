namespace Fusion.Photon.Realtime;

internal static class CustomTypesUnity
{
	private const int SizeV2 = 8; //Field offset: 0x0
	private const int SizeV3 = 12; //Field offset: 0x0
	private const int SizeQuat = 16; //Field offset: 0x0
	public static readonly Byte[] memVector3; //Field offset: 0x0
	public static readonly Byte[] memVector2; //Field offset: 0x8
	public static readonly Byte[] memQuarternion; //Field offset: 0x10

	private static CustomTypesUnity() { }

	private static object DeserializeQuaternion(StreamBuffer inStream, short length) { }

	private static object DeserializeVector2(StreamBuffer inStream, short length) { }

	private static object DeserializeVector3(StreamBuffer inStream, short length) { }

	internal static void Register() { }

	private static short SerializeQuaternion(StreamBuffer outStream, object customobject) { }

	private static short SerializeVector2(StreamBuffer outStream, object customobject) { }

	private static short SerializeVector3(StreamBuffer outStream, object customobject) { }

}

