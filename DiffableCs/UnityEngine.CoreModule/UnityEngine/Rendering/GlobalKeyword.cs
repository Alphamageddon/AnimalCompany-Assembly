namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
public struct GlobalKeyword
{
	internal readonly string m_Name; //Field offset: 0x0
	internal readonly uint m_Index; //Field offset: 0x8

	public GlobalKeyword(string name) { }

	public static GlobalKeyword Create(string name) { }

	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	private static void CreateGlobalKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	private static uint GetGlobalKeywordCount() { }

	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	private static uint GetGlobalKeywordIndex(string keyword) { }

	public virtual string ToString() { }

}

