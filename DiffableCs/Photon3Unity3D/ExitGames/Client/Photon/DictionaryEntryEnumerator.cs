namespace ExitGames.Client.Photon;

public struct DictionaryEntryEnumerator : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
{
	private Enumerator<Object, Object> enumerator; //Field offset: 0x0

	public override DictionaryEntry Current
	{
		 get { } //Length: 112
	}

	public object Key
	{
		 get { } //Length: 72
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 148
	}

	public object Value
	{
		 get { } //Length: 72
	}

	public DictionaryEntryEnumerator(Enumerator<Object, Object> original) { }

	public override void Dispose() { }

	public override DictionaryEntry get_Current() { }

	public object get_Key() { }

	public object get_Value() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

