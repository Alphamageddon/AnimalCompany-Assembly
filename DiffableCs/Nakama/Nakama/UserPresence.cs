namespace Nakama;

internal class UserPresence : IUserPresence
{
	internal static readonly IReadOnlyList<UserPresence> NoPresences; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Persistence>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <SessionId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Username>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x30

	[DataMember(Name = "persistence")]
	[Preserve]
	public override bool Persistence
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[DataMember(Name = "session_id")]
	[Preserve]
	public override string SessionId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "status")]
	[Preserve]
	public override string Status
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "user_id")]
	[Preserve]
	public override string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "username")]
	[Preserve]
	public override string Username
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static UserPresence() { }

	public UserPresence() { }

	public virtual bool Equals(object obj) { }

	private bool Equals(IUserPresence other) { }

	[CompilerGenerated]
	public override bool get_Persistence() { }

	[CompilerGenerated]
	public override string get_SessionId() { }

	[CompilerGenerated]
	public override string get_Status() { }

	[CompilerGenerated]
	public override string get_UserId() { }

	[CompilerGenerated]
	public override string get_Username() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_Persistence(bool value) { }

	[CompilerGenerated]
	public void set_SessionId(string value) { }

	[CompilerGenerated]
	public void set_Status(string value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

	[CompilerGenerated]
	public void set_Username(string value) { }

	public virtual string ToString() { }

}

