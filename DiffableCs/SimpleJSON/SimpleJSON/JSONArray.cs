namespace SimpleJSON;

[DefaultMember("Item")]
public class JSONArray : JSONNode
{
	[CompilerGenerated]
	private sealed class <get_Children>d__24 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JSONNode <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public JSONArray <>4__this; //Field offset: 0x28
		private Enumerator<JSONNode> <>7__wrap1; //Field offset: 0x30

		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <get_Children>d__24(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[DebuggerHidden]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private List<JSONNode> m_List; //Field offset: 0x10
	private bool inline; //Field offset: 0x18

	public virtual IEnumerable<JSONNode> Children
	{
		[IteratorStateMachine(typeof(<get_Children>d__24))]
		 get { } //Length: 112
	}

	public virtual int Count
	{
		 get { } //Length: 72
	}

	public virtual bool Inline
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public virtual bool IsArray
	{
		 get { } //Length: 8
	}

	public virtual JSONNode Item
	{
		 get { } //Length: 172
		 set { } //Length: 356
	}

	public virtual JSONNode Item
	{
		 get { } //Length: 88
		 set { } //Length: 272
	}

	public virtual JSONNodeType Tag
	{
		 get { } //Length: 8
	}

	public JSONArray() { }

	public virtual void Add(string aKey, JSONNode aItem) { }

	public virtual void Clear() { }

	public virtual JSONNode Clone() { }

	[IteratorStateMachine(typeof(<get_Children>d__24))]
	public virtual IEnumerable<JSONNode> get_Children() { }

	public virtual int get_Count() { }

	public virtual bool get_Inline() { }

	public virtual bool get_IsArray() { }

	public virtual JSONNode get_Item(string aKey) { }

	public virtual JSONNode get_Item(int aIndex) { }

	public virtual JSONNodeType get_Tag() { }

	public virtual Enumerator GetEnumerator() { }

	public virtual JSONNode Remove(int aIndex) { }

	public virtual JSONNode Remove(JSONNode aNode) { }

	public virtual void SerializeBinary(BinaryWriter aWriter) { }

	public virtual void set_Inline(bool value) { }

	public virtual void set_Item(int aIndex, JSONNode value) { }

	public virtual void set_Item(string aKey, JSONNode value) { }

	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

