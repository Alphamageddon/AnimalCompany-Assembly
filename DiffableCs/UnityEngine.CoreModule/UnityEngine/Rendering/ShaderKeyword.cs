namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public struct ShaderKeyword
{
	internal string m_Name; //Field offset: 0x0
	internal uint m_Index; //Field offset: 0x8
	internal bool m_IsLocal; //Field offset: 0xC
	internal bool m_IsCompute; //Field offset: 0xD
	internal bool m_IsValid; //Field offset: 0xE

	public string name
	{
		 get { } //Length: 8
	}

	public ShaderKeyword(string keywordName) { }

	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	internal static void CreateGlobalKeyword(string keyword) { }

	public string get_name() { }

	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	internal static uint GetGlobalKeywordCount() { }

	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	internal static uint GetGlobalKeywordIndex(string keyword) { }

	public virtual string ToString() { }

}

