namespace UnityEngine.SceneManagement;

public struct LoadSceneParameters
{
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode; //Field offset: 0x0
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode; //Field offset: 0x4

	public LoadSceneMode loadSceneMode
	{
		 get { } //Length: 8
	}

	public LocalPhysicsMode localPhysicsMode
	{
		 get { } //Length: 8
	}

	public LoadSceneParameters(LoadSceneMode mode) { }

	public LoadSceneParameters(LoadSceneMode mode, LocalPhysicsMode physicsMode) { }

	public LoadSceneMode get_loadSceneMode() { }

	public LocalPhysicsMode get_localPhysicsMode() { }

}

