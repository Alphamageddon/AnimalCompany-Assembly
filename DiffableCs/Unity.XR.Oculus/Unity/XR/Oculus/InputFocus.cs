namespace Unity.XR.Oculus;

public class InputFocus
{
	[CompilerGenerated]
	private static Action InputFocusAcquired; //Field offset: 0x0
	[CompilerGenerated]
	private static Action InputFocusLost; //Field offset: 0x8
	private static bool hadInputFocus; //Field offset: 0x10

	public static event Action InputFocusAcquired
	{
		[CompilerGenerated]
		 add { } //Length: 184
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public static event Action InputFocusLost
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	internal static bool hasInputFocus
	{
		internal get { } //Length: 4
	}

	public InputFocus() { }

	[CompilerGenerated]
	public static void add_InputFocusAcquired(Action value) { }

	[CompilerGenerated]
	public static void add_InputFocusLost(Action value) { }

	internal static bool get_hasInputFocus() { }

	[CompilerGenerated]
	public static void remove_InputFocusAcquired(Action value) { }

	[CompilerGenerated]
	public static void remove_InputFocusLost(Action value) { }

	internal static void Update() { }

}

