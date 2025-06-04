namespace Nakama;

internal class StreamState : IStreamState
{
	[CompilerGenerated]
	private UserPresence <SenderField>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <StateField>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Stream <StreamField>k__BackingField; //Field offset: 0x20

	public override IUserPresence Sender
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "sender")]
	[Preserve]
	public UserPresence SenderField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override string State
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "data")]
	[Preserve]
	public string StateField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IStream Stream
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "stream")]
	[Preserve]
	public Stream StreamField
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public StreamState() { }

	public override IUserPresence get_Sender() { }

	[CompilerGenerated]
	public UserPresence get_SenderField() { }

	public override string get_State() { }

	[CompilerGenerated]
	public string get_StateField() { }

	public override IStream get_Stream() { }

	[CompilerGenerated]
	public Stream get_StreamField() { }

	[CompilerGenerated]
	public void set_SenderField(UserPresence value) { }

	[CompilerGenerated]
	public void set_StateField(string value) { }

	[CompilerGenerated]
	public void set_StreamField(Stream value) { }

	public virtual string ToString() { }

}

