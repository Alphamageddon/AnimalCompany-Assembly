namespace AnimalCompany;

public class UserAvatarState : StateObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StatePrimitive`1<String>, String> <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToApiModel>b__45_0(StatePrimitive<String> x) { }

	}

	[CompilerGenerated]
	private sealed class <get_itemIDs>d__48 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public UserAvatarState <>4__this; //Field offset: 0x28
		private IEnumerator<StatePrimitive`1<String>> <>7__wrap1; //Field offset: 0x30

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_itemIDs>d__48(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private StatePrimitive<DateTime> <dataUpdatedAt>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StatePrimitive<Color> <primaryColor>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private StatePrimitive<String> <head>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private StatePrimitive<String> <eyeLeft>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private StatePrimitive<String> <eyeRight>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private StatePrimitive<String> <torso>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private StatePrimitive<String> <armLeft>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private StatePrimitive<String> <armRight>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private StatePrimitive<String> <butt>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private StatePrimitive<String> <tail>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private StateList<StatePrimitive`1<String>> <accessories>k__BackingField; //Field offset: 0x98

	public private StateList<StatePrimitive`1<String>> accessories
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> armLeft
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> armRight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> butt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<DateTime> dataUpdatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> eyeLeft
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> eyeRight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> head
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public IEnumerable<String> itemIDs
	{
		[IteratorStateMachine(typeof(<get_itemIDs>d__48))]
		 get { } //Length: 112
	}

	public private StatePrimitive<Color> primaryColor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> tail
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<String> torso
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public UserAvatarState() { }

	public void FromApiModel(ApiUserAvatar apiModel, string userID) { }

	[CompilerGenerated]
	public StateList<StatePrimitive`1<String>> get_accessories() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_armLeft() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_armRight() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_butt() { }

	[CompilerGenerated]
	public StatePrimitive<DateTime> get_dataUpdatedAt() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_eyeLeft() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_eyeRight() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_head() { }

	[IteratorStateMachine(typeof(<get_itemIDs>d__48))]
	public IEnumerable<String> get_itemIDs() { }

	[CompilerGenerated]
	public StatePrimitive<Color> get_primaryColor() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_tail() { }

	[CompilerGenerated]
	public StatePrimitive<String> get_torso() { }

	public StatePrimitive<String> GetStateFromPartType(ApiAvatarItemType partType) { }

	[CompilerGenerated]
	private void set_accessories(StateList<StatePrimitive`1<String>> value) { }

	[CompilerGenerated]
	private void set_armLeft(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_armRight(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_butt(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_dataUpdatedAt(StatePrimitive<DateTime> value) { }

	[CompilerGenerated]
	private void set_eyeLeft(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_eyeRight(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_head(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_primaryColor(StatePrimitive<Color> value) { }

	[CompilerGenerated]
	private void set_tail(StatePrimitive<String> value) { }

	[CompilerGenerated]
	private void set_torso(StatePrimitive<String> value) { }

	public ApiUserAvatar ToApiModel() { }

}

