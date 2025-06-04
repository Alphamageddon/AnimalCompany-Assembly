namespace Unity.XR.CoreUtils.Collections;

public class SerializableDictionary : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	internal struct Item
	{
		public TKey Key; //Field offset: 0x0
		public TValue Value; //Field offset: 0x0

	}

	[SerializeField]
	private List<Item<TKey, TValue>> m_Items; //Field offset: 0x0

	public List<Item<TKey, TValue>> SerializedItems
	{
		 get { } //Length: 8
	}

	public SerializableDictionary`2() { }

	public SerializableDictionary`2(IDictionary<TKey, TValue> input) { }

	public List<Item<TKey, TValue>> get_SerializedItems() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

