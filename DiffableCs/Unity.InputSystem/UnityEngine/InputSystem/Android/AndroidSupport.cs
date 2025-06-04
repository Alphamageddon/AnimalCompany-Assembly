namespace UnityEngine.InputSystem.Android;

internal class AndroidSupport
{
	internal const string kAndroidInterface = "Android"; //Field offset: 0x0

	public AndroidSupport() { }

	public static void Initialize() { }

	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

}

