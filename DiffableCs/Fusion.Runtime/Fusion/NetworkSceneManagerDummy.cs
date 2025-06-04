namespace Fusion;

internal sealed class NetworkSceneManagerDummy : INetworkSceneManager
{

	public override bool IsBusy
	{
		 get { } //Length: 8
	}

	public override Scene MainRunnerScene
	{
		 get { } //Length: 88
	}

	public NetworkSceneManagerDummy() { }

	public override bool get_IsBusy() { }

	public override Scene get_MainRunnerScene() { }

	public override SceneRef GetSceneRef(string sceneNameOrPath) { }

	public override SceneRef GetSceneRef(GameObject gameObject) { }

	public override void Initialize(NetworkRunner runner) { }

	public override bool IsRunnerScene(Scene scene) { }

	public override NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters) { }

	public override void MakeDontDestroyOnLoad(GameObject obj) { }

	public override bool MoveGameObjectToScene(GameObject gameObject, SceneRef sceneRef) { }

	public void MoveToRunnerScene(GameObject obj) { }

	public override bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource) { }

	public void OnSceneInfoChanged() { }

	public override void Shutdown() { }

	public override bool TryGetPhysicsScene2D(out PhysicsScene2D scene2D) { }

	public override bool TryGetPhysicsScene3D(out PhysicsScene scene3D) { }

	public override NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef) { }

}

