namespace UnityEngine.Animations.Rigging;

[AddComponentMenu("Animation Rigging/Setup/Rig Builder")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.2/manual/RiggingWorkflow.html#rig-builder-component")]
[RequireComponent(typeof(Animator))]
public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder
{
	internal sealed class OnAddRigBuilderCallback : MulticastDelegate
	{

		public OnAddRigBuilderCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RigBuilder rigBuilder, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RigBuilder rigBuilder) { }

	}

	internal sealed class OnRemoveRigBuilderCallback : MulticastDelegate
	{

		public OnRemoveRigBuilderCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RigBuilder rigBuilder, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RigBuilder rigBuilder) { }

	}

	public static OnAddRigBuilderCallback onAddRigBuilder; //Field offset: 0x0
	public static OnRemoveRigBuilderCallback onRemoveRigBuilder; //Field offset: 0x8
	[SerializeField]
	private List<RigLayer> m_RigLayers; //Field offset: 0x20
	private IRigLayer[] m_RuntimeRigLayers; //Field offset: 0x28
	private SyncSceneToStreamLayer m_SyncSceneToStreamLayer; //Field offset: 0x30
	[SerializeField]
	private List<RigEffectorData> m_Effectors; //Field offset: 0x38
	private bool m_IsInPreview; //Field offset: 0x40
	[CompilerGenerated]
	private PlayableGraph <graph>k__BackingField; //Field offset: 0x48

	public private PlayableGraph graph
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public List<RigLayer> layers
	{
		 get { } //Length: 120
		 set { } //Length: 8
	}

	private SyncSceneToStreamLayer syncSceneToStreamLayer
	{
		private get { } //Length: 100
		private set { } //Length: 8
	}

	public RigBuilder() { }

	public bool Build() { }

	public bool Build(PlayableGraph graph) { }

	public override Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable) { }

	public void Clear() { }

	public void Evaluate(float deltaTime) { }

	[CompilerGenerated]
	public PlayableGraph get_graph() { }

	public List<RigLayer> get_layers() { }

	private SyncSceneToStreamLayer get_syncSceneToStreamLayer() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_graph(PlayableGraph value) { }

	public void set_layers(List<RigLayer> value) { }

	private void set_syncSceneToStreamLayer(SyncSceneToStreamLayer value) { }

	public override void StartPreview() { }

	public override void StopPreview() { }

	public void SyncLayers() { }

	private void Update() { }

	public override void UpdatePreviewGraph(PlayableGraph graph) { }

}

