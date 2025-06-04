namespace Unity.XR.CoreUtils;

public abstract class ScriptableSettings : ScriptableSettingsBase<T>
{
	private const string k_CustomSavePathFormat = "{0}Resources/{1}.asset"; //Field offset: 0x0
	private const string k_SavePathFormat = "{0}Resources/ScriptableSettings/{1}.asset"; //Field offset: 0x0
	private const string k_LoadPathFormat = "ScriptableSettings/{0}"; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 316
	}

	protected ScriptableSettings`1() { }

	internal static T CreateAndLoad() { }

	public static T get_Instance() { }

}

