namespace SpatialSys.ObservableState.Utilities;

public class DictionaryObserverHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0
		public static Func<TValue, IStateObject[]> <>9__6_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal IStateObject[] <.ctor>b__6_0(TValue x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public DictionaryObserverHelper<TKey, TValue> <>4__this; //Field offset: 0x0
		public TKey key; //Field offset: 0x0

		public <>c__DisplayClass10_0() { }

		internal void <AddObserverIfNecessary>b__0(StateChangedEventArgs x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Func<TValue, IStateObject> stateSelector; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal IStateObject[] <.ctor>b__0(TValue x) { }

	}

	internal sealed class KeyObserverDelegate : MulticastDelegate
	{

		public KeyObserverDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TKey key, StateChangedEventArgs args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TKey key, StateChangedEventArgs args) { }

	}

	private StateDictionary<TKey, TValue> _dict; //Field offset: 0x0
	private Func<TValue, IStateObject[]> _stateSelector; //Field offset: 0x0
	private KeyObserverDelegate<TKey, TValue> _keyObserver; //Field offset: 0x0
	private Dictionary<TKey, ObserverDelegate> _entryObservers; //Field offset: 0x0

	public DictionaryObserverHelper`2(StateDictionary<TKey, TValue> dict, Func<TValue, IStateObject> stateSelector, KeyObserverDelegate<TKey, TValue> observer) { }

	public DictionaryObserverHelper`2(StateDictionary<TKey, TValue> dict, KeyObserverDelegate<TKey, TValue> observer) { }

	public DictionaryObserverHelper`2(StateDictionary<TKey, TValue> dict, Func<TValue, IStateObject[]> stateSelector, KeyObserverDelegate<TKey, TValue> observer) { }

	private void AddObserverIfNecessary(TKey key) { }

	public void Deregister() { }

	private void HandleObservedDictionaryChanged(StateChangedEventArgs args) { }

	private void RemoveObserverIfNecessary(TKey key) { }

}

