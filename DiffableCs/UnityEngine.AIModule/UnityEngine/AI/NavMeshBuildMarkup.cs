namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
public struct NavMeshBuildMarkup
{
	private int m_OverrideArea; //Field offset: 0x0
	private int m_Area; //Field offset: 0x4
	private int m_InheritIgnoreFromBuild; //Field offset: 0x8
	private int m_IgnoreFromBuild; //Field offset: 0xC
	private int m_OverrideGenerateLinks; //Field offset: 0x10
	private int m_GenerateLinks; //Field offset: 0x14
	private int m_InstanceID; //Field offset: 0x18
	private int m_IgnoreChildren; //Field offset: 0x1C

	public bool applyToChildren
	{
		 set { } //Length: 16
	}

	public int area
	{
		 set { } //Length: 8
	}

	public bool generateLinks
	{
		 set { } //Length: 12
	}

	public bool ignoreFromBuild
	{
		 set { } //Length: 12
	}

	public bool overrideArea
	{
		 set { } //Length: 12
	}

	public bool overrideGenerateLinks
	{
		 set { } //Length: 12
	}

	public Transform root
	{
		 set { } //Length: 144
	}

	public void set_applyToChildren(bool value) { }

	public void set_area(int value) { }

	public void set_generateLinks(bool value) { }

	public void set_ignoreFromBuild(bool value) { }

	public void set_overrideArea(bool value) { }

	public void set_overrideGenerateLinks(bool value) { }

	public void set_root(Transform value) { }

}

