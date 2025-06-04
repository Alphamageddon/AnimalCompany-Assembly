namespace UnityEngine.XR.Interaction.Toolkit.Transformers;

[AddComponentMenu("XR/Transformers/XR Dual Grab Free Transformer", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.5/api/UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer.html")]
public class XRDualGrabFreeTransformer : XRBaseGrabTransformer
{
	internal enum PoseContributor
	{
		First = 0,
		Second = 1,
		Average = 2,
	}

	[SerializeField]
	private PoseContributor m_MultiSelectPosition; //Field offset: 0x20
	[SerializeField]
	private PoseContributor m_MultiSelectRotation; //Field offset: 0x24
	[CompilerGenerated]
	private Pose <lastInteractorAttachPose>k__BackingField; //Field offset: 0x28
	private Vector3 m_LastUp; //Field offset: 0x44

	internal Pose lastInteractorAttachPose
	{
		[CompilerGenerated]
		internal get { } //Length: 20
		[CompilerGenerated]
		private set { } //Length: 28
	}

	public PoseContributor multiSelectPosition
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public PoseContributor multiSelectRotation
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	protected virtual RegistrationMode registrationMode
	{
		 get { } //Length: 8
	}

	public XRDualGrabFreeTransformer() { }

	[CompilerGenerated]
	internal Pose get_lastInteractorAttachPose() { }

	public PoseContributor get_multiSelectPosition() { }

	public PoseContributor get_multiSelectRotation() { }

	protected virtual RegistrationMode get_registrationMode() { }

	protected override void OnDrawGizmosSelected() { }

	public virtual void OnGrabCountChanged(XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale) { }

	public virtual void Process(XRGrabInteractable grabInteractable, UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale) { }

	[CompilerGenerated]
	private void set_lastInteractorAttachPose(Pose value) { }

	public void set_multiSelectPosition(PoseContributor value) { }

	public void set_multiSelectRotation(PoseContributor value) { }

	private void UpdateTarget(XRGrabInteractable grabInteractable, ref Pose targetPose) { }

	private void UpdateTargetMulti(XRGrabInteractable grabInteractable, ref Pose targetPose) { }

}

