namespace AnimalCompany;

public class GorillaQWOPController : MonoBehaviour
{
	[SerializeField]
	private Transform _headTransform; //Field offset: 0x20
	[SerializeField]
	private Transform _rightHandTransform; //Field offset: 0x28
	[SerializeField]
	private Transform _leftHandTransform; //Field offset: 0x30
	[SerializeField]
	private float _lerpSpeed; //Field offset: 0x38
	private Vector3 _targetLeftHandPosition; //Field offset: 0x3C
	private Vector3 _targetRightHandPosition; //Field offset: 0x48

	public GorillaQWOPController() { }

	private void Update() { }

}

