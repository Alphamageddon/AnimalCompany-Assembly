namespace AnimalCompany;

public class TriggerDetector : MonoBehaviour
{
	public Action<Collider> onTriggerEnter; //Field offset: 0x20
	public Action<Collider> onTriggerStay; //Field offset: 0x28

	public TriggerDetector() { }

	private void OnTriggerEnter(Collider collider) { }

	private void OnTriggerStay(Collider collider) { }

}

