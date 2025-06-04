namespace Fusion;

[NetworkStructWeaved(13)]
public struct NetworkSceneInfo : INetworkStruct, IEquatable<NetworkSceneInfo>
{
	public const int WORD_COUNT = 13; //Field offset: 0x0
	public const int SIZE = 52; //Field offset: 0x0
	public const int MaxScenes = 8; //Field offset: 0x0
	private NetworkSceneInfoDefaultFlags _flags; //Field offset: 0x0
	private SceneRef _scene0; //Field offset: 0x4
	private SceneRef _scene1; //Field offset: 0x8
	private SceneRef _scene2; //Field offset: 0xC
	private SceneRef _scene3; //Field offset: 0x10
	private SceneRef _scene4; //Field offset: 0x14
	private SceneRef _scene5; //Field offset: 0x18
	private SceneRef _scene6; //Field offset: 0x1C
	private SceneRef _scene7; //Field offset: 0x20
	private NetworkLoadSceneParameters _sceneMeta0; //Field offset: 0x24
	private NetworkLoadSceneParameters _sceneMeta1; //Field offset: 0x26
	private NetworkLoadSceneParameters _sceneMeta2; //Field offset: 0x28
	private NetworkLoadSceneParameters _sceneMeta3; //Field offset: 0x2A
	private NetworkLoadSceneParameters _sceneMeta4; //Field offset: 0x2C
	private NetworkLoadSceneParameters _sceneMeta5; //Field offset: 0x2E
	private NetworkLoadSceneParameters _sceneMeta6; //Field offset: 0x30
	private NetworkLoadSceneParameters _sceneMeta7; //Field offset: 0x32

	public private int SceneCount
	{
		 get { } //Length: 12
		private set { } //Length: 16
	}

	public FixedArray<NetworkLoadSceneParameters> SceneParams
	{
		 get { } //Length: 80
	}

	public FixedArray<SceneRef> Scenes
	{
		 get { } //Length: 80
	}

	public private int Version
	{
		 get { } //Length: 12
		private set { } //Length: 16
	}

	public int AddSceneRef(SceneRef sceneRef, LoadSceneMode loadSceneMode = 0, LocalPhysicsMode localPhysicsMode = 0, bool activeOnLoad = false) { }

	internal int AddSceneRef(SceneRef sceneRef, NetworkLoadSceneParametersFlags flags) { }

	public override bool Equals(NetworkSceneInfo other) { }

	public virtual bool Equals(object obj) { }

	public int get_SceneCount() { }

	public FixedArray<NetworkLoadSceneParameters> get_SceneParams() { }

	public FixedArray<SceneRef> get_Scenes() { }

	public int get_Version() { }

	public virtual int GetHashCode() { }

	public int IndexOf(SceneRef sceneRef, NetworkLoadSceneParameters sceneParams) { }

	public int IndexOf(ValueTuple<SceneRef, NetworkLoadSceneParameters> scene) { }

	public static NetworkSceneInfo op_Implicit(SceneRef sceneRef) { }

	public bool RemoveSceneRef(SceneRef sceneRef) { }

	private void set_SceneCount(int value) { }

	private void set_Version(int value) { }

	public virtual string ToString() { }

}

