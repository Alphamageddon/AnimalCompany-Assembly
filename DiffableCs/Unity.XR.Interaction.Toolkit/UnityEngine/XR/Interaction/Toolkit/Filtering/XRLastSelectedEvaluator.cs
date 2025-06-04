namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public class XRLastSelectedEvaluator : XRTargetEvaluator, IXRTargetEvaluatorLinkable
{
	private readonly Dictionary<IXRInteractable, Single> m_InteractableSelectionTimeMap; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Any Interactable which was last selected over Max Time seconds ago will receive a normalized score of 0.")]
	private float m_MaxTime; //Field offset: 0x38

	public float maxTime
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRLastSelectedEvaluator() { }

	protected virtual float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target) { }

	public float get_maxTime() { }

	protected virtual void OnDisable() { }

	public override void OnLink(IXRInteractor interactor) { }

	private void OnSelect(SelectEnterEventArgs args) { }

	public override void OnUnlink(IXRInteractor interactor) { }

	public void set_maxTime(float value) { }

}

