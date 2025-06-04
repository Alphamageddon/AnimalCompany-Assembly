namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

internal class LinkedPool : IDisposable
{
	public class LinkedPoolItem
	{
		internal LinkedPoolItem<T> poolNext; //Field offset: 0x0
		internal T value; //Field offset: 0x0

		public LinkedPoolItem() { }

	}

	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	private readonly Action<T> m_ActionOnGet; //Field offset: 0x0
	private readonly Action<T> m_ActionOnRelease; //Field offset: 0x0
	private readonly Action<T> m_ActionOnDestroy; //Field offset: 0x0
	private readonly int m_Limit; //Field offset: 0x0
	private LinkedPoolItem<T> m_PoolFirst; //Field offset: 0x0
	private LinkedPoolItem<T> m_NextAvailableListItem; //Field offset: 0x0
	private readonly bool m_CollectionCheck; //Field offset: 0x0
	[CompilerGenerated]
	private int <countInactive>k__BackingField; //Field offset: 0x0

	public private int countInactive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public LinkedPool`1(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int maxSize = 10000) { }

	public void Clear() { }

	public override void Dispose() { }

	public T Get() { }

	public PooledObject<T> Get(out T v) { }

	[CompilerGenerated]
	public int get_countInactive() { }

	public void Release(T item) { }

	[CompilerGenerated]
	private void set_countInactive(int value) { }

}

