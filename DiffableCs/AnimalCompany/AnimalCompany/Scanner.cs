namespace AnimalCompany;

[NetworkBehaviourWeaved(1)]
public class Scanner : NetworkBehaviour
{
	private const int RENDER_WIDTH = 240; //Field offset: 0x0
	private const int RENDER_HEIGHT = 320; //Field offset: 0x0
	[SerializeField]
	private GrabbableItem _grabbable; //Field offset: 0x80
	[SerializeField]
	private Camera _camera; //Field offset: 0x88
	[SerializeField]
	private Renderer _displayRenderer; //Field offset: 0x90
	[SerializeField]
	private Shader _replacementShader; //Field offset: 0x98
	[SerializeField]
	private Material _processMaterial; //Field offset: 0xA0
	[DefaultForProperty("isOn", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private bool _isOn; //Field offset: 0xA8
	private RenderTexture _texture; //Field offset: 0xB0
	private RenderTexture _viewTexture; //Field offset: 0xB8

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleIsOnChanged")]
	public bool isOn
	{
		 get { } //Length: 104
		 set { } //Length: 100
	}

	public Scanner() { }

	private void Awake() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public bool get_isOn() { }

	private void HandleIsOnChanged() { }

	private void HandleToggleUse() { }

	private void OnDestroy() { }

	[Rpc(RpcSources::All (7), RpcTargets::StateAuthority (1))]
	public void RPC_ToggleOnOff() { }

	[NetworkRpcWeavedInvoker(1, 7, 1)]
	[Preserve]
	[WeaverGenerated]
	protected static void RPC_ToggleOnOff@Invoker(NetworkBehaviour behaviour, SimulationMessage* message) { }

	public void set_isOn(bool value) { }

	public virtual void Spawned() { }

	private void Update() { }

}

