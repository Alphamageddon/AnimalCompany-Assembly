namespace UnityEngine.XR.Interaction.Toolkit;

[AddComponentMenu("XR/XR Gaze Interactor", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.XRGazeInteractor.html")]
public class XRGazeInteractor : XRRayInteractor
{
	internal enum GazeAssistanceCalculation
	{
		FixedSize = 0,
		ColliderSize = 1,
	}

	[SerializeField]
	private GazeAssistanceCalculation m_GazeAssistanceCalculation; //Field offset: 0x484
	[SerializeField]
	private float m_GazeAssistanceColliderFixedSize; //Field offset: 0x488
	[SerializeField]
	private float m_GazeAssistanceColliderScale; //Field offset: 0x48C
	[SerializeField]
	private XRInteractableSnapVolume m_GazeAssistanceSnapVolume; //Field offset: 0x490
	[SerializeField]
	private bool m_GazeAssistanceDistanceScaling; //Field offset: 0x498
	[SerializeField]
	private bool m_ClampGazeAssistanceDistanceScaling; //Field offset: 0x499
	[SerializeField]
	private float m_GazeAssistanceDistanceScalingClampValue; //Field offset: 0x49C

	public bool clampGazeAssistanceDistanceScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public GazeAssistanceCalculation gazeAssistanceCalculation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float gazeAssistanceColliderFixedSize
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public float gazeAssistanceColliderScale
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool gazeAssistanceDistanceScaling
	{
		 get { } //Length: 8
		 set { } //Length: 12
	}

	public float gazeAssistanceDistanceScalingClampValue
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRInteractableSnapVolume gazeAssistanceSnapVolume
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public XRGazeInteractor() { }

	protected virtual void Awake() { }

	private float CalculateSnapColliderSize(Collider interactableCollider) { }

	private bool CanInteract(IXRInteractable interactable) { }

	private void CreateGazeAssistanceSnapVolume() { }

	public bool get_clampGazeAssistanceDistanceScaling() { }

	public GazeAssistanceCalculation get_gazeAssistanceCalculation() { }

	public float get_gazeAssistanceColliderFixedSize() { }

	public float get_gazeAssistanceColliderScale() { }

	public bool get_gazeAssistanceDistanceScaling() { }

	public float get_gazeAssistanceDistanceScalingClampValue() { }

	public XRInteractableSnapVolume get_gazeAssistanceSnapVolume() { }

	protected virtual float GetHoverTimeToSelect(IXRInteractable interactable) { }

	protected virtual float GetTimeToAutoDeselect(IXRInteractable interactable) { }

	public virtual void PreprocessInteractor(UpdatePhase updatePhase) { }

	public void set_clampGazeAssistanceDistanceScaling(bool value) { }

	public void set_gazeAssistanceCalculation(GazeAssistanceCalculation value) { }

	public void set_gazeAssistanceColliderFixedSize(float value) { }

	public void set_gazeAssistanceColliderScale(float value) { }

	public void set_gazeAssistanceDistanceScaling(bool value) { }

	public void set_gazeAssistanceDistanceScalingClampValue(float value) { }

	public void set_gazeAssistanceSnapVolume(XRInteractableSnapVolume value) { }

	protected override void UpdateSnapVolumeInteractable(IXRInteractable interactable) { }

}

