namespace Fusion;

[AddComponentMenu("Fusion/Fusion Boostrap Debug GUI")]
[RequireComponent(typeof(FusionBootstrap))]
[ScriptHelp(BackColor = ScriptHeaderBackColor::Steel (7))]
public class FusionBootstrapDebugGUI : Behaviour
{
	[InlineHelp]
	public bool EnableHotkeys; //Field offset: 0x20
	[InlineHelp]
	public GUISkin BaseSkin; //Field offset: 0x28
	private FusionBootstrap _networkDebugStart; //Field offset: 0x30
	private string _clientCount; //Field offset: 0x38
	private bool _isMultiplePeerMode; //Field offset: 0x40
	private Dictionary<Stage, String> _nicifiedStageNames; //Field offset: 0x48

	public FusionBootstrapDebugGUI() { }

	protected override void Awake() { }

	public static Dictionary<T, String> ConvertEnumToNicifiedNameLookup(string prefix = null, Dictionary<T, String> nonalloc = null) { }

	protected FusionBootstrap EnsureNetworkDebugStartExists() { }

	protected int GetClientCount() { }

	protected override void OnGUI() { }

	protected override void OnValidate() { }

	protected override void Start() { }

	private void StartHostWithClients(FusionBootstrap nds) { }

	private void StartMultipleAutoClients(FusionBootstrap nds) { }

	private void StartMultipleClients(FusionBootstrap nds) { }

	private void StartMultipleSharedClients(FusionBootstrap nds) { }

	private void StartServerWithClients(FusionBootstrap nds) { }

	private void Update() { }

	protected void ValidateClientCount() { }

}

