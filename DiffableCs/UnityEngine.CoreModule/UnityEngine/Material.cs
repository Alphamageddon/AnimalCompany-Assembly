namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : object
{

	public Color color
	{
		 get { } //Length: 140
		 set { } //Length: 212
	}

	public LocalKeyword[] enabledKeywords
	{
		 set { } //Length: 68
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Texture mainTexture
	{
		 get { } //Length: 176
		 set { } //Length: 200
	}

	public int passCount
	{
		[NativeName("GetShader()->GetPassCount")]
		 get { } //Length: 60
	}

	internal int rawRenderQueue
	{
		[NativeName("GetCustomRenderQueue")]
		internal get { } //Length: 60
	}

	public int renderQueue
	{
		[NativeName("SetCustomRenderQueue")]
		 set { } //Length: 68
	}

	public Shader shader
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public String[] shaderKeywords
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Material(Shader shader) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	public int ComputeCRC() { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	public int FindPass(string passName) { }

	public Color get_color() { }

	public bool get_enableInstancing() { }

	public Texture get_mainTexture() { }

	[NativeName("GetShader()->GetPassCount")]
	public int get_passCount() { }

	[NativeName("GetCustomRenderQueue")]
	internal int get_rawRenderQueue() { }

	public Shader get_shader() { }

	public String[] get_shaderKeywords() { }

	public Color GetColor(string name) { }

	public Color GetColor(int nameID) { }

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	internal static Material GetDefaultMaterial() { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(string name) { }

	public float GetFloat(int nameID) { }

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	public int GetInt(string name) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private String[] GetShaderKeywords() { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public Texture GetTexture(string name) { }

	public Texture GetTexture(int nameID) { }

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	public Vector4 GetVector(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	public bool IsKeywordEnabled(string keyword) { }

	public void set_color(Color value) { }

	public void set_enabledKeywords(LocalKeyword[] value) { }

	public void set_enableInstancing(bool value) { }

	public void set_mainTexture(Texture value) { }

	[NativeName("SetCustomRenderQueue")]
	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void set_shaderKeywords(String[] value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetColor(string name, Color value) { }

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloatArray(int nameID, Single[] values) { }

	private void SetFloatArray(int name, Single[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	public void SetInt(string name, int value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInteger(int nameID, int value) { }

	[NativeName("SetIntFromScript")]
	private void SetIntImpl(int name, int value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public void SetOverrideTag(string tag, string val) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

}

