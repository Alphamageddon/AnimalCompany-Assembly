namespace ExitGames.Client.Photon;

public class Protocol
{
	internal static readonly Dictionary<Type, CustomType> TypeDict; //Field offset: 0x0
	internal static readonly Dictionary<Byte, CustomType> CodeDict; //Field offset: 0x8
	private static IProtocol ProtocolDefault; //Field offset: 0x10
	private static readonly Single[] memFloatBlock; //Field offset: 0x18
	private static readonly Byte[] memDeserialize; //Field offset: 0x20

	private static Protocol() { }

	public Protocol() { }

	[Obsolete]
	public static object Deserialize(Byte[] serializedData) { }

	public static void Deserialize(out int value, Byte[] source, ref int offset) { }

	public static void Deserialize(out short value, Byte[] source, ref int offset) { }

	public static void Deserialize(out float value, Byte[] source, ref int offset) { }

	[Obsolete]
	public static Byte[] Serialize(object obj) { }

	public static void Serialize(short value, Byte[] target, ref int targetOffset) { }

	public static void Serialize(int value, Byte[] target, ref int targetOffset) { }

	public static void Serialize(float value, Byte[] target, ref int targetOffset) { }

	public static bool TryRegisterType(Type type, byte typeCode, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction) { }

	public static bool TryRegisterType(Type type, byte typeCode, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction) { }

}

