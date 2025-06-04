namespace Fusion;

public static class NetworkBehaviourUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<RpcInvokeData> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <RegisterRpcInvokeDelegates>b__13_0(RpcInvokeData a, RpcInvokeData b) { }

	}

	internal struct ArrayInitializer
	{

		public static NetworkArray<T> op_Implicit(ArrayInitializer<T> arr) { }

		public static NetworkLinkedList<T> op_Implicit(ArrayInitializer<T> arr) { }

	}

	internal struct DictionaryInitializer
	{

		public static NetworkDictionary<K, V> op_Implicit(DictionaryInitializer<K, V> arr) { }

	}

	internal struct MetaData
	{

	}

	private static Dictionary<Type, Int32> _wordCounts; //Field offset: 0x0
	private static Dictionary<Type, RpcInvokeData[]> _invokerDelegates; //Field offset: 0x8
	private static SortedList<String, RpcStaticInvokeDelegate> _staticInvokers; //Field offset: 0x10
	private static Dictionary<Type, MetaData> _metaData; //Field offset: 0x18
	public static bool InvokeRpc; //Field offset: 0x20

	private static NetworkBehaviourUtils() { }

	public static T[] CloneArray(T[] array) { }

	public static void CopyFromNetworkArray(NetworkArray<T> networkArray, ref T[] dstArray) { }

	public static void CopyFromNetworkDictionary(NetworkDictionary<K, V> networkDictionary, ref D dictionary) { }

	public static void CopyFromNetworkList(NetworkLinkedList<T> networkList, ref T[] dstArray) { }

	public static MetaData GetMetaData(Type type) { }

	public static int GetRpcStaticIndexOrThrow(string key) { }

	public static int GetStaticWordCount(Type type) { }

	public static int GetWordCount(NetworkBehaviour behaviour) { }

	public static bool HasStaticWordCount(Type type) { }

	public static void InitializeNetworkArray(NetworkArray<T> networkArray, T[] sourceArray, string name) { }

	public static void InitializeNetworkDictionary(NetworkDictionary<K, V> networkDictionary, D dictionary, string name) { }

	public static void InitializeNetworkList(NetworkLinkedList<T> networkList, T[] sourceArray, string name) { }

	public static void InternalOnDestroy(SimulationBehaviour obj) { }

	public static void InternalOnDisable(SimulationBehaviour obj) { }

	public static void InternalOnEnable(SimulationBehaviour obj) { }

	public static SerializableDictionary<K, V> MakeSerializableDictionary(Dictionary<K, V> dictionary) { }

	public static void NotifyLocalSimulationNotAllowedToSendRpc(string rpc, NetworkObject obj, int sources) { }

	public static void NotifyLocalTargetedRpcCulled(PlayerRef player, string methodName) { }

	public static void NotifyNetworkUnwrapFailed(T wrapper, Type valueType) { }

	public static void NotifyNetworkWrapFailed(T value) { }

	public static void NotifyNetworkWrapFailed(T value, Type wrapperType) { }

	public static void NotifyRpcPayloadSizeExceeded(string rpc, int size) { }

	public static void NotifyRpcTargetUnreachable(PlayerRef player, string rpc) { }

	public static void RegisterMetaData(Type type) { }

	public static void RegisterRpcInvokeDelegates(Type type) { }

	internal static void ResetStatics() { }

	public static bool ShouldRegisterRpcInvokeDelegates(Type type) { }

	public static void ThrowIfBehaviourNotInitialized(NetworkBehaviour behaviour) { }

	public static bool TryGetRpcInvokeDelegateArray(Type type, out RpcInvokeData[] delegates) { }

	public static bool TryGetRpcStaticInvokeDelegate(int index, out RpcStaticInvokeDelegate del) { }

}

