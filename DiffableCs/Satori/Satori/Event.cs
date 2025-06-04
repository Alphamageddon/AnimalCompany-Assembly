namespace Satori;

public class Event
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly DateTime <Timestamp>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Dictionary<String, String> <Metadata>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x30

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Dictionary<String, String> Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public DateTime Timestamp
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Value
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Event(string name, DateTime timestamp, string value = null, Dictionary<String, String> metadata = null, string id = null) { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public Dictionary<String, String> get_Metadata() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public DateTime get_Timestamp() { }

	[CompilerGenerated]
	public string get_Value() { }

	internal ApiEvent ToApiEvent() { }

}

