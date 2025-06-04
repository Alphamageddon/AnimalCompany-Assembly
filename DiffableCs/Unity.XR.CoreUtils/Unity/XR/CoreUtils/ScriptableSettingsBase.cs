namespace Unity.XR.CoreUtils;

public abstract class ScriptableSettingsBase : ScriptableObject
{
	private const string k_AbsolutePathMessage = "Path cannot be absolute"; //Field offset: 0x0
	protected const string PathExceptionMessage = "Exception caught trying to create path."; //Field offset: 0x0
	internal const string NullPathMessage = "Path cannot be null"; //Field offset: 0x0
	internal const string PathWithPeriodMessage = "Path cannot contain the character '.' before or after a directory separator"; //Field offset: 0x0
	internal const string PathWithInvalidCharacterMessage = "Paths on Windows cannot contain the following characters: ':', '*', '?', '"', '<', '>', '|'"; //Field offset: 0x0
	private static readonly Char[] k_PathTrimChars; //Field offset: 0x0
	private static readonly Char[] k_InvalidCharacters; //Field offset: 0x8
	private static readonly String[] k_InvalidStrings; //Field offset: 0x10

	private static ScriptableSettingsBase() { }

	protected ScriptableSettingsBase() { }

	private void Awake() { }

	public static ScriptableSettingsBase GetInstanceByType(Type settingsType) { }

	private void OnEnable() { }

	protected override void OnLoaded() { }

	internal static bool ValidatePath(string path, out string cleanedPath) { }

}

