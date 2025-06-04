namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[HideInInspector]
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	public int buildIndex
	{
		 get { } //Length: 60
	}

	internal string guid
	{
		internal get { } //Length: 60
	}

	public int handle
	{
		 get { } //Length: 8
	}

	public bool isDirty
	{
		 get { } //Length: 60
	}

	public bool isLoaded
	{
		 get { } //Length: 60
	}

	public bool isSubScene
	{
		 get { } //Length: 60
	}

	public string name
	{
		 get { } //Length: 60
	}

	public string path
	{
		 get { } //Length: 60
	}

	public int rootCount
	{
		 get { } //Length: 60
	}

	public virtual bool Equals(object other) { }

	public int get_buildIndex() { }

	internal string get_guid() { }

	public int get_handle() { }

	public bool get_isDirty() { }

	public bool get_isLoaded() { }

	public bool get_isSubScene() { }

	public string get_name() { }

	public string get_path() { }

	public int get_rootCount() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetGUIDInternal(int sceneHandle) { }

	public virtual int GetHashCode() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool GetIsDirtyInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetPathInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static int GetRootCountInternal(int sceneHandle) { }

	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	public GameObject[] GetRootGameObjects() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool IsSubScene(int sceneHandle) { }

	public bool IsValid() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool IsValidInternal(int sceneHandle) { }

	public static bool op_Equality(Scene lhs, Scene rhs) { }

	public static bool op_Inequality(Scene lhs, Scene rhs) { }

}

