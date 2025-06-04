namespace Fusion;

public interface INetworkSceneManager
{

	public bool IsBusy
	{
		 get { } //Length: 0
	}

	public Scene MainRunnerScene
	{
		 get { } //Length: 0
	}

	public bool get_IsBusy() { }

	public Scene get_MainRunnerScene() { }

	public SceneRef GetSceneRef(GameObject gameObject) { }

	public SceneRef GetSceneRef(string sceneNameOrPath) { }

	public void Initialize(NetworkRunner runner) { }

	public bool IsRunnerScene(Scene scene) { }

	public NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters) { }

	public void MakeDontDestroyOnLoad(GameObject obj) { }

	public bool MoveGameObjectToScene(GameObject gameObject, SceneRef sceneRef) { }

	public bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource) { }

	public void Shutdown() { }

	public bool TryGetPhysicsScene2D(out PhysicsScene2D scene2D) { }

	public bool TryGetPhysicsScene3D(out PhysicsScene scene3D) { }

	public NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef) { }

}

