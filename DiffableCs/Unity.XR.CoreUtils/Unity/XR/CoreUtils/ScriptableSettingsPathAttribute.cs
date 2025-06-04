namespace Unity.XR.CoreUtils;

[AttributeUsage(AttributeTargets::Class (4))]
public class ScriptableSettingsPathAttribute : Attribute
{
	private readonly string m_Path; //Field offset: 0x10

	public string Path
	{
		 get { } //Length: 8
	}

	public ScriptableSettingsPathAttribute(string path = "") { }

	public string get_Path() { }

}

