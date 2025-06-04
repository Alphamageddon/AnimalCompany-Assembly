namespace SpatialSys.ObservableState;

public class StateSerializationPair : StateSerializationPair
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Func<T, JSONNode> serializer; //Field offset: 0x0
		public Func<JSONNode, T> deserializer; //Field offset: 0x0

		public <>c__DisplayClass8_0() { }

		internal JSONNode <.ctor>b__0(object value) { }

		internal object <.ctor>b__1(JSONNode json) { }

	}

	[CompilerGenerated]
	private Func<T, JSONNode> <serializer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Func<JSONNode, T> <deserializer>k__BackingField; //Field offset: 0x0

	public private Func<JSONNode, T> deserializer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Func<T, JSONNode> serializer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public StateSerializationPair`1(Func<T, JSONNode> serializer, Func<JSONNode, T> deserializer) { }

	[CompilerGenerated]
	public Func<JSONNode, T> get_deserializer() { }

	[CompilerGenerated]
	public Func<T, JSONNode> get_serializer() { }

	[CompilerGenerated]
	private void set_deserializer(Func<JSONNode, T> value) { }

	[CompilerGenerated]
	private void set_serializer(Func<T, JSONNode> value) { }

}

