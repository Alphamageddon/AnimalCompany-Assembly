namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

[AddComponentMenu("XR/XR Target Filter", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Filtering.XRTargetFilter.html")]
public sealed class XRTargetFilter : XRBaseTargetFilter, IEnumerable<XRTargetEvaluator>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal List<XRTargetEvaluator> <.cctor>b__49_0() { }

		internal void <.cctor>b__49_1(List<XRTargetEvaluator> list) { }

	}

	private static readonly LinkedPool<List`1<XRTargetEvaluator>> s_EvaluatorListPool; //Field offset: 0x0
	private static readonly Dictionary<IXRInteractable, Single> s_InteractableFinalScoreMap; //Field offset: 0x8
	private static readonly Comparison<IXRInteractable> s_InteractableScoreComparison; //Field offset: 0x10
	private List<IXRInteractor> m_LinkedInteractors; //Field offset: 0x20
	[SerializeReference]
	private List<XRTargetEvaluator> m_Evaluators; //Field offset: 0x28
	private bool m_IsAwake; //Field offset: 0x30
	[CompilerGenerated]
	private bool <isProcessing>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private Action<IXRInteractor> interactorLinked; //Field offset: 0x38
	[CompilerGenerated]
	private Action<IXRInteractor> interactorUnlinked; //Field offset: 0x40

	public event Action<IXRInteractor> interactorLinked
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public event Action<IXRInteractor> interactorUnlinked
	{
		[CompilerGenerated]
		 add { } //Length: 176
		[CompilerGenerated]
		 remove { } //Length: 176
	}

	public virtual bool canProcess
	{
		 get { } //Length: 24
	}

	public int evaluatorCount
	{
		 get { } //Length: 72
	}

	internal List<XRTargetEvaluator> evaluators
	{
		internal get { } //Length: 8
	}

	internal bool isProcessing
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 12
	}

	internal List<IXRInteractor> linkedInteractors
	{
		internal get { } //Length: 8
	}

	private static XRTargetFilter() { }

	public XRTargetFilter() { }

	[CompilerGenerated]
	public void add_interactorLinked(Action<IXRInteractor> value) { }

	[CompilerGenerated]
	public void add_interactorUnlinked(Action<IXRInteractor> value) { }

	public T AddEvaluator() { }

	public XRTargetEvaluator AddEvaluator(Type evaluatorType) { }

	private void Awake() { }

	public virtual bool get_canProcess() { }

	public int get_evaluatorCount() { }

	internal List<XRTargetEvaluator> get_evaluators() { }

	[CompilerGenerated]
	internal bool get_isProcessing() { }

	internal List<IXRInteractor> get_linkedInteractors() { }

	public void GetEnabledEvaluators(List<XRTargetEvaluator> results) { }

	public override IEnumerator<XRTargetEvaluator> GetEnumerator() { }

	public XRTargetEvaluator GetEvaluator(Type type) { }

	public T GetEvaluator() { }

	public XRTargetEvaluator GetEvaluatorAt(int index) { }

	public void GetEvaluators(List<XRTargetEvaluator> results) { }

	public void GetLinkedInteractors(List<IXRInteractor> results) { }

	private static int InteractableScoreDescendingComparison(IXRInteractable x, IXRInteractable y) { }

	public virtual void Link(IXRInteractor interactor) { }

	public void MoveEvaluatorTo(XRTargetEvaluator evaluator, int newIndex) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void Process(IXRInteractor interactor, List<IXRInteractable> targets, List<IXRInteractable> results) { }

	internal void RegisterEvaluatorHandlers(XRTargetEvaluator evaluator) { }

	[CompilerGenerated]
	public void remove_interactorLinked(Action<IXRInteractor> value) { }

	[CompilerGenerated]
	public void remove_interactorUnlinked(Action<IXRInteractor> value) { }

	public void RemoveEvaluator(XRTargetEvaluator evaluator) { }

	public void RemoveEvaluatorAt(int index) { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_isProcessing(bool value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual void Unlink(IXRInteractor interactor) { }

	internal void UnregisterEvaluatorHandlers(XRTargetEvaluator evaluator) { }

}

