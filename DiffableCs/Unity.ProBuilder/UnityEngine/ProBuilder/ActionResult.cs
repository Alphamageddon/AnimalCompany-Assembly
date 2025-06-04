namespace UnityEngine.ProBuilder;

public sealed class ActionResult
{
	internal enum Status
	{
		Success = 0,
		Failure = 1,
		Canceled = 2,
		NoChange = 3,
	}

	[CompilerGenerated]
	private Status <status>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <notification>k__BackingField; //Field offset: 0x18

	public static ActionResult NoSelection
	{
		 get { } //Length: 120
	}

	public private string notification
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Status status
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public static ActionResult Success
	{
		 get { } //Length: 116
	}

	public static ActionResult UserCanceled
	{
		 get { } //Length: 120
	}

	public ActionResult(Status status, string notification) { }

	public static bool FromBool(bool success) { }

	public static ActionResult get_NoSelection() { }

	[CompilerGenerated]
	public string get_notification() { }

	[CompilerGenerated]
	public Status get_status() { }

	public static ActionResult get_Success() { }

	public static ActionResult get_UserCanceled() { }

	public static bool op_Implicit(ActionResult res) { }

	[CompilerGenerated]
	private void set_notification(string value) { }

	[CompilerGenerated]
	private void set_status(Status value) { }

	public bool ToBool() { }

}

