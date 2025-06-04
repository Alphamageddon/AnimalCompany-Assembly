namespace UnityEngine.XR.Management;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class XRConfigurationDataAttribute : Attribute
{
	[CompilerGenerated]
	private string <displayName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <buildSettingsKey>k__BackingField; //Field offset: 0x18

	public string buildSettingsKey
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string displayName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private XRConfigurationDataAttribute() { }

	public XRConfigurationDataAttribute(string displayName, string buildSettingsKey) { }

	[CompilerGenerated]
	public string get_buildSettingsKey() { }

	[CompilerGenerated]
	public string get_displayName() { }

	[CompilerGenerated]
	public void set_buildSettingsKey(string value) { }

	[CompilerGenerated]
	public void set_displayName(string value) { }

}

