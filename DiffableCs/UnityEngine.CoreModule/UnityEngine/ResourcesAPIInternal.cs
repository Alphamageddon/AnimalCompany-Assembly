namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
internal static class ResourcesAPIInternal
{

	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	public static Shader FindShaderByName(string name) { }

	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedBySecondArgument (1))]
	public static object Load(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::LoadAll")]
	[NativeThrows]
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
	internal static ResourceRequest LoadAsyncInternal(string path, Type type) { }

	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	public static void UnloadAsset(object assetToUnload) { }

}

