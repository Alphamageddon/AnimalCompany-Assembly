namespace Fusion;

public class StartGameResult
{
	[CompilerGenerated]
	private ShutdownReason <ShutdownReason>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <StackTrace>k__BackingField; //Field offset: 0x20

	public private string ErrorMessage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool Ok
	{
		 get { } //Length: 16
	}

	public private ShutdownReason ShutdownReason
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string StackTrace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal StartGameResult(ShutdownReason reason = 0, string message = null, string stackTrace = null) { }

	internal static StartGameResult BuildGameResultFromException(Exception e) { }

	[CompilerGenerated]
	public string get_ErrorMessage() { }

	public bool get_Ok() { }

	[CompilerGenerated]
	public ShutdownReason get_ShutdownReason() { }

	[CompilerGenerated]
	public string get_StackTrace() { }

	[CompilerGenerated]
	private void set_ErrorMessage(string value) { }

	[CompilerGenerated]
	private void set_ShutdownReason(ShutdownReason value) { }

	[CompilerGenerated]
	private void set_StackTrace(string value) { }

	public virtual string ToString() { }

}

