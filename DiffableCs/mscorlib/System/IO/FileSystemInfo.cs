namespace System.IO;

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private FileStatus _fileStatus; //Field offset: 0x18
	protected string FullPath; //Field offset: 0x90
	protected string OriginalPath; //Field offset: 0x98
	internal string _name; //Field offset: 0xA0

	public override bool Exists
	{
		 get { } //Length: 136
	}

	internal bool ExistsCore
	{
		internal get { } //Length: 152
	}

	public override string FullName
	{
		 get { } //Length: 8
	}

	public override string Name
	{
		 get { } //Length: 8
	}

	internal string NormalizedPath
	{
		internal get { } //Length: 8
	}

	protected FileSystemInfo() { }

	protected FileSystemInfo(SerializationInfo info, StreamingContext context) { }

	public override bool get_Exists() { }

	internal bool get_ExistsCore() { }

	public override string get_FullName() { }

	public override string get_Name() { }

	internal string get_NormalizedPath() { }

	[ComVisible(False)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

