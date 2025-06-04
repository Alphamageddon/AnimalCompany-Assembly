namespace System.IO;

internal struct FileStatus
{
	private FileStatus _fileStatus; //Field offset: 0x0
	private int _fileStatusInitialized; //Field offset: 0x70
	[CompilerGenerated]
	private bool <InitiallyDirectory>k__BackingField; //Field offset: 0x74
	internal bool _isDirectory; //Field offset: 0x75
	private bool _exists; //Field offset: 0x76

	internal bool InitiallyDirectory
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	internal void EnsureStatInitialized(ReadOnlySpan<Char> path, bool continueOnError = false) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal bool get_InitiallyDirectory() { }

	internal bool GetExists(ReadOnlySpan<Char> path) { }

	internal static void Initialize(ref FileStatus status, bool isDirectory) { }

	internal bool IsReadOnly(ReadOnlySpan<Char> path, bool continueOnError = false) { }

	public void Refresh(ReadOnlySpan<Char> path) { }

	[CompilerGenerated]
	private void set_InitiallyDirectory(bool value) { }

}

