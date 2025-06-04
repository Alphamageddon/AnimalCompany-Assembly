namespace AnimalCompany;

public class KillPlayerTrigger : MonoBehaviour
{
	private const string COMPONENT_NAME = "KillPlayerTrigger"; //Field offset: 0x0
	public RandomSFX deathSFX; //Field offset: 0x20
	private bool _isPlayerInTrigger; //Field offset: 0x28
	private float _timeToDie; //Field offset: 0x2C
	private float _timer; //Field offset: 0x30

	public KillPlayerTrigger() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	private void Update() { }

}

