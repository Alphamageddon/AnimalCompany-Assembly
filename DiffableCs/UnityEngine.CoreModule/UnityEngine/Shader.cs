namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
public sealed class Shader : object
{

	public static string globalRenderPipeline
	{
		 set { } //Length: 60
	}

	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		 get { } //Length: 60
	}

	public LocalKeywordSpace keywordSpace
	{
		 get { } //Length: 76
	}

	public int passCount
	{
		[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
		 get { } //Length: 60
	}

	private Shader() { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	public static void DisableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	public static void EnableKeyword(string keyword) { }

	public static Shader Find(string name) { }

	[NativeMethod("IsSupported")]
	public bool get_isSupported() { }

	public LocalKeywordSpace get_keywordSpace() { }

	private void get_keywordSpace_Injected(out LocalKeywordSpace ret) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	public int get_passCount() { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	public static int PropertyToID(string name) { }

	public static void set_globalRenderPipeline(string value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	public static void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::SetKeyword")]
	internal static void SetKeywordFast(GlobalKeyword keyword, bool value) { }

	private static void SetKeywordFast_Injected(ref GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name) { }

}

