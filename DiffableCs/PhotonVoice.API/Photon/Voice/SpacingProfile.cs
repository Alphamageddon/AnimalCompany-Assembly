namespace Photon.Voice;

internal class SpacingProfile
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int16, Int16> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal short <get_Max>b__13_0(short v) { }

	}

	private Int16[] buf; //Field offset: 0x10
	private Boolean[] info; //Field offset: 0x18
	private int capacity; //Field offset: 0x20
	private int ptr; //Field offset: 0x24
	private Stopwatch watch; //Field offset: 0x28
	private long watchLast; //Field offset: 0x30
	private bool flushed; //Field offset: 0x38

	public string Dump
	{
		 get { } //Length: 560
	}

	public int Max
	{
		 get { } //Length: 288
	}

	public SpacingProfile(int capacity) { }

	[CompilerGenerated]
	private string <get_Dump>b__11_0(short v, int i) { }

	public string get_Dump() { }

	public int get_Max() { }

	public void Start() { }

	public void Update(bool lost, bool flush) { }

}

