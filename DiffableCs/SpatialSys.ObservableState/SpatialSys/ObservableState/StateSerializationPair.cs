namespace SpatialSys.ObservableState;

public abstract class StateSerializationPair
{
	[CompilerGenerated]
	private Func<Object, JSONNode> <objectSerializer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Func<JSONNode, Object> <objectDeserializer>k__BackingField; //Field offset: 0x18

	public Func<JSONNode, Object> objectDeserializer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Func<Object, JSONNode> objectSerializer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected StateSerializationPair() { }

	[CompilerGenerated]
	public Func<JSONNode, Object> get_objectDeserializer() { }

	[CompilerGenerated]
	public Func<Object, JSONNode> get_objectSerializer() { }

	[CompilerGenerated]
	protected void set_objectDeserializer(Func<JSONNode, Object> value) { }

	[CompilerGenerated]
	protected void set_objectSerializer(Func<Object, JSONNode> value) { }

}

