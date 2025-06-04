namespace Fusion;

[AddComponentMenu("Fusion/Network Mecanim Animator")]
[DisallowMultipleComponent]
[HelpURL("https://doc.photonengine.com/fusion/current/manual/prebuilt-components#networkmechanimanimator")]
[NetworkBehaviourWeaved(-1)]
public sealed class NetworkMecanimAnimator : NetworkBehaviour, IAfterAllTicks
{
	private const int BITS_PER_BOOL = 4; //Field offset: 0x0
	[InlineHelp]
	public Animator Animator; //Field offset: 0x80
	[InlineHelp]
	[ReadOnly]
	[SerializeField]
	internal int TotalWords; //Field offset: 0x88
	[InlineHelp]
	[SerializeField]
	public RenderSource ApplyTiming; //Field offset: 0x8C
	[ExpandableEnum]
	[InlineHelp]
	[SerializeField]
	internal AnimatorSyncSettings SyncSettings; //Field offset: 0x90
	[InlineHelp]
	[SerializeField]
	internal Int32[] StateHashes; //Field offset: 0x98
	internal Dictionary<Int32, Int32> StateIndexLookup; //Field offset: 0xA0
	[InlineHelp]
	[SerializeField]
	internal Int32[] TriggerHashes; //Field offset: 0xA8
	internal Dictionary<Int32, Int32> TriggerIndexLookup; //Field offset: 0xB0
	private int _param32Count; //Field offset: 0xB8
	private int _paramBoolCount; //Field offset: 0xBC
	private int _paramBoolsWordCount; //Field offset: 0xC0
	private int _paramBoolsPtrOffset; //Field offset: 0xC4
	private int _syncedLayerCount; //Field offset: 0xC8
	private Int32[] _prevBoolsBitmask; //Field offset: 0xD0
	private AnimatorControllerParameter[] _cachedParameters; //Field offset: 0xD8
	private Int32[] _cachedParameterHashes; //Field offset: 0xE0
	private int _cachedParameterCount; //Field offset: 0xE8
	private int _cachedLayerCount; //Field offset: 0xEC
	private readonly HashSet<Int32> _pendingTriggers; //Field offset: 0xF0
	private int _lastAppliedTick; //Field offset: 0xF8

	public virtual Nullable<Int32> DynamicWordCount
	{
		 get { } //Length: 292
	}

	public NetworkMecanimAnimator() { }

	internal void ApplyAnimatorData(NetworkBehaviourBuffer buffer) { }

	private void ApplyLayerWeights(NetworkBehaviourBuffer buffer, ref int wordOffset) { }

	private void ApplyParameters(NetworkBehaviourBuffer buffer, ref int wordOffset) { }

	private void ApplyStates(NetworkBehaviourBuffer buffer, ref int wordOffset) { }

	private void Awake() { }

	internal void CaptureAnimatorData() { }

	private void CaptureLayerWeights(ref int wordOffset) { }

	private void CaptureParameters(ref int wordOffset) { }

	private void CaptureStates(ref int wordOffset) { }

	private override void Fusion.IAfterAllTicks.AfterAllTicks(bool resimulation, int tickCount) { }

	public virtual Nullable<Int32> get_DynamicWordCount() { }

	internal int GetRuntimeCounts() { }

	public virtual void Render() { }

	public void SetTrigger(string trigger, bool passThroughOnInputAuthority = false) { }

	public void SetTrigger(int triggerHash, bool passThroughOnInputAuthority = false) { }

	public virtual void Spawned() { }

}

