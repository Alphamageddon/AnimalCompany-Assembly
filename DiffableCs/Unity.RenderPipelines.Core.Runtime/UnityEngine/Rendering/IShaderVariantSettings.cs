namespace UnityEngine.Rendering;

public interface IShaderVariantSettings
{

	public bool exportShaderVariants
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_exportShaderVariants() { }

	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	public void set_exportShaderVariants(bool value) { }

	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

}

