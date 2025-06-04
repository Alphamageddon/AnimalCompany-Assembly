namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public class XRDistanceEvaluator : XRTargetEvaluator
{
	[SerializeField]
	[Tooltip("The maximum distance from the Interactor. Any target from this distance will receive a 0 normalized score.")]
	private float m_MaxDistance; //Field offset: 0x2C

	public float maxDistance
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRDistanceEvaluator() { }

	protected virtual float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target) { }

	public float get_maxDistance() { }

	public virtual void Reset() { }

	public void set_maxDistance(float value) { }

}

