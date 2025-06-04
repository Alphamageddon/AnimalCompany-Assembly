namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

internal class XRPokeLogic : IDisposable
{
	private const float k_DepthPercentActivationThreshold = 0.025; //Field offset: 0x0
	private const float k_SquareVelocityHoverThreshold = 0.0001; //Field offset: 0x0
	[CompilerGenerated]
	private float <interactionAxisLength>k__BackingField; //Field offset: 0x10
	private readonly BindableVariable<PokeStateData> m_PokeStateData; //Field offset: 0x18
	private Transform m_InitialTransform; //Field offset: 0x20
	private PokeThresholdData m_PokeThresholdData; //Field offset: 0x28
	private float m_SelectEntranceVectorDotThreshold; //Field offset: 0x30
	private readonly Dictionary<Object, Vector3> m_LastHoverEnterLocalPosition; //Field offset: 0x38
	private readonly Dictionary<Object, Transform> m_LastHoveredTransform; //Field offset: 0x40
	private readonly Dictionary<Object, Boolean> m_HoldingHoverCheck; //Field offset: 0x48
	private readonly Dictionary<Transform, HashSetList`1<Object>> m_HoveredInteractorsOnThisTransform; //Field offset: 0x50
	private readonly Dictionary<Object, Single> m_LastInteractorPressDepth; //Field offset: 0x58

	private float interactionAxisLength
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public IReadOnlyBindableVariable<PokeStateData> pokeStateData
	{
		 get { } //Length: 8
	}

	public XRPokeLogic() { }

	private static Bounds BoundsLocalToWorld(Bounds targetBounds, Transform targetTransform, bool rotateBoundsScale = false) { }

	private static Bounds ComputeBounds(Collider targetCollider, bool rotateBoundsScale = false, Space targetSpace = 0) { }

	private float ComputeInteractionAxisLength(Bounds bounds) { }

	private Vector3 ComputeRotatedDepthEvaluationAxis(Transform associatedTransform, bool isWorldSpace = true) { }

	public override void Dispose() { }

	public void DrawGizmos() { }

	[CompilerGenerated]
	private float get_interactionAxisLength() { }

	public IReadOnlyBindableVariable<PokeStateData> get_pokeStateData() { }

	public void Initialize(Transform associatedTransform, PokeThresholdData pokeThresholdData, Collider collider) { }

	public bool MeetsRequirementsForSelectAction(object interactor, Vector3 pokableAttachPosition, Vector3 pokerAttachPosition, float pokeInteractionOffset, Transform pokedTransform) { }

	public void OnHoverEntered(object interactor, Pose updatedPose, Transform pokedTransform) { }

	public void OnHoverExited(object interactor) { }

	private void ResetPokeStateData(Transform transform) { }

	[CompilerGenerated]
	private void set_interactionAxisLength(float value) { }

	public void SetPokeDepth(float pokeDepth) { }

}

