namespace AnimalCompany;

public sealed class AvatarItemsState : StateObject
{
	[CompilerGenerated]
	private StatePrimitive<Boolean> <initialized>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private StateDictionary<String, AvatarItemState> <all>k__BackingField; //Field offset: 0x50

	public private StateDictionary<String, AvatarItemState> all
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private StatePrimitive<Boolean> initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AvatarItemsState() { }

	[CompilerGenerated]
	public StateDictionary<String, AvatarItemState> get_all() { }

	[CompilerGenerated]
	public StatePrimitive<Boolean> get_initialized() { }

	[CompilerGenerated]
	private void set_all(StateDictionary<String, AvatarItemState> value) { }

	[CompilerGenerated]
	private void set_initialized(StatePrimitive<Boolean> value) { }

}

