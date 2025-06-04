namespace UnityEngine.InputSystem.Android.LowLevel;

internal struct AndroidDeviceCapabilities
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AndroidAxis, String> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__8_0(AndroidAxis i) { }

	}

	public string deviceDescriptor; //Field offset: 0x0
	public int productId; //Field offset: 0x8
	public int vendorId; //Field offset: 0xC
	public bool isVirtual; //Field offset: 0x10
	public AndroidAxis[] motionAxes; //Field offset: 0x18
	public AndroidInputSource inputSources; //Field offset: 0x20

	public static AndroidDeviceCapabilities FromJson(string json) { }

	public string ToJson() { }

	public virtual string ToString() { }

}

