namespace Fusion;

[IsReadOnly]
public struct SceneLoadDoneArgs
{
	public readonly SceneRef SceneRef; //Field offset: 0x0
	public readonly NetworkObject[] SceneObjects; //Field offset: 0x8
	public readonly Scene Scene; //Field offset: 0x10
	public readonly GameObject[] RootGameObjects; //Field offset: 0x18

	public SceneLoadDoneArgs(SceneRef sceneRef, NetworkObject[] sceneObjects, Scene scene = null, GameObject[] rootGameObjects = null) { }

}

