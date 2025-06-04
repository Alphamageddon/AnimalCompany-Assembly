namespace Photon.Voice.Unity.UtilityScripts;

public class MicrophonePermission : VoiceComponent
{
	[CompilerGenerated]
	private static Action<Boolean> MicrophonePermissionCallback; //Field offset: 0x0
	private bool isRequesting; //Field offset: 0x28
	private bool hasPermission; //Field offset: 0x29
	[SerializeField]
	private bool autoStart; //Field offset: 0x2A

	public static event Action<Boolean> MicrophonePermissionCallback
	{
		[CompilerGenerated]
		 add { } //Length: 204
		[CompilerGenerated]
		 remove { } //Length: 204
	}

	public private bool HasPermission
	{
		 get { } //Length: 8
		private set { } //Length: 1072
	}

	public MicrophonePermission() { }

	[CompilerGenerated]
	public static void add_MicrophonePermissionCallback(Action<Boolean> value) { }

	protected virtual void Awake() { }

	public bool get_HasPermission() { }

	public void InitVoice() { }

	internal void PermissionCallbacks_PermissionDenied(string permissionName) { }

	internal void PermissionCallbacks_PermissionDeniedAndDontAskAgain(string permissionName) { }

	internal void PermissionCallbacks_PermissionGranted(string permissionName) { }

	[CompilerGenerated]
	public static void remove_MicrophonePermissionCallback(Action<Boolean> value) { }

	private void set_HasPermission(bool value) { }

}

