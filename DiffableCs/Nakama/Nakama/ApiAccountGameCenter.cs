namespace Nakama;

internal class ApiAccountGameCenter : IApiAccountGameCenter
{
	[CompilerGenerated]
	private string <BundleId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <PlayerId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <PublicKeyUrl>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Salt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Signature>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <TimestampSeconds>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Dictionary<String, String> <_vars>k__BackingField; //Field offset: 0x40

	[DataMember(Name = "vars")]
	[Preserve]
	public Dictionary<String, String> _vars
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "bundle_id")]
	[Preserve]
	public override string BundleId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "player_id")]
	[Preserve]
	public override string PlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "public_key_url")]
	[Preserve]
	public override string PublicKeyUrl
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "salt")]
	[Preserve]
	public override string Salt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "signature")]
	[Preserve]
	public override string Signature
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[DataMember(Name = "timestamp_seconds")]
	[Preserve]
	public override string TimestampSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[IgnoreDataMember]
	public override IDictionary<String, String> Vars
	{
		 get { } //Length: 116
	}

	public ApiAccountGameCenter() { }

	[CompilerGenerated]
	public Dictionary<String, String> get__vars() { }

	[CompilerGenerated]
	public override string get_BundleId() { }

	[CompilerGenerated]
	public override string get_PlayerId() { }

	[CompilerGenerated]
	public override string get_PublicKeyUrl() { }

	[CompilerGenerated]
	public override string get_Salt() { }

	[CompilerGenerated]
	public override string get_Signature() { }

	[CompilerGenerated]
	public override string get_TimestampSeconds() { }

	public override IDictionary<String, String> get_Vars() { }

	[CompilerGenerated]
	public void set__vars(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_BundleId(string value) { }

	[CompilerGenerated]
	public void set_PlayerId(string value) { }

	[CompilerGenerated]
	public void set_PublicKeyUrl(string value) { }

	[CompilerGenerated]
	public void set_Salt(string value) { }

	[CompilerGenerated]
	public void set_Signature(string value) { }

	[CompilerGenerated]
	public void set_TimestampSeconds(string value) { }

	public virtual string ToString() { }

}

