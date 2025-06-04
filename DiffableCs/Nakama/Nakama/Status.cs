namespace Nakama;

internal class Status : IStatus
{
	[CompilerGenerated]
	private List<UserPresence> <PresencesField>k__BackingField; //Field offset: 0x10

	public override IEnumerable<IUserPresence> Presences
	{
		 get { } //Length: 100
	}

	[DataMember(Name = "presences")]
	[Preserve]
	public List<UserPresence> PresencesField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Status() { }

	public override IEnumerable<IUserPresence> get_Presences() { }

	[CompilerGenerated]
	public List<UserPresence> get_PresencesField() { }

	[CompilerGenerated]
	public void set_PresencesField(List<UserPresence> value) { }

	public virtual string ToString() { }

}

