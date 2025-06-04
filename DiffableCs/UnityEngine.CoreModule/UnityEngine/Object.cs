namespace UnityEngine;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public string name
	{
		 get { } //Length: 116
		 set { } //Length: 132
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(object obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(object target) { }

	public virtual bool Equals(object other) { }

	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	public static T FindFirstObjectByType() { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	public static T FindObjectOfType(bool includeInactive) { }

	public static T FindObjectOfType() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsOfType(bool includeInactive) { }

	public static T[] FindObjectsOfType() { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	private static string GetName(object obj) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Scene scene) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Transform parent) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	public static T Instantiate(T original) { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static object Internal_CloneSingle(object data) { }

	[FreeFunction("CloneObject")]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("CloneObjectToScene")]
	private static object Internal_CloneSingleWithScene(object data, Scene scene) { }

	private static object Internal_CloneSingleWithScene_Injected(object data, ref Scene scene) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingle_Injected(object data, ref Vector3 pos, ref Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingleWithParent_Injected(object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

	private static bool IsNativeObjectAlive(object o) { }

	public static bool op_Equality(object x, object y) { }

	public static bool op_Implicit(object exists) { }

	public static bool op_Inequality(object x, object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	private static void SetName(object obj, string name) { }

	public virtual string ToString() { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(object obj) { }

}

