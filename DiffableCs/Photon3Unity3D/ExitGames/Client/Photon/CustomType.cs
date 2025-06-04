namespace ExitGames.Client.Photon;

internal class CustomType
{
	public readonly byte Code; //Field offset: 0x10
	public readonly Type Type; //Field offset: 0x18
	public readonly SerializeMethod SerializeFunction; //Field offset: 0x20
	public readonly DeserializeMethod DeserializeFunction; //Field offset: 0x28
	public readonly SerializeStreamMethod SerializeStreamFunction; //Field offset: 0x30
	public readonly DeserializeStreamMethod DeserializeStreamFunction; //Field offset: 0x38

	public CustomType(Type type, byte code, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction) { }

	public CustomType(Type type, byte code, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction) { }

}

