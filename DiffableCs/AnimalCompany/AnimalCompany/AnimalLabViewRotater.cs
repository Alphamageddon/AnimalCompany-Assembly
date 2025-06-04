namespace AnimalCompany;

public class AnimalLabViewRotater : MonoBehaviour
{
	public UIScrollWheel scrollWheel; //Field offset: 0x20
	public float sensitivity; //Field offset: 0x28

	public AnimalLabViewRotater() { }

	private void Awake() { }

	private bool OnTurn(float value) { }

}

