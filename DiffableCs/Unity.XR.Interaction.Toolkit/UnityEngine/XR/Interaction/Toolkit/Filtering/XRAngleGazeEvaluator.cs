namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public class XRAngleGazeEvaluator : XRTargetEvaluator
{
	[SerializeField]
	[Tooltip("The Transform whose forward direction is used to evaluate the target Interactable angle. If none is specified, during OnEnable this property is initialized with the XROrigin Camera.")]
	private Transform m_GazeTransform; //Field offset: 0x30
	[Range(0, 180)]
	[SerializeField]
	[Tooltip("The maximum value an angle can be evaluated as before the Interactor receives a normalized score of 0. Think of it as a field-of-view angle.")]
	private float m_MaxAngle; //Field offset: 0x38

	public Transform gazeTransform
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float maxAngle
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public XRAngleGazeEvaluator() { }

	protected virtual float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target) { }

	public Transform get_gazeTransform() { }

	public float get_maxAngle() { }

	private static Camera GetXROriginCamera() { }

	private void InitializeGazeTransform() { }

	protected virtual void OnEnable() { }

	public virtual void Reset() { }

	public void set_gazeTransform(Transform value) { }

	public void set_maxAngle(float value) { }

}

