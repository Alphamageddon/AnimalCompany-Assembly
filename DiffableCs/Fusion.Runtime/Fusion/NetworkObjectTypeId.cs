namespace Fusion;

[InlineHelp]
[NetworkStructWeaved(2)]
public struct NetworkObjectTypeId : INetworkStruct, IEquatable<NetworkObjectTypeId>
{
	internal sealed class EqualityComparer : IEqualityComparer<NetworkObjectTypeId>
	{

		public EqualityComparer() { }

		public override bool Equals(NetworkObjectTypeId x, NetworkObjectTypeId y) { }

		public override int GetHashCode(NetworkObjectTypeId obj) { }

	}

	public const int SIZE = 8; //Field offset: 0x0
	public const int ALIGNMENT = 4; //Field offset: 0x0
	private const int KIND_MASK = 3; //Field offset: 0x0
	private const int KIND_BITS = 2; //Field offset: 0x0
	private const int SCENE_OBJECT_INDEX_SHIFT = 2; //Field offset: 0x0
	private const int SCENE_OBJECT_INDEX_BITS = 22; //Field offset: 0x0
	private const int SCENE_OBJECT_INDEX_MASK = 4194303; //Field offset: 0x0
	private const int SCENE_OBJECT_LOAD_ID_SHIFT = 24; //Field offset: 0x0
	private const int SCENE_OBJECT_LOAD_ID_BITS = 8; //Field offset: 0x0
	public const int MAX_SCENE_OBJECT_INDEX = 4194303; //Field offset: 0x0
	private const ushort STRUCT_TYPE_PLAYERDATA = 1; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EqualityComparer <Comparer>k__BackingField; //Field offset: 0x0
	private uint _value0; //Field offset: 0x0
	private uint _value1; //Field offset: 0x4

	public uint AsCustom
	{
		 get { } //Length: 292
	}

	public ushort AsInternalStructId
	{
		 get { } //Length: 292
	}

	public NetworkPrefabId AsPrefabId
	{
		 get { } //Length: 288
	}

	public NetworkSceneObjectId AsSceneObjectId
	{
		 get { } //Length: 304
	}

	public static EqualityComparer Comparer
	{
		[CompilerGenerated]
		 get { } //Length: 88
	}

	public bool IsCustom
	{
		 get { } //Length: 112
	}

	public bool IsNone
	{
		 get { } //Length: 96
	}

	public bool IsPrefab
	{
		 get { } //Length: 108
	}

	public bool IsSceneObject
	{
		 get { } //Length: 112
	}

	public bool IsStruct
	{
		 get { } //Length: 112
	}

	public bool IsValid
	{
		 get { } //Length: 96
	}

	public NetworkTypeIdKind Kind
	{
		 get { } //Length: 28
	}

	public static NetworkObjectTypeId PlayerData
	{
		 get { } //Length: 84
	}

	private static NetworkObjectTypeId() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NetworkObjectTypeId other) { }

	public static NetworkObjectTypeId FromCustom(uint raw) { }

	public static NetworkObjectTypeId FromPrefabId(NetworkPrefabId prefabId) { }

	public static NetworkObjectTypeId FromSceneRefAndObjectIndex(SceneRef sceneRef, int objIndex, NetworkSceneLoadId loadId = null) { }

	public static NetworkObjectTypeId FromStruct(ushort structId) { }

	public uint get_AsCustom() { }

	public ushort get_AsInternalStructId() { }

	public NetworkPrefabId get_AsPrefabId() { }

	public NetworkSceneObjectId get_AsSceneObjectId() { }

	[CompilerGenerated]
	public static EqualityComparer get_Comparer() { }

	public bool get_IsCustom() { }

	public bool get_IsNone() { }

	public bool get_IsPrefab() { }

	public bool get_IsSceneObject() { }

	public bool get_IsStruct() { }

	public bool get_IsValid() { }

	public NetworkTypeIdKind get_Kind() { }

	public static NetworkObjectTypeId get_PlayerData() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NetworkObjectTypeId a, NetworkObjectTypeId b) { }

	public static NetworkObjectTypeId op_Implicit(NetworkPrefabId prefabId) { }

	public static bool op_Inequality(NetworkObjectTypeId a, NetworkObjectTypeId b) { }

	internal static NetworkObjectTypeId ReadInternal(NetBitBuffer* buffer, int blockSize) { }

	public virtual string ToString() { }

	internal static void WriteInternal(NetworkObjectTypeId typeId, NetBitBuffer* buffer, int blockSize) { }

}

