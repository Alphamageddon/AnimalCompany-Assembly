namespace UnityEngine.Animations.Rigging;

[DefaultMember("Item")]
public struct WeightedTransformArray : IList<WeightedTransform>, ICollection<WeightedTransform>, IEnumerable<WeightedTransform>, IEnumerable, IList, ICollection
{
	private struct Enumerator : IEnumerator<WeightedTransform>, IEnumerator, IDisposable
	{
		private WeightedTransformArray m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x88

		public override WeightedTransform Current
		{
			 get { } //Length: 92
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 100
		}

		public Enumerator(ref WeightedTransformArray array) { }

		public override WeightedTransform get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.IDisposable.Dispose() { }

	}

	public static readonly int k_MaxLength; //Field offset: 0x0
	[NotKeyable]
	[SerializeField]
	private int m_Length; //Field offset: 0x0
	[SerializeField]
	private WeightedTransform m_Item0; //Field offset: 0x8
	[SerializeField]
	private WeightedTransform m_Item1; //Field offset: 0x18
	[SerializeField]
	private WeightedTransform m_Item2; //Field offset: 0x28
	[SerializeField]
	private WeightedTransform m_Item3; //Field offset: 0x38
	[SerializeField]
	private WeightedTransform m_Item4; //Field offset: 0x48
	[SerializeField]
	private WeightedTransform m_Item5; //Field offset: 0x58
	[SerializeField]
	private WeightedTransform m_Item6; //Field offset: 0x68
	[SerializeField]
	private WeightedTransform m_Item7; //Field offset: 0x78

	public override int Count
	{
		 get { } //Length: 8
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 8
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 8
	}

	public override WeightedTransform Item
	{
		 get { } //Length: 100
		 set { } //Length: 124
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 8
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 8
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 152
		private set { } //Length: 172
	}

	private static WeightedTransformArray() { }

	public WeightedTransformArray(int size) { }

	public override void Add(WeightedTransform value) { }

	private void CheckOutOfRangeIndex(int index) { }

	private static int ClampSize(int size) { }

	public override void Clear() { }

	public override bool Contains(WeightedTransform value) { }

	public override void CopyTo(WeightedTransform[] array, int arrayIndex) { }

	private WeightedTransform Get(int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override WeightedTransform get_Item(int index) { }

	public override IEnumerator<WeightedTransform> GetEnumerator() { }

	public Transform GetTransform(int index) { }

	public float GetWeight(int index) { }

	public override int IndexOf(WeightedTransform value) { }

	public override void Insert(int index, WeightedTransform value) { }

	public static void OnValidate(ref WeightedTransformArray array, float min = 0, float max = 1) { }

	public override bool Remove(WeightedTransform value) { }

	public override void RemoveAt(int index) { }

	private void Set(int index, WeightedTransform value) { }

	public override void set_Item(int index, WeightedTransform value) { }

	public void SetTransform(int index, Transform transform) { }

	public void SetWeight(int index, float weight) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

