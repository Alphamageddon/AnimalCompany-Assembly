namespace Fusion;

public static class RuntimeUnityFlagsSetup
{
	private static RuntimeFlagsBuildFlags flagsBuildFlags; //Field offset: 0x0
	private static RuntimeFlagsBuildTypes flagsBuildTypes; //Field offset: 0x4
	private static RuntimeFlagsDotNetVersion flagsDotNetVersion; //Field offset: 0x8

	internal static bool IsENABLE_IL2CPP
	{
		internal get { } //Length: 76
	}

	internal static bool IsENABLE_MONO
	{
		internal get { } //Length: 76
	}

	internal static bool IsNET_4_6
	{
		internal get { } //Length: 76
	}

	internal static bool IsNET_STANDARD_2_0
	{
		internal get { } //Length: 76
	}

	internal static bool IsNETFX_CORE
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_2019_4_OR_NEWER
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_EDITOR
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_GAMECORE
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_SWITCH
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_WEBGL
	{
		internal get { } //Length: 76
	}

	internal static bool IsUNITY_XBOXONE
	{
		internal get { } //Length: 76
	}

	[Conditional("ENABLE_IL2CPP")]
	public static void Check_ENABLE_IL2CPP() { }

	[Conditional("ENABLE_MONO")]
	public static void Check_ENABLE_MONO() { }

	[Conditional("NET_4_6")]
	public static void Check_NET_4_6() { }

	[Conditional("NET_STANDARD_2_0")]
	public static void Check_NET_STANDARD_2_0() { }

	[Conditional("NETFX_CORE")]
	public static void Check_NETFX_CORE() { }

	[Conditional("UNITY_2019_4_OR_NEWER")]
	public static void Check_UNITY_2019_4_OR_NEWER() { }

	[Conditional("UNITY_EDITOR")]
	public static void Check_UNITY_EDITOR() { }

	[Conditional("UNITY_GAMECORE")]
	public static void Check_UNITY_GAMECORE() { }

	[Conditional("UNITY_SWITCH")]
	public static void Check_UNITY_SWITCH() { }

	[Conditional("UNITY_WEBGL")]
	public static void Check_UNITY_WEBGL() { }

	[Conditional("UNITY_XBOXONE")]
	public static void Check_UNITY_XBOXONE() { }

	internal static bool get_IsENABLE_IL2CPP() { }

	internal static bool get_IsENABLE_MONO() { }

	internal static bool get_IsNET_4_6() { }

	internal static bool get_IsNET_STANDARD_2_0() { }

	internal static bool get_IsNETFX_CORE() { }

	internal static bool get_IsUNITY_2019_4_OR_NEWER() { }

	internal static bool get_IsUNITY_EDITOR() { }

	internal static bool get_IsUNITY_GAMECORE() { }

	internal static bool get_IsUNITY_SWITCH() { }

	internal static bool get_IsUNITY_WEBGL() { }

	internal static bool get_IsUNITY_XBOXONE() { }

	public static void Reset() { }

}

