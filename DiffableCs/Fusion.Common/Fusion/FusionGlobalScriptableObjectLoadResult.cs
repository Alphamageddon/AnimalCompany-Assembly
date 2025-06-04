namespace Fusion;

[IsReadOnly]
public struct FusionGlobalScriptableObjectLoadResult
{
	public readonly FusionGlobalScriptableObject Object; //Field offset: 0x0
	public readonly FusionGlobalScriptableObjectUnloadDelegate Unloader; //Field offset: 0x8

	public FusionGlobalScriptableObjectLoadResult(FusionGlobalScriptableObject obj, FusionGlobalScriptableObjectUnloadDelegate unloader = null) { }

	public static FusionGlobalScriptableObjectLoadResult op_Implicit(FusionGlobalScriptableObject result) { }

}

