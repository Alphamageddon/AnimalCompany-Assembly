namespace Fusion;

[AddComponentMenu(null)]
public sealed class RunnerVisibilityLink : MonoBehaviour
{
	private enum ComponentType
	{
		None = 0,
		Renderer = 1,
		Behaviour = 2,
	}

	internal enum PreferredRunners
	{
		Auto = 0,
		Server = 1,
		Client = 2,
		InputAuthority = 3,
	}

	[SerializeField]
	public PreferredRunners PreferredRunner; //Field offset: 0x20
	public Component Component; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsOnSingleRunner>k__BackingField; //Field offset: 0x30
	[ReadOnly]
	[SerializeField]
	internal string Guid; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	internal bool _showAtRuntime; //Field offset: 0x40
	internal NetworkRunner _runner; //Field offset: 0x48
	private ComponentType _componentType; //Field offset: 0x50
	private NetworkObject _networkObject; //Field offset: 0x58
	private bool _originalState; //Field offset: 0x60

	public bool DefaultState
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	internal bool Enabled
	{
		internal get { } //Length: 220
		internal set { } //Length: 320
	}

	public private bool IsOnSingleRunner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public RunnerVisibilityLink() { }

	private bool AssociateComponent(Component component) { }

	private void Awake() { }

	public bool get_DefaultState() { }

	internal bool get_Enabled() { }

	[CompilerGenerated]
	public bool get_IsOnSingleRunner() { }

	internal void Initialize(Component comp, NetworkRunner runner) { }

	internal void InvokeRefreshCommonObjectVisibilities(float time) { }

	internal bool IsInputAuth() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void Reset() { }

	private void RetryRefreshCommonLinks() { }

	public void set_DefaultState(bool value) { }

	internal void set_Enabled(bool value) { }

	[CompilerGenerated]
	private void set_IsOnSingleRunner(bool value) { }

	public void SetEnabled(bool enabled) { }

	internal void SetupOnSingleRunnerLink(PreferredRunners preferredRunner) { }

}

