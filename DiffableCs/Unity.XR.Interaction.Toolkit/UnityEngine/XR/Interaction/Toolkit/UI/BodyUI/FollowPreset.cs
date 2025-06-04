namespace UnityEngine.XR.Interaction.Toolkit.UI.BodyUI;

public class FollowPreset
{
	[Header("Local Space Anchor Transform")]
	[Tooltip("Local space anchor position for the right hand.")]
	public Vector3 rightHandLocalPosition; //Field offset: 0x10
	[Tooltip("Local space anchor position for the left hand.")]
	public Vector3 leftHandLocalPosition; //Field offset: 0x1C
	[Tooltip("Local space anchor rotation for the right hand.")]
	public Vector3 rightHandLocalRotation; //Field offset: 0x28
	[Tooltip("Local space anchor rotation for the left hand.")]
	public Vector3 leftHandLocalRotation; //Field offset: 0x34
	[Header("Hand anchor angle constraints")]
	[Tooltip("Reference axis equivalent used for comparisons with the user's gaze direction and the world up direction.")]
	public FollowReferenceAxis palmReferenceAxis; //Field offset: 0x40
	[Tooltip("Given that the default reference hand for menus is the left hand, it may be required to mirror the reference axis for the right hand.")]
	public bool invertAxisForRightHand; //Field offset: 0x44
	[Tooltip("Whether or not check if the palm reference axis is facing the user.")]
	public bool requirePalmFacingUser; //Field offset: 0x45
	[Tooltip("The angle threshold in degrees to check if the palm reference axis is facing the user.")]
	public float palmFacingUserDegreeAngleThreshold; //Field offset: 0x48
	private float m_PalmFacingUserDotThreshold; //Field offset: 0x4C
	[Tooltip("Whether or not check if the palm reference axis is facing up.")]
	public bool requirePalmFacingUp; //Field offset: 0x50
	[Tooltip("The angle threshold in degrees to check if the palm reference axis is facing up.")]
	public float palmFacingUpDegreeAngleThreshold; //Field offset: 0x54
	private float m_PalmFacingUpDotThreshold; //Field offset: 0x58
	[Header("Snap To gaze config")]
	[Tooltip("Whether to snap the following element to the gaze direction.")]
	public bool snapToGaze; //Field offset: 0x5C
	[Tooltip("The angle threshold in degrees to snap the following element to the gaze direction.")]
	public float snapToGazeAngleThreshold; //Field offset: 0x60
	private float m_SnapToGazeDotThreshold; //Field offset: 0x64
	[Header("Hide delay config")]
	[Tooltip("The amount of time in seconds to wait before hiding the following element after the hand is no longer tracked.")]
	public float hideDelaySeconds; //Field offset: 0x68
	[Header("Smoothing Config")]
	[Tooltip("Whether to allow smoothing of the following element position and rotation.")]
	public bool allowSmoothing; //Field offset: 0x6C
	[Tooltip("The lower bound of smoothing to apply.")]
	public float followLowerSmoothingValue; //Field offset: 0x70
	[Tooltip("The upper bound of smoothing to apply.")]
	public float followUpperSmoothingValue; //Field offset: 0x74

	public float palmFacingUpDotThreshold
	{
		 get { } //Length: 8
	}

	public float palmFacingUserDotThreshold
	{
		 get { } //Length: 8
	}

	public float snapToGazeDotThreshold
	{
		 get { } //Length: 8
	}

	public FollowPreset() { }

	private static float AngleToDot(float angleDeg) { }

	public void ApplyPreset(Transform leftTrackingOffset, Transform rightTrackingOffset) { }

	public void ComputeDotProductThresholds() { }

	public float get_palmFacingUpDotThreshold() { }

	public float get_palmFacingUserDotThreshold() { }

	public float get_snapToGazeDotThreshold() { }

	private Vector3 GetLocalAxis(bool isRightHand) { }

	public Vector3 GetReferenceAxisForTrackingAnchor(Transform trackingRoot, bool isRightHand) { }

}

