namespace AnimalCompany;

public class SinWobbler : MonoBehaviour
{
	public Vector3 moveAmplitude; //Field offset: 0x20
	public Vector3 moveFrequency; //Field offset: 0x2C
	public Vector3 rotateAmplitude; //Field offset: 0x38
	public Vector3 rotateFrequency; //Field offset: 0x44
	private Vector3 _initialPosition; //Field offset: 0x50
	private Quaternion _initialRotation; //Field offset: 0x5C

	public SinWobbler() { }

	private void Start() { }

	private void Update() { }

}

