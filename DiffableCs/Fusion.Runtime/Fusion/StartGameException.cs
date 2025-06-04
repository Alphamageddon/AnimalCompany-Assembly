namespace Fusion;

internal class StartGameException : Exception
{
	[CompilerGenerated]
	private ShutdownReason <ShutdownReason>k__BackingField; //Field offset: 0x8C

	public internal ShutdownReason ShutdownReason
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal StartGameException(ShutdownReason shutdownReason = 1, string customMsg = null) { }

	[CompilerGenerated]
	public ShutdownReason get_ShutdownReason() { }

	[CompilerGenerated]
	internal void set_ShutdownReason(ShutdownReason value) { }

	public virtual string ToString() { }

}

