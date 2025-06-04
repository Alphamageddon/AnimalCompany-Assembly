namespace Fusion.Sockets.Stun;

internal class StunMessage
{
	private enum AttributeType
	{
		MappedAddress = 1,
		Username = 6,
		MessageIntegrity = 8,
		ErrorCode = 9,
		UnknownAttribute = 10,
		Realm = 20,
		Nonce = 21,
		XorMappedAddress = 32,
	}

	private enum IPFamily
	{
		IPv4 = 1,
		IPv6 = 2,
	}

	public static class StunDefines
	{
		public const int STUN_MAGIC_COOKIE = 554869826; //Field offset: 0x0
		public const ulong STUN_MAGIC_COOKIE_NETWORK_ORDER = 1118048801; //Field offset: 0x0
		public const short STUN_MAGIC_COOKIE_PARTIAL = 8466; //Field offset: 0x0
		public const int STUN_XOR_FINGERPRINT = 1398035790; //Field offset: 0x0
		public const int HEADER_SIZE = 20; //Field offset: 0x0
		public const int TRANSACTION_ID_SIZE = 12; //Field offset: 0x0

	}

	internal enum StunMessageType
	{
		BindingRequest = 1,
		BindingResponse = 257,
		BindingErrorResponse = 273,
		SharedSecretRequest = 2,
		SharedSecretResponse = 258,
		SharedSecretErrorResponse = 274,
	}

	private static HashSet<Int32> _stunMessageTypeValues; //Field offset: 0x0
	[CompilerGenerated]
	private StunMessageType <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Byte[] <TransactionID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <UserName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private StunErrorAttribute <ErrorCode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<AttributeType, Object> <Attributes>k__BackingField; //Field offset: 0x30
	private Guid _id; //Field offset: 0x38

	private Dictionary<AttributeType, Object> Attributes
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public StunErrorAttribute ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Guid ID
	{
		 get { } //Length: 196
	}

	public IPEndPoint MappedAddress
	{
		 get { } //Length: 180
		 set { } //Length: 92
	}

	private static HashSet<Int32> StunMessageTypeValues
	{
		private get { } //Length: 1004
	}

	private Byte[] TransactionID
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StunMessageType Type
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public string UserName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StunMessage(Guid msgID, StunMessageType messageType = 1) { }

	[CompilerGenerated]
	private Dictionary<AttributeType, Object> get_Attributes() { }

	[CompilerGenerated]
	public StunErrorAttribute get_ErrorCode() { }

	public Guid get_ID() { }

	public IPEndPoint get_MappedAddress() { }

	private static HashSet<Int32> get_StunMessageTypeValues() { }

	[CompilerGenerated]
	private Byte[] get_TransactionID() { }

	[CompilerGenerated]
	public StunMessageType get_Type() { }

	[CompilerGenerated]
	public string get_UserName() { }

	public static bool IsStunMessage(Byte* data, int length) { }

	private IPEndPoint ParseEndPoint(Byte* data, ref int offset) { }

	private IPEndPoint ParseXorEndPoint(Byte* data, ref int offset) { }

	private void ReadAttribute(Byte* data, ref int offset) { }

	public Byte[] Serialize() { }

	[CompilerGenerated]
	private void set_Attributes(Dictionary<AttributeType, Object> value) { }

	[CompilerGenerated]
	public void set_ErrorCode(StunErrorAttribute value) { }

	public void set_MappedAddress(IPEndPoint value) { }

	[CompilerGenerated]
	private void set_TransactionID(Byte[] value) { }

	[CompilerGenerated]
	private void set_Type(StunMessageType value) { }

	[CompilerGenerated]
	public void set_UserName(string value) { }

	private void StoreEndPoint(AttributeType type, IPEndPoint endPoint, Byte[] message, ref int offset) { }

	public static StunMessage TryParse(Byte* data, int length) { }

	private void WriteAttributes(Byte[] msg, ref int offset) { }

}

